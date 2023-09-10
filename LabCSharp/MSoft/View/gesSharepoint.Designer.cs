namespace LabCSharp.MSoft.View
{
    partial class gesSharepoint
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtSPSite = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSPUserpassword = new System.Windows.Forms.TextBox();
            this.txtSPUseraccount = new System.Windows.Forms.TextBox();
            this.btnSharepointAceptar = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSPUserListEjecutar = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnSPScriptEjecutar = new System.Windows.Forms.Button();
            this.btnSPScriptExaminar = new System.Windows.Forms.Button();
            this.txtSPScriptExaminar = new System.Windows.Forms.TextBox();
            this.btnPowershellExecutionPolicy = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtSPSite);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtSPUserpassword);
            this.tabPage1.Controls.Add(this.txtSPUseraccount);
            this.tabPage1.Controls.Add(this.btnSharepointAceptar);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Login";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "SharePoint Site";
            // 
            // txtSPSite
            // 
            this.txtSPSite.Location = new System.Drawing.Point(8, 8);
            this.txtSPSite.Name = "txtSPSite";
            this.txtSPSite.Size = new System.Drawing.Size(100, 20);
            this.txtSPSite.TabIndex = 5;
            this.txtSPSite.Text = "https://tcigecomp-admin.sharepoint.com";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "User password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "User Account";
            // 
            // txtSPUserpassword
            // 
            this.txtSPUserpassword.Location = new System.Drawing.Point(8, 60);
            this.txtSPUserpassword.Name = "txtSPUserpassword";
            this.txtSPUserpassword.Size = new System.Drawing.Size(100, 20);
            this.txtSPUserpassword.TabIndex = 2;
            // 
            // txtSPUseraccount
            // 
            this.txtSPUseraccount.Location = new System.Drawing.Point(8, 34);
            this.txtSPUseraccount.Name = "txtSPUseraccount";
            this.txtSPUseraccount.Size = new System.Drawing.Size(100, 20);
            this.txtSPUseraccount.TabIndex = 1;
            // 
            // btnSharepointAceptar
            // 
            this.btnSharepointAceptar.Location = new System.Drawing.Point(8, 86);
            this.btnSharepointAceptar.Name = "btnSharepointAceptar";
            this.btnSharepointAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnSharepointAceptar.TabIndex = 0;
            this.btnSharepointAceptar.Text = "ACEPTAR";
            this.btnSharepointAceptar.UseVisualStyleBackColor = true;
            this.btnSharepointAceptar.Click += new System.EventHandler(this.BtnSharepointAceptar_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnSPUserListEjecutar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Usuarios";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSPUserListEjecutar
            // 
            this.btnSPUserListEjecutar.Location = new System.Drawing.Point(8, 6);
            this.btnSPUserListEjecutar.Name = "btnSPUserListEjecutar";
            this.btnSPUserListEjecutar.Size = new System.Drawing.Size(75, 23);
            this.btnSPUserListEjecutar.TabIndex = 0;
            this.btnSPUserListEjecutar.Text = "EJECUTAR";
            this.btnSPUserListEjecutar.UseVisualStyleBackColor = true;
            this.btnSPUserListEjecutar.Click += new System.EventHandler(this.BtnSPUserListEjecutar_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnPowershellExecutionPolicy);
            this.tabPage3.Controls.Add(this.btnSPScriptEjecutar);
            this.tabPage3.Controls.Add(this.btnSPScriptExaminar);
            this.tabPage3.Controls.Add(this.txtSPScriptExaminar);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(792, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Script";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnSPScriptEjecutar
            // 
            this.btnSPScriptEjecutar.Location = new System.Drawing.Point(41, 217);
            this.btnSPScriptEjecutar.Name = "btnSPScriptEjecutar";
            this.btnSPScriptEjecutar.Size = new System.Drawing.Size(75, 23);
            this.btnSPScriptEjecutar.TabIndex = 2;
            this.btnSPScriptEjecutar.Text = "EJECUTAR";
            this.btnSPScriptEjecutar.UseVisualStyleBackColor = true;
            this.btnSPScriptEjecutar.Click += new System.EventHandler(this.BtnSPScriptEjecutar_Click);
            // 
            // btnSPScriptExaminar
            // 
            this.btnSPScriptExaminar.Location = new System.Drawing.Point(41, 162);
            this.btnSPScriptExaminar.Name = "btnSPScriptExaminar";
            this.btnSPScriptExaminar.Size = new System.Drawing.Size(75, 23);
            this.btnSPScriptExaminar.TabIndex = 1;
            this.btnSPScriptExaminar.Text = "EXAMINAR";
            this.btnSPScriptExaminar.UseVisualStyleBackColor = true;
            this.btnSPScriptExaminar.Click += new System.EventHandler(this.BtnSPScriptExaminar_Click);
            // 
            // txtSPScriptExaminar
            // 
            this.txtSPScriptExaminar.Location = new System.Drawing.Point(41, 191);
            this.txtSPScriptExaminar.Name = "txtSPScriptExaminar";
            this.txtSPScriptExaminar.Size = new System.Drawing.Size(100, 20);
            this.txtSPScriptExaminar.TabIndex = 0;
            // 
            // btnPowershellExecutionPolicy
            // 
            this.btnPowershellExecutionPolicy.Location = new System.Drawing.Point(8, 3);
            this.btnPowershellExecutionPolicy.Name = "btnPowershellExecutionPolicy";
            this.btnPowershellExecutionPolicy.Size = new System.Drawing.Size(75, 23);
            this.btnPowershellExecutionPolicy.TabIndex = 3;
            this.btnPowershellExecutionPolicy.Text = "HABILITAR";
            this.btnPowershellExecutionPolicy.UseVisualStyleBackColor = true;
            this.btnPowershellExecutionPolicy.Click += new System.EventHandler(this.BtnPowershellExecutionPolicy_Click);
            // 
            // gesSharepoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "gesSharepoint";
            this.Text = "gesSharepoint";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnSharepointAceptar;
        private System.Windows.Forms.Button btnSPUserListEjecutar;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnSPScriptEjecutar;
        private System.Windows.Forms.Button btnSPScriptExaminar;
        private System.Windows.Forms.TextBox txtSPScriptExaminar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSPSite;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSPUserpassword;
        private System.Windows.Forms.TextBox txtSPUseraccount;
        private System.Windows.Forms.Button btnPowershellExecutionPolicy;
    }
}