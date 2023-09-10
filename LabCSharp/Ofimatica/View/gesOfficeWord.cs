using System;
using System.IO;
using System.Windows.Forms;

namespace LabCSharp.Ofimatica.View
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
