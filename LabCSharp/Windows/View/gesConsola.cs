using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabCSharp.Windows.View
{
    public partial class gesConsola : Form
    {
        public gesConsola()
        {
            InitializeComponent();
        }

        private void gesConsola_Load(object sender, EventArgs e)
        {
            Console.Title = "AUXILIAR";

        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            /* FILES */
            /* COMBINAR ARCHIVOS */
            /* TRAER LA LISTA DE ARCHIVOS */
            List<string> miLista = new List<string>();
            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(@"C:\Users\tomfitz\Documents\ExampleDir");
            Console.WriteLine("No search pattern returns:");
            foreach (var fi in di.GetFiles())
            {
                Console.WriteLine(fi.Name);
                miLista.Add(fi.Name);
            }


            string line;

            // Read the file and display it line by line.  
            System.IO.StreamReader file = new System.IO.StreamReader(@"c:\test.txt");
            while ((line = file.ReadLine()) != null)
            {
                System.Console.WriteLine(line);
            }

            file.Close();

            /* VELOCIDAD DE INTERNET
            // the URL to download a file from
            Uri URL = new Uri("http://sixhoej.net/speedtest/1024kb.txt");
            WebClient wc = new WebClient();

            Console.WriteLine("Presione cualquier tecla para comenzar");
            Console.ReadKey();

            Console.WriteLine("\nDownloading : 1024kb.txt...");
            Console.WriteLine("From http://sixhoej.net/speedtest/");
            Console.WriteLine("Nota: Este archivo se eliminará automáticamente después de la prueba.");

            // get current tickcount 
            double starttime = Environment.TickCount;

            // download file from the specified URL, and save it to C:\speedtest.txt
            wc.DownloadFile(URL, @"C:\speedtest.txt");

            // get current tickcount
            double endtime = Environment.TickCount;

            // how many seconds did it take?
            // we are calculating this by subtracting starttime from endtime
            // and dividing by 1000 (since the tickcount is in miliseconds.. 1000 ms = 1 sec)
            double secs = Math.Floor(endtime - starttime) / 1000;

            // round the number of secs and remove the decimal point
            double secs2 = Math.Round(secs, 0);

            // calculate download rate in kb per sec.
            // this is done by dividing 1024 by the number of seconds it
            // took to download the file (1024 bytes = 1 kilobyte)
            double kbsec = Math.Round(1024 / secs);

            Console.WriteLine("\nListo Estadísticas:\n");

            Console.WriteLine("1mb download: \t{0} secs ({1} secs)", secs2, secs);
            Console.WriteLine("Download rate: \t{0} kb/sec", kbsec);

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.Read();
            Console.WriteLine("Eliminar un archivo descargado");
            try
            {
                // delete downloaded file
                System.IO.File.Delete(@"C:\speedtest.txt");
                Console.WriteLine("Listo");
            }
            catch
            {
                Console.WriteLine("No se puede eliminar el archivo.");
                Console.ReadKey();
            }
            */
        }
    }
}
