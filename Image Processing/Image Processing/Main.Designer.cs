namespace Image_Processing
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel = new System.Windows.Forms.Panel();
            this.NegativeFilter = new System.Windows.Forms.PictureBox();
            this.SepiaFilter = new System.Windows.Forms.PictureBox();
            this.GrayscaleFilter = new System.Windows.Forms.PictureBox();
            this.Histogram = new System.Windows.Forms.PictureBox();
            this.blur = new System.Windows.Forms.PictureBox();
            this.mirror = new System.Windows.Forms.PictureBox();
            this.blue = new System.Windows.Forms.PictureBox();
            this.green = new System.Windows.Forms.PictureBox();
            this.red = new System.Windows.Forms.PictureBox();
            this.Default = new System.Windows.Forms.PictureBox();
            this.Open_btn = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.LableNoImg = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.imgpanel = new System.Windows.Forms.Panel();
            this.LableNoFilter = new System.Windows.Forms.Label();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.PictureOriginal = new System.Windows.Forms.PictureBox();
            this.LoadTx = new System.Windows.Forms.Label();
            this.LoadingTimer = new System.Windows.Forms.Timer(this.components);
            this.More = new System.Windows.Forms.Panel();
            this.Sharpen = new System.Windows.Forms.Button();
            this.Emboss = new System.Windows.Forms.Button();
            this.ButtomSobel = new System.Windows.Forms.Button();
            this.Outline = new System.Windows.Forms.Button();
            this.RightSobel = new System.Windows.Forms.Button();
            this.TopSobel = new System.Windows.Forms.Button();
            this.LeftSobel = new System.Windows.Forms.Button();
            this.More_btn = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NegativeFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SepiaFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrayscaleFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Histogram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mirror)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Default)).BeginInit();
            this.imgpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureOriginal)).BeginInit();
            this.More.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.NegativeFilter);
            this.panel.Controls.Add(this.SepiaFilter);
            this.panel.Controls.Add(this.GrayscaleFilter);
            this.panel.Controls.Add(this.Histogram);
            this.panel.Controls.Add(this.blur);
            this.panel.Controls.Add(this.mirror);
            this.panel.Controls.Add(this.blue);
            this.panel.Controls.Add(this.green);
            this.panel.Controls.Add(this.red);
            this.panel.Controls.Add(this.Default);
            this.panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel.Location = new System.Drawing.Point(0, 390);
            this.panel.MaximumSize = new System.Drawing.Size(999999, 80);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(890, 63);
            this.panel.TabIndex = 1;
            // 
            // NegativeFilter
            // 
            this.NegativeFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NegativeFilter.BackColor = System.Drawing.Color.Transparent;
            this.NegativeFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NegativeFilter.Image = global::Image_Processing.Properties.Resources._9;
            this.NegativeFilter.Location = new System.Drawing.Point(795, 7);
            this.NegativeFilter.Name = "NegativeFilter";
            this.NegativeFilter.Size = new System.Drawing.Size(81, 48);
            this.NegativeFilter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.NegativeFilter.TabIndex = 9;
            this.NegativeFilter.TabStop = false;
            this.NegativeFilter.Click += new System.EventHandler(this.NegativeFilter_Click);
            this.NegativeFilter.MouseLeave += new System.EventHandler(this.M_MouseLeave);
            this.NegativeFilter.MouseHover += new System.EventHandler(this.NegativeFilter_MouseHover);
            // 
            // SepiaFilter
            // 
            this.SepiaFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SepiaFilter.BackColor = System.Drawing.Color.Transparent;
            this.SepiaFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SepiaFilter.Image = global::Image_Processing.Properties.Resources._8;
            this.SepiaFilter.Location = new System.Drawing.Point(708, 7);
            this.SepiaFilter.Name = "SepiaFilter";
            this.SepiaFilter.Size = new System.Drawing.Size(81, 48);
            this.SepiaFilter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SepiaFilter.TabIndex = 8;
            this.SepiaFilter.TabStop = false;
            this.SepiaFilter.Click += new System.EventHandler(this.SepiaFilter_Click);
            this.SepiaFilter.MouseLeave += new System.EventHandler(this.M_MouseLeave);
            this.SepiaFilter.MouseHover += new System.EventHandler(this.SepiaFilter_MouseHover);
            // 
            // GrayscaleFilter
            // 
            this.GrayscaleFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GrayscaleFilter.BackColor = System.Drawing.Color.Transparent;
            this.GrayscaleFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GrayscaleFilter.Image = global::Image_Processing.Properties.Resources._7;
            this.GrayscaleFilter.Location = new System.Drawing.Point(621, 7);
            this.GrayscaleFilter.Name = "GrayscaleFilter";
            this.GrayscaleFilter.Size = new System.Drawing.Size(81, 48);
            this.GrayscaleFilter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GrayscaleFilter.TabIndex = 7;
            this.GrayscaleFilter.TabStop = false;
            this.GrayscaleFilter.Click += new System.EventHandler(this.GrayscaleFilter_Click);
            this.GrayscaleFilter.MouseLeave += new System.EventHandler(this.M_MouseLeave);
            this.GrayscaleFilter.MouseHover += new System.EventHandler(this.GrayscaleFilter_MouseHover);
            // 
            // Histogram
            // 
            this.Histogram.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Histogram.BackColor = System.Drawing.Color.Transparent;
            this.Histogram.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Histogram.Image = global::Image_Processing.Properties.Resources._6;
            this.Histogram.Location = new System.Drawing.Point(534, 7);
            this.Histogram.Name = "Histogram";
            this.Histogram.Size = new System.Drawing.Size(81, 48);
            this.Histogram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Histogram.TabIndex = 6;
            this.Histogram.TabStop = false;
            this.Histogram.Click += new System.EventHandler(this.Histogram_Click);
            this.Histogram.MouseLeave += new System.EventHandler(this.M_MouseLeave);
            this.Histogram.MouseHover += new System.EventHandler(this.Histogram_MouseHover);
            // 
            // blur
            // 
            this.blur.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.blur.BackColor = System.Drawing.Color.Transparent;
            this.blur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.blur.Image = global::Image_Processing.Properties.Resources._5;
            this.blur.Location = new System.Drawing.Point(447, 7);
            this.blur.Name = "blur";
            this.blur.Size = new System.Drawing.Size(81, 48);
            this.blur.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.blur.TabIndex = 5;
            this.blur.TabStop = false;
            this.blur.Click += new System.EventHandler(this.blur_Click);
            this.blur.MouseLeave += new System.EventHandler(this.M_MouseLeave);
            this.blur.MouseHover += new System.EventHandler(this.blur_MouseHover);
            // 
            // mirror
            // 
            this.mirror.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mirror.BackColor = System.Drawing.Color.Transparent;
            this.mirror.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mirror.Image = global::Image_Processing.Properties.Resources._4;
            this.mirror.Location = new System.Drawing.Point(360, 7);
            this.mirror.Name = "mirror";
            this.mirror.Size = new System.Drawing.Size(81, 48);
            this.mirror.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mirror.TabIndex = 4;
            this.mirror.TabStop = false;
            this.mirror.Click += new System.EventHandler(this.mirror_Click);
            this.mirror.MouseLeave += new System.EventHandler(this.M_MouseLeave);
            this.mirror.MouseHover += new System.EventHandler(this.mirror_MouseHover);
            // 
            // blue
            // 
            this.blue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.blue.BackColor = System.Drawing.Color.Transparent;
            this.blue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.blue.Image = global::Image_Processing.Properties.Resources._3;
            this.blue.Location = new System.Drawing.Point(273, 7);
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(81, 48);
            this.blue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.blue.TabIndex = 3;
            this.blue.TabStop = false;
            this.blue.Click += new System.EventHandler(this.blue_Click);
            this.blue.MouseLeave += new System.EventHandler(this.M_MouseLeave);
            this.blue.MouseHover += new System.EventHandler(this.blue_MouseHover);
            // 
            // green
            // 
            this.green.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.green.BackColor = System.Drawing.Color.Transparent;
            this.green.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.green.Image = global::Image_Processing.Properties.Resources._2;
            this.green.Location = new System.Drawing.Point(186, 7);
            this.green.Name = "green";
            this.green.Size = new System.Drawing.Size(81, 48);
            this.green.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.green.TabIndex = 2;
            this.green.TabStop = false;
            this.green.Click += new System.EventHandler(this.green_Click);
            this.green.MouseLeave += new System.EventHandler(this.M_MouseLeave);
            this.green.MouseHover += new System.EventHandler(this.green_MouseHover);
            // 
            // red
            // 
            this.red.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.red.BackColor = System.Drawing.Color.Transparent;
            this.red.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.red.Image = global::Image_Processing.Properties.Resources._1;
            this.red.Location = new System.Drawing.Point(99, 7);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(81, 48);
            this.red.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.red.TabIndex = 1;
            this.red.TabStop = false;
            this.red.Click += new System.EventHandler(this.red_Click);
            this.red.MouseLeave += new System.EventHandler(this.M_MouseLeave);
            this.red.MouseHover += new System.EventHandler(this.red_MouseHover);
            // 
            // Default
            // 
            this.Default.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Default.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Default.Image = global::Image_Processing.Properties.Resources._0;
            this.Default.Location = new System.Drawing.Point(12, 7);
            this.Default.Name = "Default";
            this.Default.Size = new System.Drawing.Size(81, 48);
            this.Default.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Default.TabIndex = 0;
            this.Default.TabStop = false;
            this.Default.Click += new System.EventHandler(this.Default_Click);
            this.Default.MouseLeave += new System.EventHandler(this.M_MouseLeave);
            this.Default.MouseHover += new System.EventHandler(this.Default_MouseHover);
            // 
            // Open_btn
            // 
            this.Open_btn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Open_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Open_btn.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Open_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.Open_btn.Location = new System.Drawing.Point(5, 7);
            this.Open_btn.Name = "Open_btn";
            this.Open_btn.Size = new System.Drawing.Size(105, 27);
            this.Open_btn.TabIndex = 3;
            this.Open_btn.Text = "Open";
            this.Open_btn.UseVisualStyleBackColor = false;
            this.Open_btn.Click += new System.EventHandler(this.Open_btn_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Clear.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.ForeColor = System.Drawing.SystemColors.Control;
            this.Clear.Location = new System.Drawing.Point(112, 7);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(105, 27);
            this.Clear.TabIndex = 4;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // LableNoImg
            // 
            this.LableNoImg.AutoSize = true;
            this.LableNoImg.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LableNoImg.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LableNoImg.Location = new System.Drawing.Point(115, 160);
            this.LableNoImg.Name = "LableNoImg";
            this.LableNoImg.Size = new System.Drawing.Size(182, 24);
            this.LableNoImg.TabIndex = 5;
            this.LableNoImg.Text = "No image selected!";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // imgpanel
            // 
            this.imgpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgpanel.Controls.Add(this.LableNoFilter);
            this.imgpanel.Controls.Add(this.PictureBox);
            this.imgpanel.Controls.Add(this.LableNoImg);
            this.imgpanel.Controls.Add(this.PictureOriginal);
            this.imgpanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.imgpanel.Location = new System.Drawing.Point(0, 40);
            this.imgpanel.Name = "imgpanel";
            this.imgpanel.Size = new System.Drawing.Size(890, 350);
            this.imgpanel.TabIndex = 7;
            // 
            // LableNoFilter
            // 
            this.LableNoFilter.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LableNoFilter.AutoSize = true;
            this.LableNoFilter.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LableNoFilter.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LableNoFilter.Location = new System.Drawing.Point(584, 160);
            this.LableNoFilter.Name = "LableNoFilter";
            this.LableNoFilter.Size = new System.Drawing.Size(175, 24);
            this.LableNoFilter.TabIndex = 7;
            this.LableNoFilter.Text = "No filter selected!";
            // 
            // PictureBox
            // 
            this.PictureBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBox.Location = new System.Drawing.Point(447, 8);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(436, 332);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox.TabIndex = 6;
            this.PictureBox.TabStop = false;
            // 
            // PictureOriginal
            // 
            this.PictureOriginal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PictureOriginal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureOriginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureOriginal.Location = new System.Drawing.Point(5, 8);
            this.PictureOriginal.Name = "PictureOriginal";
            this.PictureOriginal.Size = new System.Drawing.Size(436, 332);
            this.PictureOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureOriginal.TabIndex = 2;
            this.PictureOriginal.TabStop = false;
            // 
            // LoadTx
            // 
            this.LoadTx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadTx.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadTx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LoadTx.Location = new System.Drawing.Point(705, 9);
            this.LoadTx.Name = "LoadTx";
            this.LoadTx.Size = new System.Drawing.Size(133, 19);
            this.LoadTx.TabIndex = 8;
            this.LoadTx.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LoadingTimer
            // 
            this.LoadingTimer.Interval = 1000;
            this.LoadingTimer.Tick += new System.EventHandler(this.LoadingTimer_Tick);
            // 
            // More
            // 
            this.More.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.More.Controls.Add(this.LeftSobel);
            this.More.Controls.Add(this.RightSobel);
            this.More.Controls.Add(this.TopSobel);
            this.More.Controls.Add(this.ButtomSobel);
            this.More.Controls.Add(this.Outline);
            this.More.Controls.Add(this.Emboss);
            this.More.Controls.Add(this.Sharpen);
            this.More.ForeColor = System.Drawing.SystemColors.Control;
            this.More.Location = new System.Drawing.Point(747, 29);
            this.More.MaximumSize = new System.Drawing.Size(137, 243);
            this.More.MinimumSize = new System.Drawing.Size(137, 0);
            this.More.Name = "More";
            this.More.Size = new System.Drawing.Size(137, 0);
            this.More.TabIndex = 9;
            this.More.Visible = false;
            // 
            // Sharpen
            // 
            this.Sharpen.BackColor = System.Drawing.Color.Transparent;
            this.Sharpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sharpen.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sharpen.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Sharpen.Location = new System.Drawing.Point(6, 9);
            this.Sharpen.Name = "Sharpen";
            this.Sharpen.Size = new System.Drawing.Size(123, 27);
            this.Sharpen.TabIndex = 4;
            this.Sharpen.Text = "Sharpen";
            this.Sharpen.UseVisualStyleBackColor = false;
            this.Sharpen.Click += new System.EventHandler(this.Sharpen_Click);
            // 
            // Emboss
            // 
            this.Emboss.BackColor = System.Drawing.Color.Transparent;
            this.Emboss.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Emboss.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emboss.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Emboss.Location = new System.Drawing.Point(6, 42);
            this.Emboss.Name = "Emboss";
            this.Emboss.Size = new System.Drawing.Size(123, 27);
            this.Emboss.TabIndex = 5;
            this.Emboss.Text = "Emboss";
            this.Emboss.UseVisualStyleBackColor = false;
            this.Emboss.Click += new System.EventHandler(this.Emboss_Click);
            // 
            // ButtomSobel
            // 
            this.ButtomSobel.BackColor = System.Drawing.Color.Transparent;
            this.ButtomSobel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtomSobel.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtomSobel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ButtomSobel.Location = new System.Drawing.Point(6, 108);
            this.ButtomSobel.Name = "ButtomSobel";
            this.ButtomSobel.Size = new System.Drawing.Size(123, 27);
            this.ButtomSobel.TabIndex = 7;
            this.ButtomSobel.Text = "Buttom Sobel";
            this.ButtomSobel.UseVisualStyleBackColor = false;
            this.ButtomSobel.Click += new System.EventHandler(this.ButtomSobel_Click);
            // 
            // Outline
            // 
            this.Outline.BackColor = System.Drawing.Color.Transparent;
            this.Outline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Outline.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outline.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Outline.Location = new System.Drawing.Point(6, 75);
            this.Outline.Name = "Outline";
            this.Outline.Size = new System.Drawing.Size(123, 27);
            this.Outline.TabIndex = 6;
            this.Outline.Text = "Outline";
            this.Outline.UseVisualStyleBackColor = false;
            this.Outline.Click += new System.EventHandler(this.Outline_Click);
            // 
            // RightSobel
            // 
            this.RightSobel.BackColor = System.Drawing.Color.Transparent;
            this.RightSobel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RightSobel.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RightSobel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.RightSobel.Location = new System.Drawing.Point(6, 174);
            this.RightSobel.Name = "RightSobel";
            this.RightSobel.Size = new System.Drawing.Size(123, 27);
            this.RightSobel.TabIndex = 9;
            this.RightSobel.Text = "Right Sobel";
            this.RightSobel.UseVisualStyleBackColor = false;
            this.RightSobel.Click += new System.EventHandler(this.RightSobel_Click);
            // 
            // TopSobel
            // 
            this.TopSobel.BackColor = System.Drawing.Color.Transparent;
            this.TopSobel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TopSobel.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopSobel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TopSobel.Location = new System.Drawing.Point(6, 141);
            this.TopSobel.Name = "TopSobel";
            this.TopSobel.Size = new System.Drawing.Size(123, 27);
            this.TopSobel.TabIndex = 8;
            this.TopSobel.Text = "Top Sobel";
            this.TopSobel.UseVisualStyleBackColor = false;
            this.TopSobel.Click += new System.EventHandler(this.TopSobel_Click);
            // 
            // LeftSobel
            // 
            this.LeftSobel.BackColor = System.Drawing.Color.Transparent;
            this.LeftSobel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LeftSobel.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftSobel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LeftSobel.Location = new System.Drawing.Point(6, 207);
            this.LeftSobel.Name = "LeftSobel";
            this.LeftSobel.Size = new System.Drawing.Size(123, 27);
            this.LeftSobel.TabIndex = 10;
            this.LeftSobel.Text = "Left Sobel";
            this.LeftSobel.UseVisualStyleBackColor = false;
            this.LeftSobel.Click += new System.EventHandler(this.LeftSobel_Click);
            // 
            // More_btn
            // 
            this.More_btn.BackColor = System.Drawing.Color.Transparent;
            this.More_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.More_btn.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.More_btn.ForeColor = System.Drawing.Color.DarkGray;
            this.More_btn.Location = new System.Drawing.Point(845, 6);
            this.More_btn.Name = "More_btn";
            this.More_btn.Size = new System.Drawing.Size(39, 22);
            this.More_btn.TabIndex = 10;
            this.More_btn.Text = "˅";
            this.More_btn.UseVisualStyleBackColor = false;
            this.More_btn.Click += new System.EventHandler(this.More_btn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(890, 453);
            this.Controls.Add(this.More_btn);
            this.Controls.Add(this.More);
            this.Controls.Add(this.LoadTx);
            this.Controls.Add(this.imgpanel);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Open_btn);
            this.Controls.Add(this.panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(906, 492);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(906, 492);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Processing Project";
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NegativeFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SepiaFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrayscaleFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Histogram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mirror)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Default)).EndInit();
            this.imgpanel.ResumeLayout(false);
            this.imgpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureOriginal)).EndInit();
            this.More.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox Histogram;
        private System.Windows.Forms.PictureBox blur;
        private System.Windows.Forms.PictureBox mirror;
        private System.Windows.Forms.PictureBox blue;
        private System.Windows.Forms.PictureBox green;
        private System.Windows.Forms.PictureBox red;
        private System.Windows.Forms.PictureBox Default;
        private System.Windows.Forms.PictureBox PictureOriginal;
        private System.Windows.Forms.Button Open_btn;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Label LableNoImg;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox GrayscaleFilter;
        private System.Windows.Forms.Panel imgpanel;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Label LableNoFilter;
        private System.Windows.Forms.PictureBox SepiaFilter;
        private System.Windows.Forms.PictureBox NegativeFilter;
        private System.Windows.Forms.Label LoadTx;
        private System.Windows.Forms.Timer LoadingTimer;
        private System.Windows.Forms.Panel More;
        private System.Windows.Forms.Button Sharpen;
        private System.Windows.Forms.Button RightSobel;
        private System.Windows.Forms.Button TopSobel;
        private System.Windows.Forms.Button ButtomSobel;
        private System.Windows.Forms.Button Outline;
        private System.Windows.Forms.Button Emboss;
        private System.Windows.Forms.Button LeftSobel;
        private System.Windows.Forms.Button More_btn;
    }
}

