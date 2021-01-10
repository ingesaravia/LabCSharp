namespace LabCSharp.Windows.View
{
    partial class gesServicios
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnListarServicios = new System.Windows.Forms.Button();
            this.btnDetenerServ = new System.Windows.Forms.Button();
            this.rtxtListadoServicio = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnListarServicios);
            this.splitContainer1.Panel1.Controls.Add(this.btnDetenerServ);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.rtxtListadoServicio);
            this.splitContainer1.Size = new System.Drawing.Size(284, 261);
            this.splitContainer1.SplitterDistance = 94;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnListarServicios
            // 
            this.btnListarServicios.Location = new System.Drawing.Point(12, 103);
            this.btnListarServicios.Name = "btnListarServicios";
            this.btnListarServicios.Size = new System.Drawing.Size(75, 23);
            this.btnListarServicios.TabIndex = 1;
            this.btnListarServicios.Text = "LISTAR";
            this.btnListarServicios.UseVisualStyleBackColor = true;
            this.btnListarServicios.Click += new System.EventHandler(this.btnListarServicios_Click);
            // 
            // btnDetenerServ
            // 
            this.btnDetenerServ.Location = new System.Drawing.Point(12, 74);
            this.btnDetenerServ.Name = "btnDetenerServ";
            this.btnDetenerServ.Size = new System.Drawing.Size(75, 23);
            this.btnDetenerServ.TabIndex = 0;
            this.btnDetenerServ.Text = "DETENER";
            this.btnDetenerServ.UseVisualStyleBackColor = true;
            this.btnDetenerServ.Click += new System.EventHandler(this.btnDetenerServ_Click);
            // 
            // rtxtListadoServicio
            // 
            this.rtxtListadoServicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtListadoServicio.Location = new System.Drawing.Point(0, 0);
            this.rtxtListadoServicio.Name = "rtxtListadoServicio";
            this.rtxtListadoServicio.Size = new System.Drawing.Size(186, 261);
            this.rtxtListadoServicio.TabIndex = 0;
            this.rtxtListadoServicio.Text = "";
            // 
            // gesServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.splitContainer1);
            this.Name = "gesServicios";
            this.Text = "gesServicios";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnDetenerServ;
        private System.Windows.Forms.Button btnListarServicios;
        private System.Windows.Forms.RichTextBox rtxtListadoServicio;
    }
}