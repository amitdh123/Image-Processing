namespace ConvolutionRecreate
{
    partial class Form1
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
            this.select_image = new System.Windows.Forms.Button();
            this.orgPicture = new System.Windows.Forms.PictureBox();
            this.processImg = new System.Windows.Forms.PictureBox();
            this.r1col1 = new System.Windows.Forms.TextBox();
            this.r1col2 = new System.Windows.Forms.TextBox();
            this.r1col3 = new System.Windows.Forms.TextBox();
            this.r2col1 = new System.Windows.Forms.TextBox();
            this.r2col2 = new System.Windows.Forms.TextBox();
            this.r2col3 = new System.Windows.Forms.TextBox();
            this.r3col1 = new System.Windows.Forms.TextBox();
            this.r3col2 = new System.Windows.Forms.TextBox();
            this.r3col3 = new System.Windows.Forms.TextBox();
            this.labeldetail = new System.Windows.Forms.Label();
            this.convolveKernel = new System.Windows.Forms.Button();
            this.histogram = new System.Windows.Forms.PictureBox();
            this.histogramProcess = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.orgPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.histogram)).BeginInit();
            this.SuspendLayout();
            // 
            // select_image
            // 
            this.select_image.Location = new System.Drawing.Point(13, 13);
            this.select_image.Name = "select_image";
            this.select_image.Size = new System.Drawing.Size(189, 23);
            this.select_image.TabIndex = 0;
            this.select_image.Text = "Select Image";
            this.select_image.UseVisualStyleBackColor = true;
            this.select_image.Click += new System.EventHandler(this.button1_Click);
            // 
            // orgPicture
            // 
            this.orgPicture.Location = new System.Drawing.Point(218, 12);
            this.orgPicture.Name = "orgPicture";
            this.orgPicture.Size = new System.Drawing.Size(279, 225);
            this.orgPicture.TabIndex = 1;
            this.orgPicture.TabStop = false;
            // 
            // processImg
            // 
            this.processImg.Location = new System.Drawing.Point(545, 13);
            this.processImg.Name = "processImg";
            this.processImg.Size = new System.Drawing.Size(273, 224);
            this.processImg.TabIndex = 2;
            this.processImg.TabStop = false;
            // 
            // r1col1
            // 
            this.r1col1.Location = new System.Drawing.Point(12, 104);
            this.r1col1.Name = "r1col1";
            this.r1col1.Size = new System.Drawing.Size(58, 20);
            this.r1col1.TabIndex = 3;
            this.r1col1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // r1col2
            // 
            this.r1col2.Location = new System.Drawing.Point(76, 104);
            this.r1col2.Name = "r1col2";
            this.r1col2.Size = new System.Drawing.Size(58, 20);
            this.r1col2.TabIndex = 4;
            // 
            // r1col3
            // 
            this.r1col3.Location = new System.Drawing.Point(140, 104);
            this.r1col3.Name = "r1col3";
            this.r1col3.Size = new System.Drawing.Size(58, 20);
            this.r1col3.TabIndex = 5;
            // 
            // r2col1
            // 
            this.r2col1.Location = new System.Drawing.Point(12, 140);
            this.r2col1.Name = "r2col1";
            this.r2col1.Size = new System.Drawing.Size(58, 20);
            this.r2col1.TabIndex = 6;
            // 
            // r2col2
            // 
            this.r2col2.Location = new System.Drawing.Point(76, 140);
            this.r2col2.Name = "r2col2";
            this.r2col2.Size = new System.Drawing.Size(58, 20);
            this.r2col2.TabIndex = 7;
            // 
            // r2col3
            // 
            this.r2col3.Location = new System.Drawing.Point(144, 140);
            this.r2col3.Name = "r2col3";
            this.r2col3.Size = new System.Drawing.Size(58, 20);
            this.r2col3.TabIndex = 8;
            // 
            // r3col1
            // 
            this.r3col1.Location = new System.Drawing.Point(12, 179);
            this.r3col1.Name = "r3col1";
            this.r3col1.Size = new System.Drawing.Size(58, 20);
            this.r3col1.TabIndex = 9;
            // 
            // r3col2
            // 
            this.r3col2.Location = new System.Drawing.Point(76, 179);
            this.r3col2.Name = "r3col2";
            this.r3col2.Size = new System.Drawing.Size(58, 20);
            this.r3col2.TabIndex = 10;
            // 
            // r3col3
            // 
            this.r3col3.Location = new System.Drawing.Point(144, 179);
            this.r3col3.Name = "r3col3";
            this.r3col3.Size = new System.Drawing.Size(58, 20);
            this.r3col3.TabIndex = 11;
            // 
            // labeldetail
            // 
            this.labeldetail.AutoSize = true;
            this.labeldetail.Location = new System.Drawing.Point(50, 74);
            this.labeldetail.Name = "labeldetail";
            this.labeldetail.Size = new System.Drawing.Size(94, 13);
            this.labeldetail.TabIndex = 12;
            this.labeldetail.Text = "3 * 3 Kernel Inputs";
            this.labeldetail.Click += new System.EventHandler(this.label1_Click);
            // 
            // convolveKernel
            // 
            this.convolveKernel.Location = new System.Drawing.Point(24, 217);
            this.convolveKernel.Name = "convolveKernel";
            this.convolveKernel.Size = new System.Drawing.Size(151, 43);
            this.convolveKernel.TabIndex = 13;
            this.convolveKernel.Text = "Convolve";
            this.convolveKernel.UseVisualStyleBackColor = true;
            this.convolveKernel.Click += new System.EventHandler(this.convolveKernel_Click);
            // 
            // histogram
            // 
            this.histogram.Location = new System.Drawing.Point(218, 261);
            this.histogram.Name = "histogram";
            this.histogram.Size = new System.Drawing.Size(279, 225);
            this.histogram.TabIndex = 14;
            this.histogram.TabStop = false;
            // 
            // histogramProcess
            // 
            this.histogramProcess.Location = new System.Drawing.Point(24, 289);
            this.histogramProcess.Name = "histogramProcess";
            this.histogramProcess.Size = new System.Drawing.Size(151, 51);
            this.histogramProcess.TabIndex = 15;
            this.histogramProcess.Text = "Process Histogram";
            this.histogramProcess.UseVisualStyleBackColor = true;
            this.histogramProcess.Click += new System.EventHandler(this.histogramProcess_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(660, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 498);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.histogramProcess);
            this.Controls.Add(this.histogram);
            this.Controls.Add(this.convolveKernel);
            this.Controls.Add(this.labeldetail);
            this.Controls.Add(this.r3col3);
            this.Controls.Add(this.r3col2);
            this.Controls.Add(this.r3col1);
            this.Controls.Add(this.r2col3);
            this.Controls.Add(this.r2col2);
            this.Controls.Add(this.r2col1);
            this.Controls.Add(this.r1col3);
            this.Controls.Add(this.r1col2);
            this.Controls.Add(this.r1col1);
            this.Controls.Add(this.processImg);
            this.Controls.Add(this.orgPicture);
            this.Controls.Add(this.select_image);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.orgPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.histogram)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button select_image;
        private System.Windows.Forms.PictureBox orgPicture;
        private System.Windows.Forms.PictureBox processImg;
        private System.Windows.Forms.TextBox r1col1;
        private System.Windows.Forms.TextBox r1col2;
        private System.Windows.Forms.TextBox r1col3;
        private System.Windows.Forms.TextBox r2col1;
        private System.Windows.Forms.TextBox r2col2;
        private System.Windows.Forms.TextBox r2col3;
        private System.Windows.Forms.TextBox r3col1;
        private System.Windows.Forms.TextBox r3col2;
        private System.Windows.Forms.TextBox r3col3;
        private System.Windows.Forms.Label labeldetail;
        private System.Windows.Forms.Button convolveKernel;
        private System.Windows.Forms.PictureBox histogram;
        private System.Windows.Forms.Button histogramProcess;
        private System.Windows.Forms.Label label1;
    }
}

