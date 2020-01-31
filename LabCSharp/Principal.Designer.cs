namespace LabCSharp
{
    partial class Principal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criptologiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.malwareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keyloggerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multimediaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.networkingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seguridadToolStripMenuItem,
            this.windowsToolStripMenuItem,
            this.programacionToolStripMenuItem,
            this.multimediaToolStripMenuItem,
            this.networkingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(771, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // seguridadToolStripMenuItem
            // 
            this.seguridadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criptologiaToolStripMenuItem,
            this.malwareToolStripMenuItem,
            this.keyloggerToolStripMenuItem});
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.seguridadToolStripMenuItem.Text = "Seguridad";
            // 
            // criptologiaToolStripMenuItem
            // 
            this.criptologiaToolStripMenuItem.Name = "criptologiaToolStripMenuItem";
            this.criptologiaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.criptologiaToolStripMenuItem.Text = "Criptologia";
            // 
            // malwareToolStripMenuItem
            // 
            this.malwareToolStripMenuItem.Name = "malwareToolStripMenuItem";
            this.malwareToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.malwareToolStripMenuItem.Text = "Malware";
            // 
            // keyloggerToolStripMenuItem
            // 
            this.keyloggerToolStripMenuItem.Name = "keyloggerToolStripMenuItem";
            this.keyloggerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.keyloggerToolStripMenuItem.Text = "Keylogger";
            // 
            // windowsToolStripMenuItem
            // 
            this.windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            this.windowsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.windowsToolStripMenuItem.Text = "Windows";
            // 
            // programacionToolStripMenuItem
            // 
            this.programacionToolStripMenuItem.Name = "programacionToolStripMenuItem";
            this.programacionToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.programacionToolStripMenuItem.Text = "Programacion";
            // 
            // multimediaToolStripMenuItem
            // 
            this.multimediaToolStripMenuItem.Name = "multimediaToolStripMenuItem";
            this.multimediaToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.multimediaToolStripMenuItem.Text = "Multimedia";
            // 
            // networkingToolStripMenuItem
            // 
            this.networkingToolStripMenuItem.Name = "networkingToolStripMenuItem";
            this.networkingToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.networkingToolStripMenuItem.Text = "Networking";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 587);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criptologiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem malwareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keyloggerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multimediaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem networkingToolStripMenuItem;
    }
}

