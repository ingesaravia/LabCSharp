using LabCSharp.Windows.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabCSharp.Windows.View
{
    public partial class gesServicios : Form
    {
        public claseServicio miServicio;
        public gesServicios()
        {
            InitializeComponent();
            miServicio = new claseServicio();
        }

        private void btnDetenerServ_Click(object sender, EventArgs e)
        {
            miServicio.detenerServicio();
        }

        private void btnListarServicios_Click(object sender, EventArgs e)
        {
            miServicio.listarServicio();
        }

    }
}
