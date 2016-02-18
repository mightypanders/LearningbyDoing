namespace BienenStockVerwaltung
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_auftrage = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cbb_auftrage);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arbeitsaufträge für Arbeiterinnen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Arbeitsbienenauftrag";
            // 
            // cbb_auftrage
            // 
            this.cbb_auftrage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_auftrage.FormattingEnabled = true;
            this.cbb_auftrage.Location = new System.Drawing.Point(10, 37);
            this.cbb_auftrage.Name = "cbb_auftrage";
            this.cbb_auftrage.Size = new System.Drawing.Size(149, 21);
            this.cbb_auftrage.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Diese Aufgabe zuweisen";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(174, 38);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(68, 20);
            this.numericUpDown1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Schichten";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(295, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 67);
            this.button2.TabIndex = 1;
            this.button2.Text = "Nächste Schicht arbeiten";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 120);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(357, 222);
            this.textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 354);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbb_auftrage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

