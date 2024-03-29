﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using LabCSharp.Multimedia.Class;

namespace LabCSharp.Multimedia.View
{
    public partial class gesImagenes : Form
    {
        private String carpetaImagenes;
        private List<string> listaImagenes;
        private int posicionLista;
        private Image miImagen;
        private claseImagen miImg;


        public gesImagenes()
        {
            InitializeComponent();
            int width = this.pictureBox2.Width;
            int height = this.pictureBox2.Height;
            int alfa = 0;
            int red = 0;
            int green = 0;
            int blue = 0;
            miImg = new claseImagen(width, height, alfa, red, green, blue);

            Random miRand = new Random();

            pictureBox1.Image = miImg.miBitmap;
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog miOpenF = new OpenFileDialog();
            miOpenF.Filter = "jpg files (*.jpg)|*.jpg"+
                             "|png files (*.gif)|*.png"+
                             "|gif files (*.gif)|*.gif"+
                             "|jpeg files (*.gif)|*.jpeg" +
                             "|bmp files (*.gif)|*.bmp" +
                             "|All files (*.*)|*.*";
            miOpenF.Multiselect = false;
            miOpenF.Title = "Seleccione la carpeta donde se encuentran los archivos";

            if (miOpenF.ShowDialog() == DialogResult.OK)
            {
                DirectoryInfo dirInfo = Directory.GetParent(miOpenF.FileName);
                carpetaImagenes = dirInfo.FullName;
                textBox1.Text = carpetaImagenes;
                Console.WriteLine(carpetaImagenes);

                listaImagenes = new List<string>();
                string[] lista = Directory.GetFiles(carpetaImagenes);
                foreach(string img in lista)
                {
                    if (img.EndsWith("jpg") ||
                        img.EndsWith("jpeg") ||
                        img.EndsWith("gif") ||
                        img.EndsWith("bmp") ||
                        img.EndsWith("png"))
                        listaImagenes.Add(img);
                }

                posicionLista = 0;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                cargarImagen();
                cargarDatos();
           }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (listaImagenes != null)
            {
                if (posicionLista > 0) {
                    posicionLista = posicionLista - 1;
                    cargarImagen();
                    cargarDatos();
                }
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (listaImagenes != null)
            {
                if (posicionLista < listaImagenes.Count)
                {
                    posicionLista = posicionLista + 1;
                    cargarImagen();
                    cargarDatos();
                }
            }
        }

        private void cargarImagen()
        {
            miImagen = Image.FromFile(listaImagenes[posicionLista]);
            pictureBox1.Image = miImagen;
        }

        private void cargarDatos()
        {
            richTextBox1.Clear();

            // Get a PropertyItem from image1.
            //System.Drawing.Imaging.PropertyItem propItem = miImagen.GetPropertyItem(20624);

            foreach (var propiedad in miImagen.PropertyItems)
            {
                richTextBox1.AppendText("Propiedad:" + miImagen.GetPropertyItem(propiedad.Id) + "\n");
            }
        }

        private void btnPixelar8Bit_Click(object sender, EventArgs e)
        {
            Color miColor = new Color();

            //if (pictureBox1.Image != null)
                
                
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnRandom_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = miImg.randomPixel(miImg);
        }

        private void BtnArcoIris_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = miImg.arcoIris(miImg);
        }

        private void BtnLinealPixel_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = miImg.linealPixel(miImg);
        }
    }
}
