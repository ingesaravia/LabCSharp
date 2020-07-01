using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabCSharp.Windows.Class
{
    class claseArchivo
    {
        private StreamWriter escritor;
        private StreamReader lector;

        public claseArchivo()
        {
        }
        
        public void escribirArchivo(List<string> texto, string dirArchivo)
        {
            

            foreach (string lineatexto in texto)
            {
                escritor.WriteLine(lineatexto);
            }
        }
        
        public void unirArchivosHTML(List<string> listaArchivo)
        {

            escritor = new StreamWriter("C:\\Unidos.html");

            foreach (string dirArchivo in listaArchivo)
            {

                lector = new StreamReader(dirArchivo);
                string lineatexto = lector.ReadLine();
                while (lineatexto != null)
                {
                    escritor.WriteLine(lineatexto);
                    lineatexto = lector.ReadLine();
                }
                lector.Close();
            }

            escritor.Close();
        }  
    }
}
