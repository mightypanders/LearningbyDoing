namespace Rechner
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
            this.btnRechnen = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblplus = new System.Windows.Forms.Label();
            this.lblminus = new System.Windows.Forms.Label();
            this.lblmulti = new System.Windows.Forms.Label();
            this.lbldivi = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRechnen
            // 
            this.btnRechnen.Location = new System.Drawing.Point(29, 60);
            this.btnRechnen.Name = "btnRechnen";
            this.btnRechnen.Size = new System.Drawing.Size(75, 23);
            this.btnRechnen.TabIndex = 0;
            this.btnRechnen.Text = "Rechnen";
            this.btnRechnen.UseVisualStyleBackColor = true;
            this.btnRechnen.Click += new System.EventHandler(this.btnRechnen_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // lblplus
            // 
            this.lblplus.AutoSize = true;
            this.lblplus.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblplus.Location = new System.Drawing.Point(127, 15);
            this.lblplus.Name = "lblplus";
            this.lblplus.Size = new System.Drawing.Size(13, 13);
            this.lblplus.TabIndex = 2;
            this.lblplus.Text = "+";
            this.lblplus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblplus.Click += new System.EventHandler(this.operatorchange);
            // 
            // lblminus
            // 
            this.lblminus.AutoSize = true;
            this.lblminus.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblminus.Location = new System.Drawing.Point(127, 30);
            this.lblminus.Name = "lblminus";
            this.lblminus.Size = new System.Drawing.Size(13, 13);
            this.lblminus.TabIndex = 3;
            this.lblminus.Text = "--";
            this.lblminus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblminus.Click += new System.EventHandler(this.operatorchange);
            // 
            // lblmulti
            // 
            this.lblmulti.AutoSize = true;
            this.lblmulti.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblmulti.Location = new System.Drawing.Point(146, 15);
            this.lblmulti.Name = "lblmulti";
            this.lblmulti.Size = new System.Drawing.Size(12, 13);
            this.lblmulti.TabIndex = 4;
            this.lblmulti.Text = "x";
            this.lblmulti.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblmulti.Click += new System.EventHandler(this.operatorchange);
            // 
            // lbldivi
            // 
            this.lbldivi.AutoSize = true;
            this.lbldivi.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbldivi.Location = new System.Drawing.Point(146, 30);
            this.lbldivi.Name = "lbldivi";
            this.lbldivi.Size = new System.Drawing.Size(12, 13);
            this.lbldivi.TabIndex = 5;
            this.lbldivi.Text = "/";
            this.lbldivi.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbldivi.Click += new System.EventHandler(this.operatorchange);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(164, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(110, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ergebnis";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(164, 62);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 102);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lbldivi);
            this.Controls.Add(this.lblmulti);
            this.Controls.Add(this.lblminus);
            this.Controls.Add(this.lblplus);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnRechnen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRechnen;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblplus;
        private System.Windows.Forms.Label lblminus;
        private System.Windows.Forms.Label lblmulti;
        private System.Windows.Forms.Label lbldivi;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
    }
}

