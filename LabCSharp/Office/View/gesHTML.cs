using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabCSharp.Office.View
{
    public partial class gesHTML : Form
    {
        public gesHTML()
        {
            InitializeComponent();
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog mOpenFile = new OpenFileDialog();
            mOpenFile.Multiselect = true;
            mOpenFile.Title = "Seleccione uno o varios archivos";


            if (mOpenFile.ShowDialog() == DialogResult.OK)
            {
                foreach (String archivo in mOpenFile.FileNames)
                {
                    rtxtArchivos.AppendText(archivo);
                }
                txtDireccionArchivo.Text = mOpenFile.InitialDirectory;
            }
        }
    }
}
