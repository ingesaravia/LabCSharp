using System;
using System.Windows.Forms;
using LabCSharp.Ofimatica.Class;

namespace LabCSharp.Ofimatica.View
{
    public partial class gesOfficeExcel : Form
    {
        public gesOfficeExcel()
        {
            InitializeComponent();
            limpiarSC();
        }

        private string buscarDirArchivo()
        {
            string dirArchivo=null;
            OpenFileDialog miOpenF = new OpenFileDialog();
            miOpenF.Filter = "Excel files (*.xlsx)|*.xls" + "|All files (*.*)|*.*";
            miOpenF.Multiselect = false;
            miOpenF.Title = "Seleccione la carpeta donde se encuentra el archivo";

            if(miOpenF.ShowDialog() == DialogResult.OK)
            {
                dirArchivo = miOpenF.FileName;
            }
            return (dirArchivo);
        }

        private void btnRecorrerExcel_Click(object sender, EventArgs e)
        {
            if (txtExamRecorrerExcel.Text != null)
            {
                claseExcel miExcel = new claseExcel();
                miExcel.generarListado(txtExamRecorrerExcel.Text);
            }
        }

        private void btnCombHojaExam_Click(object sender, EventArgs e)
        {
            txtCombHojadirArchivo.Text = buscarDirArchivo();
            claseExcel miExcel = new claseExcel();
            miExcel.dirArchivo = txtCombHojadirArchivo.Text;
        }

        private void btnCombHojasEjecutar_Click(object sender, EventArgs e)
        {
            claseExcel miExcel = new claseExcel();
            miExcel.combinarHojas(txtCombHojadirArchivo.ToString());
        }

        private void BtnLimpiarSC_Click(object sender, EventArgs e)
        {
            limpiarSC();
        }

        private void BtnGenerarSC_Click(object sender, EventArgs e)
        {
            //1 tracker tiene 28 paneles
            //1 tracker tiene 2 mesas
            //1 mesa tiene 14 paneles
            //1 string tiene 1 tracker
            //1 subcampo tiene 34800 tracker en total 974400 paneles
            for (int i=1;i<4 ;i++)
            {
                for (int j = 1; j < 15; j++)
                {
                    System.Console.WriteLine("TR1.2.4." + i + "." + j);
                }
            }

            for (int i = 15; i <21; i++)
            {
                for (int j = 1; j < 15; j++)
                {
                    System.Console.WriteLine("TR1.2.3." + i + "." + j);
                }
            }

            for (int i = 20; i > 14; i--)
            {
                for (int j = 15; j < 29; j++)
                {
                    System.Console.WriteLine("TR1.2.3." + i + "." + j);
                }
            }

            for (int i = 3; i > 0; i--)
            {
                for (int j = 15; j < 29; j++)
                {
                    System.Console.WriteLine("TR1.2.4." + i + "." + j);
                }
            }

            //abrir nuevo archivo Excel
            /*for (int i=0; i < dataGridSC.RowCount; i++)
            {
                for (int j=0; j < dataGridSC.ColumnCount; j++)
                {
                    if (dataGridSC.Rows[i].Cells[j].Value != null)
                    {

                    }
                }
            }*/
        }

        private void limpiarSC()
        {
            dataGridSC.RowCount = 20;
            dataGridSC.ColumnCount = 20;
            dataGridSC.AllowUserToResizeColumns = false;
            dataGridSC.AllowUserToOrderColumns = false;
            dataGridSC.AllowUserToAddRows = false;
            dataGridSC.AllowUserToResizeRows = false;
            dataGridSC.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            for (int i = 0; i < dataGridSC.ColumnCount; i++)
            {
                dataGridSC.Columns[i].Width = 30;
            }
        }

        private void BtnExamRecorrerExcel_Click(object sender, EventArgs e)
        {
            txtExamRecorrerExcel.Text = buscarDirArchivo();
            claseExcel miExcel = new claseExcel();
            miExcel.dirArchivo = txtExamRecorrerExcel.Text;
        }
    }
}
