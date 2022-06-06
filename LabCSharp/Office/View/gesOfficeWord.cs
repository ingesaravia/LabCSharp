using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabCSharp.Office.View
{
    public partial class gesOfficeWord : Form
    {
        public gesOfficeWord()
        {
            InitializeComponent();
        }

        private void gesOfficeWord_Load(object sender, EventArgs e)
        {
            String directorio;
            directorio = "C:\\";
            DirectoryInfo listaDirectorios = new DirectoryInfo(directorio);

            treeViewOfficeWord.Nodes.Clear();
            
            //TreeNode treenodes = 

        }

        private void btnOfficeWordCombinar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
