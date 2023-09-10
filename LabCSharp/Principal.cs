using LabCSharp.Multimedia.Class;
using LabCSharp.Ofimatica.View;
using LabCSharp.Programacion.View;

using LabCSharp.Networking.View;
using LabCSharp.MSoft.View;
using LabCSharp.Multimedia.View;
using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace LabCSharp
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            cambiarFondo();
        }

        private void cambiarFondo()
        {

            int width = this.Width;
            int height = this.Height;
            int alfa = 0;
            int red = 0;
            int green = 0;
            int blue = 0;
            claseImagen miImg = new claseImagen(width, height, alfa, red, green, blue);

            Random rand = new Random();
            int num = rand.Next(1, 4);
            if (num == 1)
                miImg.miBitmap = miImg.randomPixel(miImg);
            if (num == 2)
                miImg.miBitmap = miImg.arcoIris(miImg);
            if (num == 3)
                miImg.miBitmap = miImg.linealPixel(miImg);

            this.BackgroundImage = miImg.miBitmap;

            gesNavegador miNav= new gesNavegador();
            miNav.MdiParent = this;
            miNav.Visible = true;
            
        }

        private void enumeradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
            diasdelaSemana midia = diasdelaSemana.Lunes;

            switch (midia)
            {
                case diasdelaSemana.Lunes:
                    Console.WriteLine("Hoy es Lunes");
                    break;
                case diasdelaSemana.Martes:
                    Console.WriteLine("Hoy es Martes");
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }

            Console.ReadLine();
            
                    public enum diasdelaSemana {Lunes, Martes, Miercoles, Jueves, Viernes, Sabado, Domingo};
        public enum statusConexion {Offline, Online};

    */
        }

        private void bATCHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void tareasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string command = "net start";
            string cadenaComando = "Programador de Tareas";
            string cadena2 = "task scheduler";
            //SINTAXIS
            // AT \\nombreequipo hora cmd
        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gesOfficeExcel miOfficeExcel = new gesOfficeExcel();
            miOfficeExcel.MdiParent = this;
            miOfficeExcel.Visible = true;
        }

        private void controlesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            gesCSharpControles miGCC = new gesCSharpControles();
            miGCC.MdiParent = this;
            miGCC.Visible = true;
        }

        private void componentesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            gesCSharpComponents miCSC = new gesCSharpComponents();
            miCSC.MdiParent = this;
            miCSC.Visible = true;
        }

        private void eventosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gesCSharpEventos miGCSE = new gesCSharpEventos();
            miGCSE.MdiParent = this;
            miGCSE.Visible = true;
        }

        private void imagenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gesImagenes miGI = new gesImagenes();
            miGI.MdiParent = this;
            miGI.Visible = true;
        }

        private void conectividadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gesConectividad miGC = new gesConectividad();
            miGC.MdiParent = this;
            miGC.Visible = true;
        }

        private void firewallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gesConectividad miConectividad = new gesConectividad();
            miConectividad.MdiParent = this;
            miConectividad.Visible = true;
        }

        private void navegadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gesNavegador miNav = new gesNavegador();
            miNav.MdiParent = this;
            miNav.Visible = true;
        }

        private void hTMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gesHTML miGesHTML = new gesHTML();
            miGesHTML.MdiParent = this;
            miGesHTML.Visible = true;
        }

        private void serviciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gesServicios miGesServicios = new gesServicios();
            miGesServicios.MdiParent = this;
            miGesServicios.Visible = true;
        }

        private void dataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Abrir archivo HTML
        }

        private void networkingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void outlookToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void estructurasRepetitivasToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void arrayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gesEstructuraDatos miGesED = new gesEstructuraDatos();
            miGesED.MdiParent = this;
            miGesED.Visible = true;
        }

        private void estructurasRepetitivasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gesEstructuraDatos miGesED = new gesEstructuraDatos();
            miGesED.MdiParent = this;
            miGesED.Visible = true;
        }

        private void FirmasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gesFirma miGesFirma = new gesFirma();
            miGesFirma.MdiParent = this;
            miGesFirma.Visible = true;
            miGesFirma.Dock = DockStyle.Fill;
            miGesFirma.WindowState = FormWindowState.Maximized;
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void copiarAplicacion()
        {
            string Archivo = "LabCSharp.exe";
            string dirArchivoOrigen = "..\\..\\bin\\Debug";
            string dirArchivoDestino = "C:\\Users\\ILS\\Desktop";

            // Use Path class to manipulate file and directory paths.
            string ArchivoOrigen = System.IO.Path.Combine(dirArchivoOrigen, Archivo);
            string ArchivoDestino = System.IO.Path.Combine(dirArchivoDestino, Archivo);

            // To copy a folder's contents to a new location:
            // Create a new target folder, if necessary.
            if (!System.IO.Directory.Exists(dirArchivoDestino))
            {
                System.IO.Directory.CreateDirectory(dirArchivoDestino);
            }

            // To copy a file to another location and 
            // overwrite the destination file if it already exists.
            System.IO.File.Copy(ArchivoOrigen, ArchivoDestino, true);
        }
        private void AplicacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            copiarAplicacion();
        }

        private void ArchivosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            gesArchivo miGA = new gesArchivo();
            miGA.MdiParent = this;
            miGA.Visible = true;
        }

        private void RegedtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //agregar registros
            Microsoft.Win32.Registry.SetValue(
            @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run",
            "MyApp",
            Application.ExecutablePath);


            //borrar registros de Regedit
            string keyName = @"Software\Microsoft\Windows\CurrentVersion\Run";
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(keyName, true))
            {
                if (key == null)
                {
                    // Key doesn't exist. Do whatever you want to handle
                    // this case
                }
                else
                {
                    key.DeleteValue("MyApp");
                }
            }

            //otra posibilidad
            RegistryKey registrykeyHKLM = Registry.LocalMachine;
            string keyPath = @"Software\Microsoft\Windows\CurrentVersion\Run\MyApp";

            registrykeyHKLM.DeleteValue(keyPath);
            registrykeyHKLM.Close();
        }

        private void SharePointToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gesSharepoint miGesSharepoint = new gesSharepoint();
            miGesSharepoint.MdiParent = this;
            miGesSharepoint.Visible = true;
        }

        private void EmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gesEmail miGesEmail = new gesEmail();
            miGesEmail.MdiParent = this;
            miGesEmail.Visible = true;
        }
    }
}
