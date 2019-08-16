using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG
{
    class Filtros
    {
        public static void convertRGB_to_HSI(Bitmap imgBitmapSrc, Bitmap imgBitmapDst)
        {
            int width = imgBitmapSrc.Width;
            int heigth = imgBitmapSrc.Height;
            int pixelSize = 3; //qt de canais por pixel
            double r, g, b;// apenas byte ou int, float ñ da
            double h, s, i;

            for (int y = 0; y < heigth; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color cor = imgBitmapSrc.GetPixel(x, y);

                    //Normalização dos valores RGB

                    Color NovaCor;
                    if ((cor.R + cor.G + cor.B) > 0)
                    {
                        r = ((double)cor.R / (cor.R + cor.G + cor.B));
                        g = ((double)cor.G / (cor.R + cor.G + cor.B));
                        b = ((double)cor.B / (cor.R + cor.G + cor.B));
                        //NovaCor = Color.FromArgb(r, g, b);
                    }
                    else
                    {
                        r = b = g = 0;
                        //NovaCor = Color.FromArgb(0, 0, 0);
                    }

                    h = Math.Acos((0.5 * ((r - g) + (r - b))) / Math.Sqrt(Math.Pow(r - g, 2) + (r - b) * (g - b)));
                    if (b > g)
                    {
                        h = (2 * Math.PI - h);
                    }
                    s = (1-3 * Math.Min(Math.Min(r, g),b));
                    i = ((double)(cor.R + cor.G + cor.B) / (double)(3 * 255));

                    h = (h * 180 / Math.PI);
                    s = (s * 100);
                    //i = (i * 255);
                    i = ((cor.R + cor.G + cor.B)/3);

                    NovaCor = Color.FromArgb((Byte)h, (Byte)s, (Byte)i);
                    imgBitmapDst.SetPixel(x, y, NovaCor);
                }
            }
        }

        public static void convertHSI_toRGB(Bitmap imgBitmapHSI, Bitmap imgBitmapRGB)
        {
            int width = imgBitmapHSI.Width;
            int height = imgBitmapHSI.Height;
            int pixelSize = 3; //qt de canais por pixel
            double r, g, b;// apenas byte ou int, float ñ da
            double h, s, i;
            double X,Y,Z;

            for (int y = 0;  y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color cor = imgBitmapHSI.GetPixel(x,y);
                    h = ((double)((cor.R * Math.PI) / 180));
                    s = (((double)cor.G / 100));
                    i = (((double)cor.B / 255)); 
                    
                    if(h < 2*Math.PI/3)
                    {
                        X = ((double)(i * (1 - s)));
                        Y = ((double)i * (1 + ((s * Math.Cos(h)) / (Math.Cos(Math.PI / 3 - h)))));
                        Z = ((double)3 * i - (x + y));

                        b = X;
                        r = Y;
                        g = Z;
                    }
                    else if(h>=2*Math.PI/3 && h<4*Math.PI/3)
                    {
                        h = ((double)h - 2 * Math.PI / 3);
                        X = ((double)i * (1 - s));
                        Y = ((double)i * (1 + ((s * Math.Cos(h)) / (Math.Cos(Math.PI / 3 - h)))));
                        Z = 3 * i - (X + Y);

                        r = X;
                        g = Y;
                        b = Z;
                    }
                    else
                    {
                        h = h - 4 * Math.PI/3;
                        X = ((double)i * (1 - s));
                        Y = ((double)i * (1 + ((s * Math.Cos(h)) / (Math.Cos(Math.PI / 3 - h)))));
                        Z = ((double)3 * i - (x + y));

                        g = X;
                        b = Y;
                        r = Z;
                    }
                    r = ((double)r * 255);
                    g = ((double)g * 255);
                    b = ((double)b * 255);
                    Color NovaCor = Color.FromArgb((byte)r,(byte)g,(byte)b);
                    imgBitmapRGB.SetPixel(x, y, NovaCor);
                }
            }
        }
    }
}
