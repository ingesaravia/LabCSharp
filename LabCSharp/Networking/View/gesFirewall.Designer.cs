namespace LabCSharp.View
{
    partial class gesFirewall
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDesbloquearEntrante = new System.Windows.Forms.Button();
            this.btnBloquearEntrante = new System.Windows.Forms.Button();
            this.dataGridView1Entrantes = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDesbloquearSaliente = new System.Windows.Forms.Button();
            this.btnBloquearSaliente = new System.Windows.Forms.Button();
            this.dataGridView2Salientes = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1Entrantes)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2Salientes)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(9, 10);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(448, 334);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(440, 308);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Aplicaciones";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 5);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(434, 301);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnDesbloquearEntrante);
            this.groupBox1.Controls.Add(this.btnBloquearEntrante);
            this.groupBox1.Controls.Add(this.dataGridView1Entrantes);
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(429, 145);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conexiones Entrantes - Inbound Traffic (internet a programa)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(134, 122);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 124);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ESTADO";
            // 
            // btnDesbloquearEntrante
            // 
            this.btnDesbloquearEntrante.Location = new System.Drawing.Point(326, 122);
            this.btnDesbloquearEntrante.Margin = new System.Windows.Forms.Padding(2);
            this.btnDesbloquearEntrante.Name = "btnDesbloquearEntrante";
            this.btnDesbloquearEntrante.Size = new System.Drawing.Size(98, 19);
            this.btnDesbloquearEntrante.TabIndex = 2;
            this.btnDesbloquearEntrante.Text = "DESBLOQUEAR";
            this.btnDesbloquearEntrante.UseVisualStyleBackColor = true;
            this.btnDesbloquearEntrante.Click += new System.EventHandler(this.btnDesbloquearEntrante_Click);
            // 
            // btnBloquearEntrante
            // 
            this.btnBloquearEntrante.Location = new System.Drawing.Point(4, 122);
            this.btnBloquearEntrante.Margin = new System.Windows.Forms.Padding(2);
            this.btnBloquearEntrante.Name = "btnBloquearEntrante";
            this.btnBloquearEntrante.Size = new System.Drawing.Size(71, 19);
            this.btnBloquearEntrante.TabIndex = 1;
            this.btnBloquearEntrante.Text = "BLOQUEAR";
            this.btnBloquearEntrante.UseVisualStyleBackColor = true;
            this.btnBloquearEntrante.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1Entrantes
            // 
            this.dataGridView1Entrantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1Entrantes.Location = new System.Drawing.Point(4, 17);
            this.dataGridView1Entrantes.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1Entrantes.Name = "dataGridView1Entrantes";
            this.dataGridView1Entrantes.RowTemplate.Height = 24;
            this.dataGridView1Entrantes.Size = new System.Drawing.Size(420, 100);
            this.dataGridView1Entrantes.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnDesbloquearSaliente);
            this.groupBox2.Controls.Add(this.btnBloquearSaliente);
            this.groupBox2.Controls.Add(this.dataGridView2Salientes);
            this.groupBox2.Location = new System.Drawing.Point(2, 152);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(429, 145);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Conexiones Salientes - Outbound Traffic (programa a Internet)";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(134, 122);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(189, 20);
            this.textBox2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ESTADO";
            // 
            // btnDesbloquearSaliente
            // 
            this.btnDesbloquearSaliente.Location = new System.Drawing.Point(326, 122);
            this.btnDesbloquearSaliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnDesbloquearSaliente.Name = "btnDesbloquearSaliente";
            this.btnDesbloquearSaliente.Size = new System.Drawing.Size(98, 19);
            this.btnDesbloquearSaliente.TabIndex = 2;
            this.btnDesbloquearSaliente.Text = "DESBLOQUEAR";
            this.btnDesbloquearSaliente.UseVisualStyleBackColor = true;
            // 
            // btnBloquearSaliente
            // 
            this.btnBloquearSaliente.Location = new System.Drawing.Point(4, 122);
            this.btnBloquearSaliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnBloquearSaliente.Name = "btnBloquearSaliente";
            this.btnBloquearSaliente.Size = new System.Drawing.Size(71, 19);
            this.btnBloquearSaliente.TabIndex = 1;
            this.btnBloquearSaliente.Text = "BLOQUEAR";
            this.btnBloquearSaliente.UseVisualStyleBackColor = true;
            // 
            // dataGridView2Salientes
            // 
            this.dataGridView2Salientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2Salientes.Location = new System.Drawing.Point(4, 17);
            this.dataGridView2Salientes.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2Salientes.Name = "dataGridView2Salientes";
            this.dataGridView2Salientes.RowTemplate.Height = 24;
            this.dataGridView2Salientes.Size = new System.Drawing.Size(420, 100);
            this.dataGridView2Salientes.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(440, 308);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Dominio";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gesFirewall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 353);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "gesFirewall";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "gesFirewall";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1Entrantes)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2Salientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDesbloquearEntrante;
        private System.Windows.Forms.Button btnBloquearEntrante;
        private System.Windows.Forms.DataGridView dataGridView1Entrantes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDesbloquearSaliente;
        private System.Windows.Forms.Button btnBloquearSaliente;
        private System.Windows.Forms.DataGridView dataGridView2Salientes;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
    }
}