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
            this.btn_zuweisen = new System.Windows.Forms.Button();
            this.nud_shifts = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_nextshift = new System.Windows.Forms.Button();
            this.txb_Log = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_shifts)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nud_shifts);
            this.groupBox1.Controls.Add(this.btn_zuweisen);
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
            // btn_zuweisen
            // 
            this.btn_zuweisen.Location = new System.Drawing.Point(12, 64);
            this.btn_zuweisen.Name = "btn_zuweisen";
            this.btn_zuweisen.Size = new System.Drawing.Size(147, 23);
            this.btn_zuweisen.TabIndex = 2;
            this.btn_zuweisen.Text = "Diese Aufgabe zuweisen";
            this.btn_zuweisen.UseVisualStyleBackColor = true;
            this.btn_zuweisen.Click += new System.EventHandler(this.button1_Click);
            // 
            // nud_shifts
            // 
            this.nud_shifts.Location = new System.Drawing.Point(174, 38);
            this.nud_shifts.Name = "nud_shifts";
            this.nud_shifts.Size = new System.Drawing.Size(68, 20);
            this.nud_shifts.TabIndex = 3;
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
            // btn_nextshift
            // 
            this.btn_nextshift.Location = new System.Drawing.Point(295, 33);
            this.btn_nextshift.Name = "btn_nextshift";
            this.btn_nextshift.Size = new System.Drawing.Size(75, 67);
            this.btn_nextshift.TabIndex = 1;
            this.btn_nextshift.Text = "Nächste Schicht arbeiten";
            this.btn_nextshift.UseVisualStyleBackColor = true;
            this.btn_nextshift.Click += new System.EventHandler(this.button2_Click);
            // 
            // txb_Log
            // 
            this.txb_Log.Location = new System.Drawing.Point(13, 120);
            this.txb_Log.Multiline = true;
            this.txb_Log.Name = "txb_Log";
            this.txb_Log.Size = new System.Drawing.Size(357, 222);
            this.txb_Log.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 354);
            this.Controls.Add(this.txb_Log);
            this.Controls.Add(this.btn_nextshift);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_shifts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nud_shifts;
        private System.Windows.Forms.Button btn_zuweisen;
        private System.Windows.Forms.ComboBox cbb_auftrage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_nextshift;
        private System.Windows.Forms.TextBox txb_Log;
    }
}

