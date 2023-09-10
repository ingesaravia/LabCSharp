using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace LabCSharp.MSoft.View
{
    public partial class gesSharepoint : Form
    {
        private string dirArchivo;
        private string Useraccount;
        private string UserPassword;
        private string sharepointSite;
        public gesSharepoint()
        {
            InitializeComponent();
        }

        private void BtnSharepointAceptar_Click(object sender, EventArgs e)
        {
            sharepointSite = txtSPSite.Text;

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = @"powershell.exe";
            string loginUser = "Connect-SPOService -Url " + sharepointSite + " -Credential " + Useraccount;
            startInfo.Arguments = loginUser;
            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = false;
            Process process = new Process();
            process.StartInfo = startInfo;
            process.Start();

        }

        private void BtnSPUserListEjecutar_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnSPScriptEjecutar_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = @"powershell.exe";
            startInfo.Arguments = @"& '" + dirArchivo + "'";
            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = false;
            Process process = new Process();
            process.StartInfo = startInfo;
            process.Start();
        }

        private void BtnSPScriptExaminar_Click(object sender, EventArgs e)
        {
            dirArchivo = null;
            OpenFileDialog miOpenF = new OpenFileDialog();
            miOpenF.Filter = "Script files (*.ps1)|*.txt" + "|All files (*.*)|*.*";
            miOpenF.Multiselect = false;
            miOpenF.Title = "Seleccione la carpeta donde se encuentra el archivo";

            if (miOpenF.ShowDialog() == DialogResult.OK)
            {
                dirArchivo = miOpenF.FileName;
            }
        }

        private void BtnPowershellExecutionPolicy_Click(object sender, EventArgs e)
        {

            if (btnPowershellExecutionPolicy.Text == "HABILITAR")
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = @"powershell.exe";
                startInfo.Arguments = @"Set-ExecutionPolicy -ExecutionPolicy -UnRestricted";
                startInfo.RedirectStandardOutput = true;
                startInfo.RedirectStandardError = true;
                startInfo.UseShellExecute = false;
                startInfo.CreateNoWindow = false;
                Process process = new Process();
                process.StartInfo = startInfo;
                process.Start();

                btnPowershellExecutionPolicy.Text = "DESHABILITAR";
            }
            else
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = @"powershell.exe";
                startInfo.Arguments = @"Set-ExecutionPolicy -ExecutionPolicy -Restricted";
                startInfo.RedirectStandardOutput = true;
                startInfo.RedirectStandardError = true;
                startInfo.UseShellExecute = false;
                startInfo.CreateNoWindow = false;
                Process process = new Process();
                process.StartInfo = startInfo;
                process.Start();

                btnPowershellExecutionPolicy.Text = "HABILITAR";
            }
        }
    }
}
