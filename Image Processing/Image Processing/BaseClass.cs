using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace Image_Processing
{
    public static class BaseClass
    {
        public static double[,] filter = new double[3, 3];

        public static void Matrix(byte t)
        {
            switch (t)
            {
                case 1: // Sharpen
                    filter[0, 0] = filter[0, 1] = filter[0, 2] = filter[1, 0] = filter[1, 2] = filter[2, 0] = filter[2, 1] = filter[2, 2] = -1;
                    filter[1, 1] = 9;
                    break;
                case 2: // Emboss
                    filter[0, 0] = -2; filter[0, 1] = -1; filter[0, 2] = 0; filter[1, 0] = -1; filter[1, 1] = 1; filter[1, 2] = 1; filter[2, 0] = 0; filter[2, 1] = 1; filter[2, 2] = 2;
                    break;
                case 3: // Outline && Edge detection
                    filter[0, 0] = filter[0, 1] = filter[0, 2] = filter[1, 0] = filter[1, 2] = filter[2, 0] = filter[2, 1] = filter[2, 2] = -1;
                    filter[1, 1] = 8; 
                    break;
                case 4: // Buttom Sobel
                    filter[0, 0] = -1; filter[0, 1] = -2; filter[0, 2] = -1; filter[1, 0] = 0; filter[1, 1] = 0; filter[1, 2] = 0; filter[2, 0] = 1; filter[2, 1] = 2; filter[2, 2] = 1;
                    break;
                case 5: // Top Sobel
                    filter[0, 0] = 1; filter[0, 1] = 2; filter[0, 2] = 1; filter[1, 0] = 0; filter[1, 1] = 0; filter[1, 2] = 0; filter[2, 0] = -1; filter[2, 1] = -2; filter[2, 2] = -1;
                    break;
                case 6: // Right Sobel
                    filter[0, 0] = -1; filter[0, 1] = 0; filter[0, 2] = 1; filter[1, 0] = -2; filter[1, 1] = 0; filter[1, 2] = 2; filter[2, 0] = -1; filter[2, 1] = 0; filter[2, 2] = 1;
                    break;
                case 7: // Left Sobel
                    filter[0, 0] = 1; filter[0, 1] = 0; filter[0, 2] = -1; filter[1, 0] = 2; filter[1, 1] = 0; filter[1, 2] = -2; filter[2, 0] = 1; filter[2, 1] = 0; filter[2, 2] = -1;
                    break;
                default:
                    break;
            }
        }

        public static Bitmap DoFilter(Bitmap image,byte t)
        {
            Bitmap sharpenImage = (Bitmap)image.Clone();

            int filterWidth = 3;
            int filterHeight = 3;
            int width = image.Width;
            int height = image.Height;

            // Create sharpening filter.
            Matrix(t);

            double factor = 1.0;
            double bias = 0.0;

            Color[,] result = new Color[image.Width, image.Height];

            // Lock image bits for read/write.
            BitmapData pbits = sharpenImage.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            // Declare an array to hold the bytes of the bitmap.
            int bytes = pbits.Stride * height;
            byte[] rgbValues = new byte[bytes];

            // Copy the RGB values into the array.
            System.Runtime.InteropServices.Marshal.Copy(pbits.Scan0, rgbValues, 0, bytes);

            int rgb;
            // Fill the color array with the new sharpened color values.
            for (int x = 0; x < width; ++x)
            {
                for (int y = 0; y < height; ++y)
                {
                    double red = 0.0, green = 0.0, blue = 0.0;

                    for (int filterX = 0; filterX < filterWidth; filterX++)
                    {
                        for (int filterY = 0; filterY < filterHeight; filterY++)
                        {
                            int imageX = (x - filterWidth / 2 + filterX + width) % width;
                            int imageY = (y - filterHeight / 2 + filterY + height) % height;

                            rgb = imageY * pbits.Stride + 3 * imageX;

                            red += rgbValues[rgb + 2] * filter[filterX, filterY];
                            green += rgbValues[rgb + 1] * filter[filterX, filterY];
                            blue += rgbValues[rgb + 0] * filter[filterX, filterY];
                        }
                        int r = Math.Min(Math.Max((int)(factor * red + bias), 0), 255);
                        int g = Math.Min(Math.Max((int)(factor * green + bias), 0), 255);
                        int b = Math.Min(Math.Max((int)(factor * blue + bias), 0), 255);

                        result[x, y] = Color.FromArgb(r, g, b);
                    }
                }
            }

            // Update the image with the sharpened pixels.
            for (int x = 0; x < width; ++x)
            {
                for (int y = 0; y < height; ++y)
                {
                    rgb = y * pbits.Stride + 3 * x;

                    rgbValues[rgb + 2] = result[x, y].R;
                    rgbValues[rgb + 1] = result[x, y].G;
                    rgbValues[rgb + 0] = result[x, y].B;
                }
            }

            // Copy the RGB values back to the bitmap.
            System.Runtime.InteropServices.Marshal.Copy(rgbValues, 0, pbits.Scan0, bytes);
            // Release image bits.
            sharpenImage.UnlockBits(pbits);

            return sharpenImage;
        }


        public static Bitmap DrawAsGrayscale(Image sourceImage)
        {
            ColorMatrix colorMatrix = new ColorMatrix(new float[][]
                                {
                            new float[]{.3f, .3f, .3f, 0, 0},           // red scaling factor of .3
                            new float[]{.59f, .59f, .59f, 0, 0},        // green scaling factor of .59
                            new float[]{.11f, .11f, .11f, 0, 0},        // blue scaling factor of .11
                            new float[]{0, 0, 0, 1, 0},                 // alpha scaling factor of 1
                            new float[]{0, 0, 0, 0, 1}                  // three translations of 0
                                });


            return ApplyColorMatrix(sourceImage, colorMatrix);
        }

        public static Bitmap DrawAsSepiaTone(Image sourceImage)
        {
            ColorMatrix colorMatrix = new ColorMatrix(new float[][]
                       {
                        new float[]{.393f, .349f, .272f, 0, 0},
                        new float[]{.769f, .686f, .534f, 0, 0},
                        new float[]{.189f, .168f, .131f, 0, 0},
                        new float[]{0, 0, 0, 1, 0},
                        new float[]{0, 0, 0, 0, 1}
                       });


            return ApplyColorMatrix(sourceImage, colorMatrix);
        }   //Another code for Sharpen

        public static Bitmap DrawAsNegative(Image sourceImage)
        {
            ColorMatrix colorMatrix = new ColorMatrix(new float[][]
                           {
                            new float[]{-1, 0, 0, 0, 0},
                            new float[]{0, -1, 0, 0, 0},
                            new float[]{0, 0, -1, 0, 0},
                            new float[]{0, 0, 0, 1, 0},
                            new float[]{1, 1, 1, 1, 1}
                           });


            return ApplyColorMatrix(sourceImage, colorMatrix);
        }

        private static Bitmap GetArgbCopy(Image sourceImage)
        {
            Bitmap bmpNew = new Bitmap(sourceImage.Width, sourceImage.Height, PixelFormat.Format32bppArgb);


            using (Graphics graphics = Graphics.FromImage(bmpNew))
            {
                graphics.DrawImage(sourceImage, new Rectangle(0, 0, bmpNew.Width, bmpNew.Height), new Rectangle(0, 0, bmpNew.Width, bmpNew.Height), GraphicsUnit.Pixel);
                graphics.Flush();
            }


            return bmpNew;
        }

        private static Bitmap ApplyColorMatrix(Image sourceImage, ColorMatrix colorMatrix)
        {
            Bitmap bmp32BppSource = GetArgbCopy(sourceImage);
            Bitmap bmp32BppDest = new Bitmap(bmp32BppSource.Width, bmp32BppSource.Height, PixelFormat.Format32bppArgb);


            using (Graphics graphics = Graphics.FromImage(bmp32BppDest))
            {
                ImageAttributes bmpAttributes = new ImageAttributes();
                bmpAttributes.SetColorMatrix(colorMatrix);

                graphics.DrawImage(bmp32BppSource,
                    new Rectangle(0, 0, bmp32BppSource.Width, bmp32BppSource.Height),   // destination rectangle
                                    0, 0,                                               // upper-left corner of source rectangle
                                    bmp32BppSource.Width,                               // width of source rectangle
                                    bmp32BppSource.Height,                              // height of source rectangle
                                    GraphicsUnit.Pixel, bmpAttributes);
            }


            bmp32BppSource.Dispose();


            return bmp32BppDest;
        }
    }
}
