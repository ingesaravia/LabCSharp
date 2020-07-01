namespace LabCSharp.Office.View
{
    partial class gesHTML
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtDireccionArchivo = new System.Windows.Forms.TextBox();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.rtxtArchivos = new System.Windows.Forms.RichTextBox();
            this.btnUnir = new System.Windows.Forms.Button();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.txtDireccionArchivoFinal = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 353);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(460, 347);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(452, 321);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Recorrer";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(452, 321);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Combinar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnUnir);
            this.splitContainer1.Panel1.Controls.Add(this.rtxtArchivos);
            this.splitContainer1.Panel1.Controls.Add(this.btnExaminar);
            this.splitContainer1.Panel1.Controls.Add(this.txtDireccionArchivo);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtDireccionArchivoFinal);
            this.splitContainer1.Panel2.Controls.Add(this.btnAbrir);
            this.splitContainer1.Size = new System.Drawing.Size(446, 315);
            this.splitContainer1.SplitterDistance = 148;
            this.splitContainer1.TabIndex = 0;
            // 
            // txtDireccionArchivo
            // 
            this.txtDireccionArchivo.Location = new System.Drawing.Point(84, 5);
            this.txtDireccionArchivo.Name = "txtDireccionArchivo";
            this.txtDireccionArchivo.Size = new System.Drawing.Size(359, 20);
            this.txtDireccionArchivo.TabIndex = 0;
            // 
            // btnExaminar
            // 
            this.btnExaminar.Location = new System.Drawing.Point(3, 3);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(75, 23);
            this.btnExaminar.TabIndex = 1;
            this.btnExaminar.Text = "EXAMINAR";
            this.btnExaminar.UseVisualStyleBackColor = true;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // rtxtArchivos
            // 
            this.rtxtArchivos.Location = new System.Drawing.Point(3, 31);
            this.rtxtArchivos.Name = "rtxtArchivos";
            this.rtxtArchivos.Size = new System.Drawing.Size(440, 83);
            this.rtxtArchivos.TabIndex = 2;
            this.rtxtArchivos.Text = "";
            // 
            // btnUnir
            // 
            this.btnUnir.Location = new System.Drawing.Point(368, 120);
            this.btnUnir.Name = "btnUnir";
            this.btnUnir.Size = new System.Drawing.Size(75, 23);
            this.btnUnir.TabIndex = 3;
            this.btnUnir.Text = "UNIR";
            this.btnUnir.UseVisualStyleBackColor = true;
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(3, 3);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(75, 23);
            this.btnAbrir.TabIndex = 0;
            this.btnAbrir.Text = "ABRIR";
            this.btnAbrir.UseVisualStyleBackColor = true;
            // 
            // txtDireccionArchivoFinal
            // 
            this.txtDireccionArchivoFinal.Location = new System.Drawing.Point(84, 5);
            this.txtDireccionArchivoFinal.Name = "txtDireccionArchivoFinal";
            this.txtDireccionArchivoFinal.Size = new System.Drawing.Size(359, 20);
            this.txtDireccionArchivoFinal.TabIndex = 1;
            // 
            // gesHTML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 353);
            this.Controls.Add(this.panel1);
            this.Name = "gesHTML";
            this.Text = "gesHTML";
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnUnir;
        private System.Windows.Forms.RichTextBox rtxtArchivos;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.TextBox txtDireccionArchivo;
        private System.Windows.Forms.TextBox txtDireccionArchivoFinal;
        private System.Windows.Forms.Button btnAbrir;
    }
}