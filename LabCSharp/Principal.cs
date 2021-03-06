﻿using LabCSharp.Office.View;
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

        private void dataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Abrir archivo HTML
        }

        private void networkingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
