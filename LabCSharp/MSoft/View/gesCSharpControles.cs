﻿using System;
using System.Windows.Forms;

namespace LabCSharp.MSoft.View
{
    public partial class gesCSharpControles : Form
    {
        private string direccion;

        private string nomyAp;
        private int dni;
        private int id;
        private string domicilio;

        public gesCSharpControles()
        {
            InitializeComponent();
            
        }

        private void btnNavegar_Click(object sender, EventArgs e)
        {
            direccion = txtURL.Text;

            webBrowser1.AllowNavigation = true;
            webBrowser1.Navigate(@"http:\\" + direccion);

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Random miRand = new Random();
            int codigo = miRand.Next(0, 1000);
            dataGridView1.Rows.Add(codigo.ToString(), txtNomyAp.Text, txtDni.Text, txtDomicilio.Text);

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Selected)
            {
                int pos = dataGridView1.CurrentRow.Index;
                dataGridView1.Rows.RemoveAt(pos);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count != 0)
                if (dataGridView1.CurrentRow.Selected)
                {
                    DataGridViewRow miFila = new DataGridViewRow();
                    miFila = dataGridView1.CurrentRow;
                    MessageBox.Show("El usuario " + miFila.Cells[0] + "se llama " + miFila.Cells[1] + " vive en " + miFila.Cells[2] + " su dni es: " + miFila.Cells[3]);
                }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //para seleccionar el valor de un combobox
            richTextBox2.Text = "Seleccionaste: " + comboBox2.SelectedItem.ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            int cantidadItems = comboBox2.Items.Count + 1;
            comboBox2.Items.Add("Item " + cantidadItems);
            richTextBox2.AppendText("Agregaste el item " + cantidadItems);
        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedText != null)
            {
                string opcionSeleccionada = comboBox2.SelectedItem.ToString();
                MessageBox.Show("Está seleccionada la opcion: " + opcionSeleccionada);
            }
            else
                MessageBox.Show("Selecciona la opcion en el ComboBox");
            
        }

        private void btnCCsharpTreeViewAdd_Click(object sender, EventArgs e)
        {
            TreeNode nivel1 = new TreeNode();
            nivel1.Name = "AG00000";
            nivel1.Text = "GASTOS GENERALES";

            treeviewCCsharp.Nodes.Add(nivel1);



        }
    }
}
