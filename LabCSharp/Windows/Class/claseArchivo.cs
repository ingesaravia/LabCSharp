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
        
        public void GetFileSize (string dirArchivo)
        {
            FileInfo archivoInfo = new FileInfo(dirArchivo);
            // Make sure to replace the file name with your file name. Also, you can comment //Create a new file code if you already have a file. You may also want to convert the size from bytes to KB, MB, and GB by dividing bytes by 1024, 1024x1024 and so on. 
            
            // Create a new file   
            using (FileStream fs = archivoInfo.Create())
            {
                Byte[] txt = new UTF8Encoding(true).GetBytes("Nuevo archivo ");
                fs.Write(txt, 0, txt.Length);
                Byte[] author = new UTF8Encoding(true).GetBytes("ILS");
                fs.Write(author, 0, author.Length);
            }

            // Get File Name  
            string justFileName = archivoInfo.Name;
            Console.WriteLine("File Name: {0}", justFileName);
            // Get file name with full path   
            string fullFileName = archivoInfo.FullName;
            Console.WriteLine("File Name: {0}", fullFileName);
            // Get file extension   
            string extn = archivoInfo.Extension;
            Console.WriteLine("File Extension: {0}", extn);
            // Get directory name   
            string directoryName = archivoInfo.DirectoryName;
            Console.WriteLine("Directory Name: {0}", directoryName);
            // File Exists ?  
            bool exists = archivoInfo.Exists;
            Console.WriteLine("File Exists: {0}", exists);
            if (archivoInfo.Exists)
            {
                // Get file size  
                long size = archivoInfo.Length;
                Console.WriteLine("File Size in Bytes: {0}", size);
                // File ReadOnly ?  
                bool IsReadOnly = archivoInfo.IsReadOnly;
                Console.WriteLine("Is ReadOnly: {0}", IsReadOnly);
                // Creation, last access, and last write time   
                DateTime creationTime = archivoInfo.CreationTime;
                Console.WriteLine("Creation time: {0}", creationTime);
                DateTime accessTime = archivoInfo.LastAccessTime;
                Console.WriteLine("Last access time: {0}", accessTime);
                DateTime updatedTime = archivoInfo.LastWriteTime;
                Console.WriteLine("Last write time: {0}", updatedTime);
            }
        }  
    }
}
