using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CG
{
    public partial class Form1 : Form
    {
        private Image image;
        private Bitmap imgSrc;
        private Bitmap imgHsi;
        private Bitmap imgDst;
       

        public Form1()
        {
            InitializeComponent();
            
        }

        private void BtAbrir_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Arquivos de Imagem (*.jpg;*.gif;*.bmp;*.png)|*.jpg;*.gif;*.bmp;*.png";
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                image = Image.FromFile(openFileDialog1.FileName); // preenche a imagem com a que foi aberta através do openFileDialog
                pictureBox1.Image = image;
                pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize; // Relação entre img e o picturebox


                imgSrc = (Bitmap)image;
                imgHsi = new Bitmap(image);
                imgDst = new Bitmap(image);
                Filtros.convertRGB_to_HSI(imgSrc, imgHsi);
                Filtros.convertHSI_toRGB(imgHsi, imgDst);
                pictureBox2.Image = imgDst;
                //pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            }
        }

        private void BtLimpar_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = pictureBox1.Image = null;
            imgSrc = imgHsi = null;
            lbR.Text = "R = ";
            lbG.Text = "G = ";
            lbB.Text = "B = ";
            lbC.Text = "C = ";
            lbM.Text = "M = ";
            lbYY.Text = "Y = ";
            lbH.Text = "H = ";
            lbS.Text = "S = ";
            lbI.Text = "I = ";
        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            //base.OnMouseMove(e);
            //Graphics g = CreateGraphics();
            //Pen p = new Pen(Color.Navy);
            //Pen erase = new Pen(Color.White);
            //g.DrawLine(erase, 0, 0, x, y);
            //x = e.X; y = e.Y;
            //g.DrawLine(p, 0, 0, x, y);
            

            if (imgSrc != null)
            {
                lbX.Location = new Point(e.X + lbX.Width, e.Y);
                lbY.Location = new Point(e.X + lbX.Width, e.Y + lbY.Height);
                lbX.Text = "Col = " + e.X.ToString();
                lbY.Text = "Lin = " + e.Y.ToString();


                //CORES RGB
                Color coresRGB = imgSrc.GetPixel(e.X, e.Y);
                /*lbR.Location = new Point(e.X + lbR.Width, e.Y);
                lbG.Location = new Point(e.X + lbG.Width, e.Y + lbG.Height);
                lbB.Location = new Point(e.X + lbB.Width, e.Y + lbB.Height*2);*/
                lbR.Text = "R = " + coresRGB.R.ToString();
                lbG.Text = "G = " + coresRGB.G.ToString();
                lbB.Text = "B = " + coresRGB.B.ToString();

                //CORES CMY
                /*lbC.Location = new Point(e.X + lbC.Width*2, e.Y);
                lbM.Location = new Point(e.X + lbM.Width*2, e.Y + lbM.Height);
                lbYY.Location = new Point(e.X + lbYY.Width*2, e.Y + lbYY.Height * 2);*/
                lbC.Text = "C = " + (255 - coresRGB.R).ToString();
                lbM.Text = "M = " + (255 - coresRGB.G).ToString();
                lbYY.Text = "Y = " + (255 - coresRGB.B).ToString();

            }
            if(imgHsi != null)
            {
                //CORES HSI
                Color coresHSI = imgHsi.GetPixel(e.X, e.Y);
                lbH.Text = "H = " + coresHSI.R.ToString();
                lbS.Text = "S = " + coresHSI.G.ToString();
                lbI.Text = "I = " + coresHSI.B.ToString();
            }
        }

        private void TrackBarIntensity_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void TrackBarHUE_MouseUp(object sender, MouseEventArgs e)
        {
            if (imgSrc != null)
            {
                int width = imgHsi.Width;
                int height = imgHsi.Height;
                double h, s, i;

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        Color cor = imgHsi.GetPixel(x, y);
                        h = (cor.R + trackBarHUE.Value) % 360;
                        s = cor.G;
                        i = cor.B;
                        Color NovaCor = Color.FromArgb((byte)h, (byte)s, (byte)i);

                        imgDst.SetPixel(x, y, NovaCor);
                    }
                }
                Filtros.convertHSI_toRGB(imgDst, imgDst);
                pictureBox2.Image = imgDst;
            }
        }

        private void TrackBarIntensity_MouseUp(object sender, MouseEventArgs e)
        {
            if (imgSrc != null)
            {
                int width = imgHsi.Width;
                int height = imgHsi.Height;
                double h, s, i;

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        Color cor = imgHsi.GetPixel(x, y);
                        h = cor.R;
                        s = cor.G;
                        i = cor.B;
                        i += i * trackBarIntensity.Value / 100;
                        Color NovaCor = Color.FromArgb((byte)h, (byte)s, (byte)i);

                        imgDst.SetPixel(x, y, NovaCor);
                    }
                }
                Filtros.convertHSI_toRGB(imgDst, imgDst);
                pictureBox2.Image = imgDst;
            }
        }
    }
}
