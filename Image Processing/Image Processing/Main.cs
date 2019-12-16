using openCV;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading;
using System.Windows.Forms;

namespace Image_Processing
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }


        //<-- (Start||End) Tasks -->//
        #region Tasks Head
        private void NewTask()
        {
            End = false;
            panel.Enabled = false;
            More.Height = 0;
            More.Visible = false;
            LoadingTimer.Start();
        }
        private void Done()
        {
            End = true;
            Loadval = 0;
        }
        #endregion

        //<-- Definitions -->//
        #region Definitions
        Bitmap bmp, rbmp, gbmp, bbmp;
        static byte Loadval = 0;
        static bool End = true;
        int width = 0, height = 0, x = 0;
        Random rand = new Random();
        #endregion


        //<-- Action Buttons -->//
        #region Buttons
        //<-- Open Image -->//
        private void Open_btn_Click(object sender, EventArgs e)
        {
            Clear_Click(sender, e);
            openFileDialog1.FileName = " ";
            openFileDialog1.Filter = "JPEG|*JPG|Bitmap|*.bmp|All|*.*-11";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    NewTask();
                    //image path
                    string img = openFileDialog1.FileName;

                    //read image
                    bmp = new Bitmap(img);

                    //load original image in picturebox1
                    PictureOriginal.Image = Image.FromFile(img);

                    //get image dimension
                    width = bmp.Width;
                    height = bmp.Height;
                    x = width * height;
                    //3 bitmap for red green blue image
                    rbmp = new Bitmap(bmp);
                    gbmp = new Bitmap(bmp);
                    bbmp = new Bitmap(bmp);

                    //red green blue image
                    for (int y = 0; y < height; y++)
                    {
                        for (int x = 0; x < width; x++)
                        {
                            //get pixel value
                            Color p = bmp.GetPixel(x, y);

                            //extract ARGB value from p     ::      A => for Alpha [a] .. it's opacity.
                            int a = p.A;
                            int r = p.R;
                            int g = p.G;
                            int b = p.B;

                            //set red image pixel
                            rbmp.SetPixel(x, y, Color.FromArgb(a, r, 0, 0));

                            //set green image pixel
                            gbmp.SetPixel(x, y, Color.FromArgb(a, 0, g, 0));

                            //set blue image pixel
                            bbmp.SetPixel(x, y, Color.FromArgb(a, 0, 0, b));

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Done();
                LableNoImg.Visible = false;
            }

        }
        private void Default_Click(object sender, EventArgs e)
        {
            PictureBox.Image = bmp;
            PictureOriginal.Image = bmp;
            LableNoFilter.Visible = false;
        }




        //<-- Red Filter -->//
        private void red_Click(object sender, EventArgs e)
        {
            PictureBox.Image = rbmp;
            PictureOriginal.Image = bmp;
            LableNoFilter.Visible = false;
        }

        //<-- Green Filter -->//
        private void green_Click(object sender, EventArgs e)
        {
            PictureBox.Image = gbmp;
            PictureOriginal.Image = bmp;
            LableNoFilter.Visible = false;
        }

        //<-- Blue Filter -->//
        private void blue_Click(object sender, EventArgs e)
        {
            PictureBox.Image = bbmp;
            PictureOriginal.Image = bmp;
            LableNoFilter.Visible = false;
        }

        //<-- Mirror Filter -->//
        private void mirror_Click(object sender, EventArgs e)
        {
            LableNoFilter.Visible = false;
            NewTask();
            Thread t = new Thread(() =>
            {

                Bitmap mirrored = new Bitmap(bmp.Width, bmp.Height);
                for (int i = 0; i < bmp.Height; i++)
                    for (int j = 0; j < bmp.Width; j++)
                    {
                        //get source pixel value
                        Color p = bmp.GetPixel(bmp.Width - j - 1, i);
                        mirrored.SetPixel(j, i, p);
                    }
                Done();
                //load mirror image in picturebox2
                PictureBox.Image = mirrored;
                PictureOriginal.Image = bmp;
            });
            t.Start();
        }
        


        //<-- Blur Filter -->//
        private void blur_Click(object sender, EventArgs e)
        {
            LableNoFilter.Visible = false;
            NewTask();
            Thread t = new Thread(() =>
            {
                //blur image
                Bitmap bimg = new Bitmap(bmp);

                for (int x = 9; x <= width - 9; x++)
                {
                    for (int y = 9; y <= height - 9; y++)
                    {
                        try
                        {
                            Color preuX = bimg.GetPixel(x - 9, y);
                            Color nextX = bimg.GetPixel(x + 9, y);
                            Color preuY = bimg.GetPixel(x, y - 9);
                            Color nextY = bimg.GetPixel(x, y + 9);

                            int avgR = (int)((preuX.R + nextX.R + preuY.R + nextY.R) / 4);
                            int avgG = (int)((preuX.G + nextX.G + preuY.G + nextY.G) / 4);
                            int avgB = (int)((preuX.B + nextX.B + preuY.B + nextY.B) / 4);

                            bimg.SetPixel(x, y, Color.FromArgb(avgR, avgG, avgB));
                        }
                        catch (Exception)
                        {

                        }
                    }
                }
                Done();

                //load blur image in picturebox2
                PictureBox.Image = bimg;
                PictureOriginal.Image = bmp;
            });
            t.Start();
        }




        //<-- Grayscale Filter -->//
        private void GrayscaleFilter_Click(object sender, EventArgs e)
        {
            LableNoFilter.Visible = false;
            NewTask();
            Thread t = new Thread(() =>
            {
                PictureBox.Image = BaseClass.DrawAsGrayscale(PictureOriginal.Image);
                PictureOriginal.Image = bmp;
                Done();
            });
            t.Start();
        }

        //<-- Sepia Filter -->//
        private void SepiaFilter_Click(object sender, EventArgs e)
        {
            LableNoFilter.Visible = false;
            NewTask();
            Thread t = new Thread(() =>
            {
                Bitmap tempbmp = bmp;
                PictureBox.Image = BaseClass.DoFilter(tempbmp, 1);
                PictureOriginal.Image = bmp;
                Done();
            });
            t.Start();
        }

        //<-- Negative Filter -->//
        private void NegativeFilter_Click(object sender, EventArgs e)
        {
            LableNoFilter.Visible = false;
            NewTask();
            Thread t = new Thread(() =>
            {
                PictureBox.Image = BaseClass.DrawAsNegative(PictureOriginal.Image);
                PictureOriginal.Image = bmp;
                Done();
            });
            t.Start();
        }




        //<-- Histogram -->//
        static double Clamp(double val, double min, double max)
        {
            return Math.Min(Math.Max(val, min), max);
        }
        private void Histogram_Click(object sender, EventArgs e)
        {
            LableNoFilter.Visible = false;
            NewTask();
            Thread t = new Thread(() =>
            {
                EqualizeHistogram();
                Done();
            });
            t.Start();
        }
        public void EqualizeHistogram()
        {
            Bitmap origImage = new Bitmap(bmp);

            double blackPointPercent = 0.01;
            double whitePointPercent = 0.03;
            BitmapData srcData = origImage.LockBits(new Rectangle(0, 0, origImage.Width, origImage.Height), ImageLockMode.ReadOnly,
       PixelFormat.Format32bppArgb);
            Bitmap destImage = new Bitmap(origImage.Width, origImage.Height);
            BitmapData destData = destImage.LockBits(new Rectangle(0, 0, destImage.Width, destImage.Height),
                ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);
            int stride = srcData.Stride;
            IntPtr srcScan0 = srcData.Scan0;
            IntPtr destScan0 = destData.Scan0;
            var freq = new int[256];
            unsafe
            {
                byte* src = (byte*)srcScan0;
                for (int y = 0; y < origImage.Height; ++y)
                {
                    for (int x = 0; x < origImage.Width; ++x)
                    {
                        ++freq[src[y * stride + x * 4]];
                    }
                }

                int numPixels = origImage.Width * origImage.Height;
                int minI = 0;
                var blackPixels = numPixels * blackPointPercent;
                int accum = 0;

                while (minI < 255)
                {
                    accum += freq[minI];
                    if (accum > blackPixels) break;
                    ++minI;
                }

                int maxI = 255;
                var whitePixels = numPixels * whitePointPercent;
                accum = 0;

                while (maxI > 0)
                {
                    accum += freq[maxI];
                    if (accum > whitePixels) break;
                    --maxI;
                }
                double spread = 255d / (maxI - minI);
                byte* dst = (byte*)destScan0;
                for (int y = 0; y < origImage.Height; ++y)
                {
                    for (int x = 0; x < origImage.Width; ++x)
                    {
                        int i = y * stride + x * 4;

                        byte val = (byte)Clamp(Math.Round((src[i] - minI) * spread), 0, 255);
                        dst[i] = val;
                        dst[i + 1] = val;
                        dst[i + 2] = val;
                        dst[i + 3] = 255;
                    }
                }
                origImage.UnlockBits(srcData);
                destImage.UnlockBits(destData);
                Bitmap bmpb = new Bitmap(destImage);
                PictureOriginal.SizeMode = PictureBoxSizeMode.Zoom;
                PictureOriginal.Image = destImage;
                int[] histogram_r = new int[256];
                float max = 0;

                for (int i = 0; i < bmpb.Width; i++)
                {
                    for (int j = 0; j < bmpb.Height; j++)
                    {
                        int redValue = bmpb.GetPixel(i, j).R;
                        histogram_r[redValue]++;
                        if (max < histogram_r[redValue])
                            max = histogram_r[redValue];
                    }
                }

                int histHeight = 232;
                Bitmap imga = new Bitmap(256, histHeight + 10);
                using (Graphics g = Graphics.FromImage(imga))
                {
                    for (int i = 0; i < histogram_r.Length; i++)
                    {
                        float pct = histogram_r[i] / max;   // What percentage of the max is this value?
                        g.DrawLine(Pens.RoyalBlue,
                            new Point(i, imga.Height - 5),
                            new Point(i, imga.Height - 5 - (int)(pct * histHeight))  // Use that percentage of the height
                            );
                    }
                }
                PictureBox.Image = imga;
            }
        }


        //<-- Clear -->//
        private void Clear_Click(object sender, EventArgs e)
        {
            bmp = rbmp = gbmp = bbmp = null;
            PictureOriginal.Image = PictureBox.Image = null;
            LableNoFilter.Visible = true;
            LableNoImg.Visible = true;
        }
        #endregion


        //<-- Mouse Hover -->//
        #region Hover
        private void Default_MouseHover(object sender, EventArgs e)
        {
            LoadTx.Text = "Default";
        }
        private void red_MouseHover(object sender, EventArgs e)
        {
            LoadTx.Text = "Red Filter";
        }
        private void green_MouseHover(object sender, EventArgs e)
        {
            LoadTx.Text = "Green Filter";
        }
        private void blue_MouseHover(object sender, EventArgs e)
        {
            LoadTx.Text = "Blue Filter";
        }
        private void mirror_MouseHover(object sender, EventArgs e)
        {
            LoadTx.Text = "Mirror";
        }


        private void blur_MouseHover(object sender, EventArgs e)
        {
            LoadTx.Text = "Blur";
        }

        private void Histogram_MouseHover(object sender, EventArgs e)
        {
            LoadTx.Text = "Histogram";
        }

        private void More_btn_Click(object sender, EventArgs e)
        {
            if (More.Height < 243)
            { More.Height = 243; More.Visible = true; }
            else
            { More.Height = 0; More.Visible = false; }
        }

        private void Sharpen_Click(object sender, EventArgs e)
        {
            LableNoFilter.Visible = false;
            NewTask();
            Thread t = new Thread(() =>
            {
                Bitmap tempbmp = bmp;
                PictureBox.Image = BaseClass.DoFilter(tempbmp,1);
                PictureOriginal.Image = bmp;
                Done();
            });
            t.Start();
        }

        private void Emboss_Click(object sender, EventArgs e)
        {
            LableNoFilter.Visible = false;
            NewTask();
            Thread t = new Thread(() =>
            {
                Bitmap tempbmp = bmp;
                PictureBox.Image = BaseClass.DoFilter(tempbmp, 2);
                PictureOriginal.Image = bmp;
                Done();
            });
            t.Start();
        }

        private void Outline_Click(object sender, EventArgs e)
        {
            LableNoFilter.Visible = false;
            NewTask();
            Thread t = new Thread(() =>
            {
                Bitmap tempbmp = bmp;
                PictureBox.Image = BaseClass.DoFilter(tempbmp, 3);
                PictureOriginal.Image = bmp;
                Done();
            });
            t.Start();
        }

        private void ButtomSobel_Click(object sender, EventArgs e)
        {
            LableNoFilter.Visible = false;
            NewTask();
            Thread t = new Thread(() =>
            {
                Bitmap tempbmp = bmp;
                PictureBox.Image = BaseClass.DoFilter(tempbmp, 4);
                PictureOriginal.Image = bmp;
                Done();
            });
            t.Start();
        }

        private void TopSobel_Click(object sender, EventArgs e)
        {
            LableNoFilter.Visible = false;
            NewTask();
            Thread t = new Thread(() =>
            {
                Bitmap tempbmp = bmp;
                PictureBox.Image = BaseClass.DoFilter(tempbmp, 5);
                PictureOriginal.Image = bmp;
                Done();
            });
            t.Start();
        }

        private void RightSobel_Click(object sender, EventArgs e)
        {
            LableNoFilter.Visible = false;
            NewTask();
            Thread t = new Thread(() =>
            {
                Bitmap tempbmp = bmp;
                PictureBox.Image = BaseClass.DoFilter(tempbmp, 6);
                PictureOriginal.Image = bmp;
                Done();
            });
            t.Start();
        }

        private void LeftSobel_Click(object sender, EventArgs e)
        {
            LableNoFilter.Visible = false;
            NewTask();
            Thread t = new Thread(() =>
            {
                Bitmap tempbmp = bmp;
                PictureBox.Image = BaseClass.DoFilter(tempbmp, 7);
                PictureOriginal.Image = bmp;
                Done();
            });
            t.Start();
        }

        private void GrayscaleFilter_MouseHover(object sender, EventArgs e)
        {
            LoadTx.Text = "Grayscale Filter";
        }
        private void SepiaFilter_MouseHover(object sender, EventArgs e)
        {
            LoadTx.Text = "Sepia Filter";
        }
        private void NegativeFilter_MouseHover(object sender, EventArgs e)
        {
            LoadTx.Text = "Negative Filter";
        }

        private void M_MouseLeave(object sender, EventArgs e)
        {
            LoadTx.Text = "";
        }
        #endregion


        //<-- Loading Timer -->//
        private void LoadingTimer_Tick(object sender, EventArgs e)
        {
            if (LoadTx.Text == "")
                LoadTx.Text = "Loading... ( 0% )";
            else if (End)
            {
                LoadTx.Text = "Loading... ( 100% )";
                System.Threading.Thread.Sleep(600);
                LoadTx.Text = "Done!";
                LoadingTimer.Interval = 100;
                LoadingTimer.Stop();
                panel.Enabled = true;
                return;
            }
            else if (Loadval < 98 && Loadval > 93)
            {
                LoadingTimer.Interval = rand.Next(1300, 2500);
            }
            else if (Loadval < 93)
            {
                LoadingTimer.Interval = rand.Next(100, 300);
            }
            else
            {
                LoadingTimer.Interval = 100;
                LoadingTimer.Stop();
                panel.Enabled = true;
            }
            Loadval++;
            LoadTx.Text = "Loading... ( " + Loadval + "% )";
        }

    }

}
