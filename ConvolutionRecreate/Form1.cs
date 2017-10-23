using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvolutionRecreate
{
    public partial class Form1 : Form
    {
        Bitmap bmpOrig = null;
        Color bmpPixels = new Color();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // button to upload picture
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Image File | *.jpg";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string fname = ofd.FileName;
                    bmpOrig = new Bitmap(fname);
                    orgPicture.Image = bmpOrig;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void convolveKernel_Click(object sender, EventArgs e)
        {
            try
            {
                double[][] kernel = new double[3][];
                for (int i = 0; i < 3; i++)
                    kernel[i] = new double[3];
                /*kernel[0][0] = 1 / 9.0;
                kernel[0][1] = 1 / 9.0;
                kernel[0][2] = 1 / 9.0;
                kernel[1][0] = 1 / 9.0;
                kernel[1][1] = 1 / 9.0;
                kernel[1][2] = 1 / 9.0;
                kernel[2][0] = 1 / 9.0;
                kernel[2][1] = 1 / 9.0;
                kernel[2][2] = 1 / 9.0;*/

                //kernel[0][0] = 0;
                //kernel[0][1] = -1;
                //kernel[0][2] = 0;
                //kernel[1][0] = -1;
                //kernel[1][1] = 5;
                //kernel[1][2] = -1;
                //kernel[2][0] = 0;
                //kernel[2][1] = -1;
                //kernel[2][2] = 0;

                kernel[0][0] = float.Parse(r1col1.Text);
                kernel[0][1] = float.Parse(r1col2.Text);
                kernel[0][2] = float.Parse(r1col3.Text);
                kernel[1][0] = float.Parse(r2col1.Text);
                kernel[1][1] = float.Parse(r2col2.Text);
                kernel[1][2] = float.Parse(r2col3.Text);
                kernel[2][0] = float.Parse(r3col1.Text);
                kernel[2][1] = float.Parse(r3col2.Text);
                kernel[2][2] = float.Parse(r3col3.Text);



                //kernel[0][0] = -1;
                //kernel[0][1] = -1;
                //kernel[0][2] = -1;
                //kernel[1][0] = 0;
                //kernel[1][1] = 0;
                //kernel[1][2] = 0;
                //kernel[2][0] = 1;
                //kernel[2][1] = 1;
                //kernel[2][2] = 1;
                Bitmap bmpNew = (Bitmap)bmpOrig.Clone();
                MyImageProc.Convolve(bmpOrig, kernel);
                orgPicture.Image = bmpNew;
                processImg.Image = bmpOrig;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void histogramProcess_Click(object sender, EventArgs e)
        {
            long[] matImage = new long[256];
            long[] matSum = new long[256];
            long pixelValues = 0;
            long sumValue = 0;
            Bitmap bmpHisto = (Bitmap)bmpOrig.Clone();
            for(int i=0; i< bmpHisto.Height; i++)
            {
                for(int j=0; j<bmpHisto.Width; j++)
                {
                    pixelValues = (long)(255 * bmpHisto.GetPixel(j, i).GetBrightness());
                    matImage[pixelValues]++;

               }
            }

            label1.Text = matImage[3].ToString();

            for (int level = 0; level < 256; level++)
            {
                sumValue = sumValue + matImage[level];
                matSum[level] = sumValue;
            }

            for (int i = 0; i < bmpHisto.Height; i++)
                for (int j = 0; j < bmpHisto.Width; j++)
                {
                    System.Drawing.Color clr = bmpHisto.GetPixel(j,i);
                    pixelValues = (long)(255 * clr.GetSaturation());
                    pixelValues = (long)(255f / (bmpHisto.Width * bmpHisto.Height) * matSum[pixelValues] - pixelValues);
                    int R = (int)Math.Min(255, clr.R + pixelValues / 3); //.299
                    int G = (int)Math.Min(255, clr.G + pixelValues / 3); //.587
                    int B = (int)Math.Min(255, clr.B + pixelValues / 3); //.112
                    bmpHisto.SetPixel(j, i, System.Drawing.Color.FromArgb(Math.Max(R, 0), Math.Max(G, 0), Math.Max(B, 0)));
                }
            orgPicture.Image = bmpOrig;
            histogram.Image = bmpHisto;            
        }
    }
}
