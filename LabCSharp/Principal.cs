using LabCSharp.Office.View;
using LabCSharp.Programacion.View;
using LabCSharp.View;
using LabCSharp.Windows.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            Random rand = new Random();
            int num = rand.Next(1, 2);

            string fullpath = "..\\..\\Img\\fondo" + num.ToString() + ".jpg";
            Image miImg = Bitmap.FromFile(fullpath);
            this.BackgroundImage = miImg;
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

        private void archivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gesArchivo miGA = new gesArchivo();
            miGA.MdiParent = this;
            miGA.Visible = true;
        }

        private void bATCHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* pra borrar los temporales de windows */
            /// se escribe %temp% en un comando cmd    

            /* SCRIPTS
                un comando es un pequeño archivo almaceando en system32 de windows
                algunos comandos requieren parametros , otros no, como help.
                COMANDOS
                cd.. vuelve atrsa
                cd dir de carpeta
                dir muestra carpetas
                dir /p muestra archivos en forma pausada
                parametros: / letra
                /? ayuda
                -letra
                cls limpia pantalla

                MAS USADOS
                attrib, ftp, ipconfig, hostname, netstat, nbtstat, net, user, telnet, doskey, edline
                help, xcopy, etc..

                */

            /* CARPETA
            notacion: C:\..\carpeta
            md nombrecarpeta (crear carpeta)
            rd nombrecarpeta (borrarcarpeta que debe estar vacia)
            rd nombrecarpeta /s (borra con todo)
            rd *.jpg (borra las imagenes con esa extension) con Pause Inter - muestra la ventana MSDOS
            dir *.xtension muestra direcotrior con tipo de archivo con esa extension
            dir nombre.* muestra archivo con una extension variable
            dir ????.txt muestra archivo con 4 simbolos y de tipo text
            dir ????.* muestra sin la extension
            dir *.??? muestra con cualquier extension y cualquier nombre
            path nombrearchivo
            */

            /*ARCHIVOS
            notacion: C:/../archivo
            copy con nombrearchivo.extension (crea yarchivo y presionar F6 para lograrlo)
            type nombreachivo.extension (muestra archivo de texto solo lectura)
            del nombrearchivo.extension (borra archivo)
            move nombrearchivo carpeta archivo (copia y pega)
            move nombrearchivo ../ para que veula a la dir original
            move nombrecarpeta nuevonombre (cambia el nombre)
            ren nombrearchivo nombrearchivo2 (cambia nombre)
            ren A.txt A.doc (cambia extension)

            attrib sirve para modificar las propiedades de los archivos
            attrib muestra los archivosc on sus propiedades
            attrib C: muestra los archivos de una unidad en especifico.
            attrib +R muestra los de solo lectura
            attrib -R muestra los editables
            attrib +A muestra los de respaldo
            attrib -A muestra los que no son de respaldo
            attrib +H muestra que esta oculto
            attrib -H muestra que no esta oculto (es visible)
            attrib nombrearchivo +H hace que el archivo se haga oculto
            attrib /s permite que la propiedade se aplique a la carpeta y sus subcarpetas
            attrib /d procesa una carpeta (no siempre esta disponible)

            copy sirve para copiar archivos
            xcopy sirve para copiar varios archivos
            xcopy dirorigen dirdestino [parametros] [/exclude] archivosexcluidos
            xcopy dirorigen dirdestino copia todos los archivos y carpetas de origen a destino
            xcopy dirorigen archivodestino copia todos los archivos en un solo archivo destino
            */

            /* FORMATO DE ARCHIVO
            format C: /FS: NTFS
            format E: /all : FAT
            */

            /* SISTEMA OPERATIVO
            ver nombre.txt muestra la version en un archivo txt
            type nombre.txt mues
            */

            /* REGEDIT
            reg query cadenaregistro /modificador permite visualizar cadenas y valores
            la mayoria de los virus se aloja en HKEYLOCALMACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Run
            cadenas basicas: HKLM (HKEYLOCALMACHINE) Y HKCU (HKEYCURRENTUSER)
            Despues siguen HKCR, HKU, HKCC
            Se puede abreviar
            Ejemplo: reg query HKLM\Software\Microsoft\Windows\CurrentVersion\Run
            reg query HKLM.. /s para revisar si hay subcadenas y subclaves
            reg query HKLM.. /v para revisar una sola clave especirfica.
            reg query HKLM.. /ve es para evitar ver todas las claves dentro de una cadena.

            reg delete cadena /modificador /clave borra la clave de una cadena y todas las subclaves y valores
            reg delete HKLM\Software\Microsoft\Windows\CurrentVersion\Run\programa.exe
            reg delete HKLM\Software\Microsoft\Windows\CurrentVersion\Run\QuickT~1 borra las tareas de quicktime
            reg export cadena archivo.reg sirve para exportar una cadena en caso de que quieramos instalar y reinstalar
            reg export HKLM\Software\Microsoft\Windows\CurrentVersion\Run registro.reg guarda las claves del inicio en un archivo
            reg import archivo.reg para importar un archivo externo al registro
            reg 
            reg 
            */
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

        private void impresoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gesCSharpPrinting miGCSP = new gesCSharpPrinting();
            miGCSP.MdiParent = this;
            miGCSP.Visible = true;
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

        private void pixelesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gesPixeles miGPx = new gesPixeles();
            miGPx.MdiParent = this;
            miGPx.Visible = true;
        }

        private void conectividadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gesConectividad miGC = new gesConectividad();
            miGC.MdiParent = this;
            miGC.Visible = true;
        }

        private void firewallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gesFirewall miFirewall = new gesFirewall();
            miFirewall.MdiParent = this;
            miFirewall.Visible = true;
        }

        private void navegadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gesNavegador miNav = new gesNavegador();
            miNav.MdiParent = this;
            miNav.Visible = true;
        }

        private void codificacionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            gesCodificacion miCodif = new gesCodificacion();
            miCodif.MdiParent = this;
            miCodif.Visible = true;
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

        private void consolaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            gesConsola miGesConsola = new gesConsola();
            miGesConsola.MdiParent = this;
            miGesConsola.Visible = true;
        }

        private void relojToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            gesReloj miGesReloj = new gesReloj();
            miGesReloj.MdiParent = this;
            miGesReloj.Visible = true;
        }
    }
}
