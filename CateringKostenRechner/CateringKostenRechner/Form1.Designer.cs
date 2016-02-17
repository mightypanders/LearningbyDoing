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
            this.lbl_kosten_abendessen = new System.Windows.Forms.Label();
            this.chk_ausgefallen_abendessen = new System.Windows.Forms.CheckBox();
            this.chk_trocken_abendessen = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txt_kuchen_geburstag = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chk_exklusiv_geburtstag = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.lbl_kosten_geburtstag = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_PersAnz
            // 
            this.lbl_PersAnz.AutoSize = true;
            this.lbl_PersAnz.Location = new System.Drawing.Point(3, 4);
            this.lbl_PersAnz.Name = "lbl_PersAnz";
            this.lbl_PersAnz.Size = new System.Drawing.Size(83, 13);
            this.lbl_PersAnz.TabIndex = 0;
            this.lbl_PersAnz.Text = "Personenanzahl";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(3, 21);
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
            this.lbl_Kosten.Location = new System.Drawing.Point(3, 120);
            this.lbl_Kosten.Name = "lbl_Kosten";
            this.lbl_Kosten.Size = new System.Drawing.Size(46, 13);
            this.lbl_Kosten.TabIndex = 4;
            this.lbl_Kosten.Text = "Kosten";
            // 
            // lbl_kosten_abendessen
            // 
            this.lbl_kosten_abendessen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_kosten_abendessen.Location = new System.Drawing.Point(51, 119);
            this.lbl_kosten_abendessen.Name = "lbl_kosten_abendessen";
            this.lbl_kosten_abendessen.Size = new System.Drawing.Size(72, 22);
            this.lbl_kosten_abendessen.TabIndex = 5;
            // 
            // chk_ausgefallen_abendessen
            // 
            this.chk_ausgefallen_abendessen.AutoSize = true;
            this.chk_ausgefallen_abendessen.Checked = true;
            this.chk_ausgefallen_abendessen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_ausgefallen_abendessen.Location = new System.Drawing.Point(6, 56);
            this.chk_ausgefallen_abendessen.Name = "chk_ausgefallen_abendessen";
            this.chk_ausgefallen_abendessen.Size = new System.Drawing.Size(124, 17);
            this.chk_ausgefallen_abendessen.TabIndex = 6;
            this.chk_ausgefallen_abendessen.Text = "Ausgefallener Abend";
            this.chk_ausgefallen_abendessen.UseVisualStyleBackColor = true;
            this.chk_ausgefallen_abendessen.CheckStateChanged += new System.EventHandler(this.chk_ausgefallen_CheckStateChanged);
            // 
            // chk_trocken_abendessen
            // 
            this.chk_trocken_abendessen.AutoSize = true;
            this.chk_trocken_abendessen.Location = new System.Drawing.Point(6, 79);
            this.chk_trocken_abendessen.Name = "chk_trocken_abendessen";
            this.chk_trocken_abendessen.Size = new System.Drawing.Size(109, 17);
            this.chk_trocken_abendessen.TabIndex = 7;
            this.chk_trocken_abendessen.Text = "Trockener Abend";
            this.chk_trocken_abendessen.UseVisualStyleBackColor = true;
            this.chk_trocken_abendessen.CheckedChanged += new System.EventHandler(this.chk_trocken_CheckedChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(184, 175);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chk_ausgefallen_abendessen);
            this.tabPage1.Controls.Add(this.chk_trocken_abendessen);
            this.tabPage1.Controls.Add(this.lbl_PersAnz);
            this.tabPage1.Controls.Add(this.numericUpDown1);
            this.tabPage1.Controls.Add(this.lbl_kosten_abendessen);
            this.tabPage1.Controls.Add(this.lbl_Kosten);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(176, 146);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Abendessen";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txt_kuchen_geburstag);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.chk_exklusiv_geburtstag);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.numericUpDown2);
            this.tabPage2.Controls.Add(this.lbl_kosten_geburtstag);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(176, 146);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Geburtstagsfeier";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txt_kuchen_geburstag
            // 
            this.txt_kuchen_geburstag.Location = new System.Drawing.Point(6, 97);
            this.txt_kuchen_geburstag.Name = "txt_kuchen_geburstag";
            this.txt_kuchen_geburstag.Size = new System.Drawing.Size(162, 20);
            this.txt_kuchen_geburstag.TabIndex = 14;
            this.txt_kuchen_geburstag.TextChanged += new System.EventHandler(this.txt_kuchen_geburstag_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Text auf dem Kuchen";
            // 
            // chk_exklusiv_geburtstag
            // 
            this.chk_exklusiv_geburtstag.AutoSize = true;
            this.chk_exklusiv_geburtstag.Checked = true;
            this.chk_exklusiv_geburtstag.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_exklusiv_geburtstag.Location = new System.Drawing.Point(6, 56);
            this.chk_exklusiv_geburtstag.Name = "chk_exklusiv_geburtstag";
            this.chk_exklusiv_geburtstag.Size = new System.Drawing.Size(108, 17);
            this.chk_exklusiv_geburtstag.TabIndex = 12;
            this.chk_exklusiv_geburtstag.Text = "Exklusiver Abend";
            this.chk_exklusiv_geburtstag.UseVisualStyleBackColor = true;
            this.chk_exklusiv_geburtstag.CheckedChanged += new System.EventHandler(this.chk_exklusiv_geburtstag_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Personenanzahl";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(3, 21);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 9;
            this.numericUpDown2.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // lbl_kosten_geburtstag
            // 
            this.lbl_kosten_geburtstag.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_kosten_geburtstag.Location = new System.Drawing.Point(51, 119);
            this.lbl_kosten_geburtstag.Name = "lbl_kosten_geburtstag";
            this.lbl_kosten_geburtstag.Size = new System.Drawing.Size(72, 22);
            this.lbl_kosten_geburtstag.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(3, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Kosten";
            // 
            // PartyPlaner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 175);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PartyPlaner";
            this.ShowIcon = false;
            this.Text = "Party-Planer";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_PersAnz;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lbl_Kosten;
        private System.Windows.Forms.Label lbl_kosten_abendessen;
        private System.Windows.Forms.CheckBox chk_ausgefallen_abendessen;
        private System.Windows.Forms.CheckBox chk_trocken_abendessen;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txt_kuchen_geburstag;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chk_exklusiv_geburtstag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label lbl_kosten_geburtstag;
        private System.Windows.Forms.Label label3;
    }
}

