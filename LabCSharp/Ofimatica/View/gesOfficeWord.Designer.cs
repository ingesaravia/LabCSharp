namespace LabCSharp.Ofimatica.View
{
    partial class gesOfficeWord
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
            this.tabOfficeWordControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOfficeWordCombinar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtOfficeWordExaminar = new System.Windows.Forms.TextBox();
            this.treeViewOfficeWord = new System.Windows.Forms.TreeView();
            this.tabOfficeWordControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabOfficeWordControl1
            // 
            this.tabOfficeWordControl1.Controls.Add(this.tabPage1);
            this.tabOfficeWordControl1.Controls.Add(this.tabPage2);
            this.tabOfficeWordControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabOfficeWordControl1.Location = new System.Drawing.Point(0, 0);
            this.tabOfficeWordControl1.Name = "tabOfficeWordControl1";
            this.tabOfficeWordControl1.SelectedIndex = 0;
            this.tabOfficeWordControl1.Size = new System.Drawing.Size(752, 537);
            this.tabOfficeWordControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(744, 511);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(744, 511);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Combinar Archivos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(738, 505);
            this.splitContainer1.SplitterDistance = 246;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.treeViewOfficeWord);
            this.splitContainer2.Size = new System.Drawing.Size(488, 505);
            this.splitContainer2.SplitterDistance = 162;
            this.splitContainer2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOfficeWordCombinar);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtOfficeWordExaminar);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 162);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione los archivos";
            // 
            // btnOfficeWordCombinar
            // 
            this.btnOfficeWordCombinar.Location = new System.Drawing.Point(407, 133);
            this.btnOfficeWordCombinar.Name = "btnOfficeWordCombinar";
            this.btnOfficeWordCombinar.Size = new System.Drawing.Size(75, 23);
            this.btnOfficeWordCombinar.TabIndex = 2;
            this.btnOfficeWordCombinar.Text = "COMBINAR";
            this.btnOfficeWordCombinar.UseVisualStyleBackColor = true;
            this.btnOfficeWordCombinar.Click += new System.EventHandler(this.btnOfficeWordCombinar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(407, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "EXAMINAR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtOfficeWordExaminar
            // 
            this.txtOfficeWordExaminar.Location = new System.Drawing.Point(6, 19);
            this.txtOfficeWordExaminar.Name = "txtOfficeWordExaminar";
            this.txtOfficeWordExaminar.Size = new System.Drawing.Size(395, 20);
            this.txtOfficeWordExaminar.TabIndex = 0;
            // 
            // treeViewOfficeWord
            // 
            this.treeViewOfficeWord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewOfficeWord.Location = new System.Drawing.Point(0, 0);
            this.treeViewOfficeWord.Name = "treeViewOfficeWord";
            this.treeViewOfficeWord.Size = new System.Drawing.Size(488, 339);
            this.treeViewOfficeWord.TabIndex = 0;
            // 
            // gesOfficeWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 537);
            this.Controls.Add(this.tabOfficeWordControl1);
            this.Name = "gesOfficeWord";
            this.Text = "gesOfficeWord";
            this.Load += new System.EventHandler(this.gesOfficeWord_Load);
            this.tabOfficeWordControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabOfficeWordControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOfficeWordCombinar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtOfficeWordExaminar;
        private System.Windows.Forms.TreeView treeViewOfficeWord;
    }
}