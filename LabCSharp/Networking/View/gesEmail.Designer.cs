namespace LabCSharp.Networking.View
{
    partial class gesEmail
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmailDestinatario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nmpEmailPuerto = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmailSMTP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmailPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmailUsuario = new System.Windows.Forms.TextBox();
            this.btnEmailEnviar = new System.Windows.Forms.Button();
            this.rtxtEmailBody = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtEmailasunto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmpEmailPuerto)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtEmailasunto);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtEmailDestinatario);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.nmpEmailPuerto);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtEmailSMTP);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtEmailPassword);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtEmailUsuario);
            this.tabPage1.Controls.Add(this.btnEmailEnviar);
            this.tabPage1.Controls.Add(this.rtxtEmailBody);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Email";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Destinatario";
            // 
            // txtEmailDestinatario
            // 
            this.txtEmailDestinatario.Location = new System.Drawing.Point(8, 110);
            this.txtEmailDestinatario.Name = "txtEmailDestinatario";
            this.txtEmailDestinatario.Size = new System.Drawing.Size(100, 20);
            this.txtEmailDestinatario.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Puerto";
            // 
            // nmpEmailPuerto
            // 
            this.nmpEmailPuerto.Location = new System.Drawing.Point(8, 84);
            this.nmpEmailPuerto.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nmpEmailPuerto.Name = "nmpEmailPuerto";
            this.nmpEmailPuerto.Size = new System.Drawing.Size(100, 20);
            this.nmpEmailPuerto.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Servidor SMTP";
            // 
            // txtEmailSMTP
            // 
            this.txtEmailSMTP.Location = new System.Drawing.Point(8, 58);
            this.txtEmailSMTP.Name = "txtEmailSMTP";
            this.txtEmailSMTP.Size = new System.Drawing.Size(100, 20);
            this.txtEmailSMTP.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Contraseña";
            // 
            // txtEmailPassword
            // 
            this.txtEmailPassword.Location = new System.Drawing.Point(8, 32);
            this.txtEmailPassword.Name = "txtEmailPassword";
            this.txtEmailPassword.Size = new System.Drawing.Size(100, 20);
            this.txtEmailPassword.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuario";
            // 
            // txtEmailUsuario
            // 
            this.txtEmailUsuario.Location = new System.Drawing.Point(8, 6);
            this.txtEmailUsuario.Name = "txtEmailUsuario";
            this.txtEmailUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtEmailUsuario.TabIndex = 2;
            // 
            // btnEmailEnviar
            // 
            this.btnEmailEnviar.Location = new System.Drawing.Point(8, 393);
            this.btnEmailEnviar.Name = "btnEmailEnviar";
            this.btnEmailEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEmailEnviar.TabIndex = 1;
            this.btnEmailEnviar.Text = "ENVIAR";
            this.btnEmailEnviar.UseVisualStyleBackColor = true;
            this.btnEmailEnviar.Click += new System.EventHandler(this.BtnEmailEnviar_Click);
            // 
            // rtxtEmailBody
            // 
            this.rtxtEmailBody.Location = new System.Drawing.Point(6, 207);
            this.rtxtEmailBody.Name = "rtxtEmailBody";
            this.rtxtEmailBody.Size = new System.Drawing.Size(398, 180);
            this.rtxtEmailBody.TabIndex = 0;
            this.rtxtEmailBody.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "DMARC Analyser";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtEmailasunto
            // 
            this.txtEmailasunto.Location = new System.Drawing.Point(8, 181);
            this.txtEmailasunto.Name = "txtEmailasunto";
            this.txtEmailasunto.Size = new System.Drawing.Size(100, 20);
            this.txtEmailasunto.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(114, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Asunto";
            // 
            // gesEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "gesEmail";
            this.Text = "gesEmail";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmpEmailPuerto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nmpEmailPuerto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmailSMTP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmailPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmailUsuario;
        private System.Windows.Forms.Button btnEmailEnviar;
        private System.Windows.Forms.RichTextBox rtxtEmailBody;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmailDestinatario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmailasunto;
    }
}