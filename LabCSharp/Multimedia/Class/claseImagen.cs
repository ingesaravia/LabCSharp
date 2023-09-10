using System;
using System.Drawing;
using System.IO;

namespace LabCSharp.Multimedia.Class
{
    class claseImagen
    {
        public Image miImagen;
        public Bitmap miBitmap;
        public Color miColor;

        private int width, height;
        private int alfa, red, green, blue;

        public claseImagen()
        {
           
        }

        public claseImagen(int width, int height)
        {
            this.width = width;
            this.height = height;
            this.miBitmap = new Bitmap(this.width, this.height);
        }

        public claseImagen(int width, int height, int alfa, int red, int green, int blue)
        {
            this.width = width;
            this.height = height;
            this.miBitmap = new Bitmap(this.width, this.height);
            this.alfa = alfa;
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.miColor = Color.FromArgb(alfa, red, green, blue);
        }

        public Bitmap patrones(claseImagen miImg)
        {
            //miColor = Color.FromArgb(alfa, red, green, blue);
            //miImg.miBitmap.SetPixel(w, h, miColor);

            return (miImg.miBitmap);
        }

        public Bitmap linealPixel(claseImagen miImg)
        {
            Random miRand = new Random();
            alfa = 200;
            red = miRand.Next(0,150);
            green = miRand.Next(0,150);
            blue = miRand.Next(0,150);
            int orden = miRand.Next(1, 4);

            for (int w=0; w < width; w++)
            {
                for (int h=0; h < height; h++)
                {
                    miColor = Color.FromArgb(alfa, red, green, blue);
                    miImg.miBitmap.SetPixel(w, h, miColor);
                }

                if (orden == 1)
                {
                    if (red < 255)
                        red++;
                    else
                        if (green < 255)
                        green++;
                    else
                            if (blue < 255)
                        blue++;
                }
                else
                    if (orden == 2)
                    {
                    if (blue < 255)
                        blue++;
                    else
                        if (green < 255)
                        green++;
                    else
                        if (red < 255)
                        red++;
                }
                    else
                    {
                        if (red < 255)
                            red++;
                        else
                            if (blue < 255)
                                blue++;
                            else
                                if (green < 255)
                                    green++;
                    }

            }
            return (miImg.miBitmap);
        }
        public Bitmap randomPixel(claseImagen miImg)
        {
            Random miRand = new Random();
            for (int w = 0; w < width; w++)
                for (int h = 0; h < height; h++)
                {
                    alfa = miRand.Next(0, 255);
                    red = miRand.Next(0, 255);
                    green = miRand.Next(0, 255);
                    blue = miRand.Next(0, 255);
                    miColor = Color.FromArgb(alfa, red, green, blue);
                    miImg.miBitmap.SetPixel(w, h, miColor);
                }

            return (miImg.miBitmap);
        }

        public Bitmap arcoIris(claseImagen miImg)
        {
            Random miRand = new Random();
            alfa = 200;
            red = 255;
            green = 0;
            blue = 0;

            for (int w = 0; w < width; w++)
            {
                for (int h = 0; h < height; h++)
                {
                    miColor = Color.FromArgb(alfa, red, green, blue);
                    miImg.miBitmap.SetPixel(w, h, miColor);
                }

                if (green < 255) green++;
                else
                    if (red > 0) red--;
                else
                    if (blue < 255) blue++;
                else
                    if (green > 0) green--;
                else
                    if (red < 255) red++;
                else
                    if (blue > 0) blue--;

            }
            return (miImg.miBitmap);
        }

        public void ImgDesdeArchivo(string dirArchivo)
        {
            string fullpath = dirArchivo;
            miImagen = Bitmap.FromFile(fullpath);
        }
        public Image convertirBase64ToImage(string base64string)
        {
            // Convert base 64 string to byte[]
            byte[] imageBytes = Convert.FromBase64String(base64string);
            // Convert byte[] to Image
            using (var ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
            {
                Image image = Image.FromStream(ms, true);
                return image;
            }
        }
        
        
    }
}
