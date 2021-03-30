using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Covit_19_Ziya_Doygun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog zd = new OpenFileDialog();
            zd.Filter = "Fotoğraf |*.png;*.jpeg;*.jpg;";
            if (zd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = zd.FileName;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OpenFileDialog zd = new OpenFileDialog();
            zd.Filter = "Fotoğraf |*.png;*.jpeg;*.jpg;";
            if (zd.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.ImageLocation = zd.FileName;
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double iortR = 0, iortG = 0, iortB = 0;
            double sortR = 0, sortG = 0, sortB = 0;

            Bitmap ilkfotograf = (Bitmap)pictureBox1.Image;
            Bitmap sonfotograf = (Bitmap)pictureBox2.Image;

            for (int i = 0; i < ilkfotograf.Width; i++)
            {
                for (int x = 0; x < ilkfotograf.Height; x++)
                {
                    iortR += ilkfotograf.GetPixel(i, x).R;
                    iortG += ilkfotograf.GetPixel(i, x).G;
                    iortB += ilkfotograf.GetPixel(i, x).B;
                }
            }

            for (int i = 0; i < sonfotograf.Width; i++)
            {
                for (int x = 0; x < sonfotograf.Height; x++)
                {
                    sortR += sonfotograf.GetPixel(i, x).R;
                    sortG += sonfotograf.GetPixel(i, x).G;
                    sortB += sonfotograf.GetPixel(i, x).B;
                }
            }

            iortR /= (ilkfotograf.Width * ilkfotograf.Height);
            iortG /= (ilkfotograf.Width * ilkfotograf.Height);
            iortB /= (ilkfotograf.Width * ilkfotograf.Height);

            sortR /= (sonfotograf.Width * sonfotograf.Height);
            sortG /= (sonfotograf.Width * sonfotograf.Height);
            sortB /= (sonfotograf.Width * sonfotograf.Height);

            double ortR = iortR - sortR;
            double ortG = iortG - sortG;
            double ortB = iortB - sortB;

            double R = (ortR / iortR) * 100;
            double G = (ortG / iortG) * 100;
            double B = (ortB / iortB) * 100;

            textBox1.Text = R.ToString();
            textBox2.Text = G.ToString();
            textBox3.Text = B.ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
