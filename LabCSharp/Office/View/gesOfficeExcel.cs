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
            miExcel.generarListado("D:\\listado.xlsx");



        }
    }
}
