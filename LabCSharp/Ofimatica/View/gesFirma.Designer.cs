namespace LabCSharp.Ofimatica.View
{
    partial class gesFirma
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataFirma = new System.Windows.Forms.DataGridView();
            this.correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Movil1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Movil2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proyecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Linkedin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generarFirmas = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnFormatoArchivoFirma = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtArchivoFirmas = new System.Windows.Forms.TextBox();
            this.btnBuscarArchivoFirmas = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnFirmaActualizar = new System.Windows.Forms.Button();
            this.webBrowserFirma = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.dataFirma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataFirma
            // 
            this.dataFirma.AllowUserToResizeColumns = false;
            this.dataFirma.AllowUserToResizeRows = false;
            this.dataFirma.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataFirma.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataFirma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataFirma.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.correo,
            this.Usuario,
            this.cargo,
            this.Movil1,
            this.Movil2,
            this.Telefono,
            this.Proyecto,
            this.Empresa,
            this.Direccion,
            this.Linkedin});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataFirma.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataFirma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataFirma.Location = new System.Drawing.Point(0, 0);
            this.dataFirma.Name = "dataFirma";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataFirma.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataFirma.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataFirma.Size = new System.Drawing.Size(1237, 230);
            this.dataFirma.TabIndex = 3;
            // 
            // correo
            // 
            this.correo.HeaderText = "Correo";
            this.correo.Name = "correo";
            this.correo.Width = 150;
            // 
            // Usuario
            // 
            this.Usuario.HeaderText = "NomyAp";
            this.Usuario.Name = "Usuario";
            this.Usuario.Width = 150;
            // 
            // cargo
            // 
            this.cargo.HeaderText = "Cargo";
            this.cargo.Name = "cargo";
            this.cargo.Width = 150;
            // 
            // Movil1
            // 
            this.Movil1.HeaderText = "Movil1";
            this.Movil1.Name = "Movil1";
            // 
            // Movil2
            // 
            this.Movil2.HeaderText = "Movil2";
            this.Movil2.Name = "Movil2";
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            // 
            // Proyecto
            // 
            this.Proyecto.HeaderText = "Proyecto";
            this.Proyecto.Name = "Proyecto";
            // 
            // Empresa
            // 
            this.Empresa.HeaderText = "Empresa";
            this.Empresa.Name = "Empresa";
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            // 
            // Linkedin
            // 
            this.Linkedin.HeaderText = "Linkedin";
            this.Linkedin.Name = "Linkedin";
            // 
            // generarFirmas
            // 
            this.generarFirmas.Location = new System.Drawing.Point(87, 19);
            this.generarFirmas.Name = "generarFirmas";
            this.generarFirmas.Size = new System.Drawing.Size(75, 23);
            this.generarFirmas.TabIndex = 4;
            this.generarFirmas.Text = "GENERAR";
            this.generarFirmas.UseVisualStyleBackColor = true;
            this.generarFirmas.Click += new System.EventHandler(this.GenerarFirmas_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataFirma);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Size = new System.Drawing.Size(1237, 601);
            this.splitContainer1.SplitterDistance = 367;
            this.splitContainer1.TabIndex = 5;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer2.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer2.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox4);
            this.splitContainer2.Size = new System.Drawing.Size(1237, 367);
            this.splitContainer2.SplitterDistance = 412;
            this.splitContainer2.TabIndex = 10;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnFirmaActualizar);
            this.groupBox3.Controls.Add(this.generarFirmas);
            this.groupBox3.Location = new System.Drawing.Point(3, 246);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(406, 118);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Generar Firmas";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnFormatoArchivoFirma);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(406, 100);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Descargar Formato";
            // 
            // btnFormatoArchivoFirma
            // 
            this.btnFormatoArchivoFirma.Location = new System.Drawing.Point(9, 19);
            this.btnFormatoArchivoFirma.Name = "btnFormatoArchivoFirma";
            this.btnFormatoArchivoFirma.Size = new System.Drawing.Size(75, 23);
            this.btnFormatoArchivoFirma.TabIndex = 9;
            this.btnFormatoArchivoFirma.Text = "FORMATO";
            this.btnFormatoArchivoFirma.UseVisualStyleBackColor = true;
            this.btnFormatoArchivoFirma.Click += new System.EventHandler(this.BtnFormatoArchivoFirma_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtArchivoFirmas);
            this.groupBox1.Controls.Add(this.btnBuscarArchivoFirmas);
            this.groupBox1.Location = new System.Drawing.Point(3, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 131);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccionar Archivo";
            // 
            // txtArchivoFirmas
            // 
            this.txtArchivoFirmas.Location = new System.Drawing.Point(6, 48);
            this.txtArchivoFirmas.Name = "txtArchivoFirmas";
            this.txtArchivoFirmas.Size = new System.Drawing.Size(385, 20);
            this.txtArchivoFirmas.TabIndex = 7;
            // 
            // btnBuscarArchivoFirmas
            // 
            this.btnBuscarArchivoFirmas.Location = new System.Drawing.Point(6, 19);
            this.btnBuscarArchivoFirmas.Name = "btnBuscarArchivoFirmas";
            this.btnBuscarArchivoFirmas.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarArchivoFirmas.TabIndex = 8;
            this.btnBuscarArchivoFirmas.Text = "EXAMINAR";
            this.btnBuscarArchivoFirmas.UseVisualStyleBackColor = true;
            this.btnBuscarArchivoFirmas.Click += new System.EventHandler(this.BtnBuscarArchivoFirmas_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.webBrowserFirma);
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(815, 361);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Previsualización";
            // 
            // btnFirmaActualizar
            // 
            this.btnFirmaActualizar.Location = new System.Drawing.Point(6, 19);
            this.btnFirmaActualizar.Name = "btnFirmaActualizar";
            this.btnFirmaActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnFirmaActualizar.TabIndex = 6;
            this.btnFirmaActualizar.Text = "ACTUALIZAR";
            this.btnFirmaActualizar.UseVisualStyleBackColor = true;
            this.btnFirmaActualizar.Click += new System.EventHandler(this.BtnFirmaActualizar_Click);
            // 
            // webBrowserFirma
            // 
            this.webBrowserFirma.Location = new System.Drawing.Point(6, 19);
            this.webBrowserFirma.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserFirma.Name = "webBrowserFirma";
            this.webBrowserFirma.Size = new System.Drawing.Size(803, 336);
            this.webBrowserFirma.TabIndex = 5;
            // 
            // gesFirma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 601);
            this.Controls.Add(this.splitContainer1);
            this.Name = "gesFirma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "gesFirma";
            ((System.ComponentModel.ISupportInitialize)(this.dataFirma)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataFirma;
        private System.Windows.Forms.Button generarFirmas;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnFirmaActualizar;
        private System.Windows.Forms.WebBrowser webBrowserFirma;
        private System.Windows.Forms.Button btnFormatoArchivoFirma;
        private System.Windows.Forms.Button btnBuscarArchivoFirmas;
        private System.Windows.Forms.TextBox txtArchivoFirmas;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Movil1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Movil2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proyecto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Linkedin;
    }
}