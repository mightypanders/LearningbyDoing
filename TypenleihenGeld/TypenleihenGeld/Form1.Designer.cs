namespace TypenleihenGeld
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
            this.Transaktion = new System.Windows.Forms.Button();
            this.TimGeld = new System.Windows.Forms.Label();
            this.TomsGeld = new System.Windows.Forms.Label();
            this.BankGeld = new System.Windows.Forms.Label();
            this.SenderBox = new System.Windows.Forms.ComboBox();
            this.EmpfängerBox = new System.Windows.Forms.ComboBox();
            this.EingabeWert = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Transaktion
            // 
            this.Transaktion.Location = new System.Drawing.Point(139, 113);
            this.Transaktion.Name = "Transaktion";
            this.Transaktion.Size = new System.Drawing.Size(120, 50);
            this.Transaktion.TabIndex = 0;
            this.Transaktion.Text = "Transaktion";
            this.Transaktion.UseVisualStyleBackColor = true;
            this.Transaktion.Click += new System.EventHandler(this.Transaktion_Click);
            // 
            // TimGeld
            // 
            this.TimGeld.AutoSize = true;
            this.TimGeld.Location = new System.Drawing.Point(16, 113);
            this.TimGeld.Name = "TimGeld";
            this.TimGeld.Size = new System.Drawing.Size(49, 13);
            this.TimGeld.TabIndex = 2;
            this.TimGeld.Text = "Geld Tim";
            // 
            // TomsGeld
            // 
            this.TomsGeld.AutoSize = true;
            this.TomsGeld.Location = new System.Drawing.Point(16, 142);
            this.TomsGeld.Name = "TomsGeld";
            this.TomsGeld.Size = new System.Drawing.Size(53, 13);
            this.TomsGeld.TabIndex = 3;
            this.TomsGeld.Text = "Geld Tom";
            // 
            // BankGeld
            // 
            this.BankGeld.AutoSize = true;
            this.BankGeld.Location = new System.Drawing.Point(16, 168);
            this.BankGeld.Name = "BankGeld";
            this.BankGeld.Size = new System.Drawing.Size(57, 13);
            this.BankGeld.TabIndex = 4;
            this.BankGeld.Text = "Geld Bank";
            // 
            // SenderBox
            // 
            this.SenderBox.FormattingEnabled = true;
            this.SenderBox.Items.AddRange(new object[] {
            "Tim",
            "Tom",
            "Bank"});
            this.SenderBox.Location = new System.Drawing.Point(12, 12);
            this.SenderBox.Name = "SenderBox";
            this.SenderBox.Size = new System.Drawing.Size(107, 21);
            this.SenderBox.TabIndex = 5;
            // 
            // EmpfängerBox
            // 
            this.EmpfängerBox.FormattingEnabled = true;
            this.EmpfängerBox.Items.AddRange(new object[] {
            "Tim",
            "Tom",
            "Bank"});
            this.EmpfängerBox.Location = new System.Drawing.Point(152, 12);
            this.EmpfängerBox.Name = "EmpfängerBox";
            this.EmpfängerBox.Size = new System.Drawing.Size(107, 21);
            this.EmpfängerBox.TabIndex = 6;
            // 
            // EingabeWert
            // 
            this.EingabeWert.Location = new System.Drawing.Point(84, 58);
            this.EingabeWert.Name = "EingabeWert";
            this.EingabeWert.Size = new System.Drawing.Size(100, 20);
            this.EingabeWert.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 207);
            this.Controls.Add(this.EingabeWert);
            this.Controls.Add(this.EmpfängerBox);
            this.Controls.Add(this.SenderBox);
            this.Controls.Add(this.BankGeld);
            this.Controls.Add(this.TomsGeld);
            this.Controls.Add(this.TimGeld);
            this.Controls.Add(this.Transaktion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();



        }

        #endregion

        private System.Windows.Forms.Button Transaktion;
        private System.Windows.Forms.Label TimGeld;
        private System.Windows.Forms.Label TomsGeld;
        private System.Windows.Forms.Label BankGeld;
        private System.Windows.Forms.ComboBox SenderBox;
        private System.Windows.Forms.ComboBox EmpfängerBox;
        private System.Windows.Forms.TextBox EingabeWert;
    }
}

