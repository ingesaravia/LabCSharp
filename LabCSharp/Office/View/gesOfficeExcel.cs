using System;
using System.Windows.Forms;
using LabCSharp.Office;

namespace LabCSharp.Office.View
{
    public partial class gesOfficeExcel : Form
    {
        public gesOfficeExcel()
        {
            InitializeComponent();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            claseExcel miExcel = new claseExcel();
            miExcel.generarListado();
        }


        private void btnCombHojaExam_Click(object sender, EventArgs e)
        {
            OpenFileDialog miOpenF = new OpenFileDialog();
            miOpenF.Filter = "Excel files (*.xlsx)|*.xls" + "|All files (*.*)|*.*";
            miOpenF.Multiselect = false;
            miOpenF.Title = "Seleccione la carpeta donde se encuentra el archivo";

            if (miOpenF.ShowDialog() == DialogResult.OK)
            {
                txtCombHojadirArchivo.Text = miOpenF.FileName;
                claseExcel miExcel = new claseExcel();
                miExcel.dirArchivo = txtCombHojadirArchivo.Text;
            }
        }

        private void btnCombHojasEjecutar_Click(object sender, EventArgs e)
        {
            claseExcel miExcel = new claseExcel();
            miExcel.combinarHojas();
        }
    }
}
