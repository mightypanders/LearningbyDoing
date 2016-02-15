namespace CateringKostenRechner
{
    partial class PartyPlaner
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
            this.lbl_PersAnz = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lbl_Kosten = new System.Windows.Forms.Label();
            this.lbl_KostenFeld = new System.Windows.Forms.Label();
            this.chk_ausgefallen = new System.Windows.Forms.CheckBox();
            this.chk_trocken = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_PersAnz
            // 
            this.lbl_PersAnz.AutoSize = true;
            this.lbl_PersAnz.Location = new System.Drawing.Point(13, 13);
            this.lbl_PersAnz.Name = "lbl_PersAnz";
            this.lbl_PersAnz.Size = new System.Drawing.Size(83, 13);
            this.lbl_PersAnz.TabIndex = 0;
            this.lbl_PersAnz.Text = "Personenanzahl";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(13, 30);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // lbl_Kosten
            // 
            this.lbl_Kosten.AutoSize = true;
            this.lbl_Kosten.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbl_Kosten.Location = new System.Drawing.Point(13, 114);
            this.lbl_Kosten.Name = "lbl_Kosten";
            this.lbl_Kosten.Size = new System.Drawing.Size(46, 13);
            this.lbl_Kosten.TabIndex = 4;
            this.lbl_Kosten.Text = "Kosten";
            // 
            // lbl_KostenFeld
            // 
            this.lbl_KostenFeld.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_KostenFeld.Location = new System.Drawing.Point(61, 113);
            this.lbl_KostenFeld.Name = "lbl_KostenFeld";
            this.lbl_KostenFeld.Size = new System.Drawing.Size(72, 22);
            this.lbl_KostenFeld.TabIndex = 5;
            // 
            // chk_ausgefallen
            // 
            this.chk_ausgefallen.AutoSize = true;
            this.chk_ausgefallen.Checked = true;
            this.chk_ausgefallen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_ausgefallen.Location = new System.Drawing.Point(16, 65);
            this.chk_ausgefallen.Name = "chk_ausgefallen";
            this.chk_ausgefallen.Size = new System.Drawing.Size(124, 17);
            this.chk_ausgefallen.TabIndex = 6;
            this.chk_ausgefallen.Text = "Ausgefallener Abend";
            this.chk_ausgefallen.UseVisualStyleBackColor = true;
            this.chk_ausgefallen.CheckStateChanged += new System.EventHandler(this.chk_ausgefallen_CheckStateChanged);
            // 
            // chk_trocken
            // 
            this.chk_trocken.AutoSize = true;
            this.chk_trocken.Location = new System.Drawing.Point(16, 88);
            this.chk_trocken.Name = "chk_trocken";
            this.chk_trocken.Size = new System.Drawing.Size(109, 17);
            this.chk_trocken.TabIndex = 7;
            this.chk_trocken.Text = "Trockener Abend";
            this.chk_trocken.UseVisualStyleBackColor = true;
            this.chk_trocken.CheckedChanged += new System.EventHandler(this.chk_trocken_CheckedChanged);
            // 
            // PartyPlaner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(161, 150);
            this.Controls.Add(this.chk_trocken);
            this.Controls.Add(this.chk_ausgefallen);
            this.Controls.Add(this.lbl_KostenFeld);
            this.Controls.Add(this.lbl_Kosten);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lbl_PersAnz);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PartyPlaner";
            this.ShowIcon = false;
            this.Text = "Party-Planer";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_PersAnz;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lbl_Kosten;
        private System.Windows.Forms.Label lbl_KostenFeld;
        private System.Windows.Forms.CheckBox chk_ausgefallen;
        private System.Windows.Forms.CheckBox chk_trocken;
    }
}

