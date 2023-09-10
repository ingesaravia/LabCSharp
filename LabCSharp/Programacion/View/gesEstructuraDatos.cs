using System;
using System.Windows.Forms;
using LabCSharp.Class;
using LabCSharp.Programacion.Class;

namespace LabCSharp.Programacion.View
{
    public partial class gesEstructuraDatos : Form
    {
        private claseListas miListas;
        private claseArreglos miArreglos;
        private int tipoLista;

        public gesEstructuraDatos()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGenLista_Click(object sender, EventArgs e)
        {
            miListas = new claseListas();

            //Seleccionar el radiobutton adecuado
            if (rdListaEnt.Checked)
            {
                tipoLista = 1;
                miListas.genListaEnterosRandom();
            }
            else
                if (rdListaCar.Checked) {
                tipoLista = 2;
                miListas.genListaCaracteresRandom();
            }
                
            else {
                tipoLista = 3;
                miListas.genListaCadenasRandom();
            }
                
        }

        private void btnEjecLista_Click(object sender, EventArgs e)
        {
            if (cmbOrdenLista.SelectedItem != null) {
                string opcion = cmbOrdenLista.SelectedItem.ToString();
                if (opcion == "Buscar Repetidos")
                    buscarRepetidosLista();
                if (opcion == "Eliminar Repetidos")
                    eliminarRepetidosLista();
            }
        }

        private void ordenarLista() {
            if (miListas != null) {
                if (tipoLista == 1)
                    miListas.ordenarListaEnteros();
            }
        }
        private void buscarRepetidosLista() {

        }

        private void eliminarRepetidosLista() {

        }

        private void btnGenerarASCII_Click(object sender, EventArgs e)
        {
            //for ()

            //dataGridView1.Rows.Add(codigo.ToString(), txtNomyAp.Text, txtDni.Text, txtDomicilio.Text);
        }

        private void btnGenArreglo_Click(object sender, EventArgs e)
        {
            string cadena;

            if (rbtnArregloEnt.Checked)
            {
                txtArreglosRes.AppendText("La estructura de un arreglo de enteros se define como: \n");
                txtArreglosRes.AppendText("int[] arregloEnteros = ; \n");

            }
                
            
        }

        private void btnEstrucMientras_Click(object sender, EventArgs e)
        {
            //string estrucSelec = cmbEstrucSelect.SelectedItem.ToString();

            rtxtEstrucRes.AppendText("While (condición) \n");
            rtxtEstrucRes.AppendText("{ \n");
            rtxtEstrucRes.AppendText("//realizar acciones \n");
            rtxtEstrucRes.AppendText("} \n");
            

        }
    }
}
