using LabCSharp.MSoft.Class;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LabCSharp.Ofimatica.View
{

    public partial class gesHTML : Form
    {
        public List<string> listArchivo;
        public gesHTML()
        {
            InitializeComponent();
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog mOpenFile = new OpenFileDialog();
            mOpenFile.Multiselect = true;
            mOpenFile.Title = "Seleccione uno o varios archivos";

            listArchivo = new List<string>();

            if (mOpenFile.ShowDialog() == DialogResult.OK)
            {
                txtDireccionArchivo.Text = mOpenFile.FileName;
                foreach (String archivo in mOpenFile.FileNames)
                {
                    rtxtArchivos.AppendText(archivo);
                    rtxtArchivos.AppendText("\n");
                    listArchivo.Add(archivo.Replace("\\",@"\"));
                }
                
            }
        }

        private void btnUnir_Click(object sender, EventArgs e)
        {
            if (listArchivo.Count != 0)
            {
                claseArchivo miClaseArchivo = new claseArchivo();
                try
                {
                    miClaseArchivo.unirArchivosHTML(listArchivo);
                    MessageBox.Show("Los archivos se han unido");
                }
                catch(Exception)
                {
                    MessageBox.Show("No se ha ejecutado la unión de archivos.");
                }
            }
            else
                MessageBox.Show("No existen archivos disponibles");
        }
    }
}
