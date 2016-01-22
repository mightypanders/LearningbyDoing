namespace Rennbahn
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
            this.pb_hintergrund = new System.Windows.Forms.PictureBox();
            this.gB_wettbuero = new System.Windows.Forms.GroupBox();
            this.lbl_wette3 = new System.Windows.Forms.Label();
            this.lbl_wette2 = new System.Windows.Forms.Label();
            this.lbl_wette1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Rennen = new System.Windows.Forms.Button();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btn_wettet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rb_3 = new System.Windows.Forms.RadioButton();
            this.rb_2 = new System.Windows.Forms.RadioButton();
            this.rb_1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblH1Pos = new System.Windows.Forms.Label();
            this.lblH2Pos = new System.Windows.Forms.Label();
            this.lblH3Pos = new System.Windows.Forms.Label();
            this.lblH4Pos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_hintergrund)).BeginInit();
            this.gB_wettbuero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_hintergrund
            // 
            this.pb_hintergrund.Image = global::Rennbahn.Properties.Resources.racetrack;
            this.pb_hintergrund.Location = new System.Drawing.Point(12, 12);
            this.pb_hintergrund.Name = "pb_hintergrund";
            this.pb_hintergrund.Size = new System.Drawing.Size(743, 266);
            this.pb_hintergrund.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_hintergrund.TabIndex = 0;
            this.pb_hintergrund.TabStop = false;
            // 
            // gB_wettbuero
            // 
            this.gB_wettbuero.Controls.Add(this.lblH4Pos);
            this.gB_wettbuero.Controls.Add(this.lblH3Pos);
            this.gB_wettbuero.Controls.Add(this.lblH2Pos);
            this.gB_wettbuero.Controls.Add(this.lblH1Pos);
            this.gB_wettbuero.Controls.Add(this.lbl_wette3);
            this.gB_wettbuero.Controls.Add(this.lbl_wette2);
            this.gB_wettbuero.Controls.Add(this.lbl_wette1);
            this.gB_wettbuero.Controls.Add(this.label4);
            this.gB_wettbuero.Controls.Add(this.btn_Rennen);
            this.gB_wettbuero.Controls.Add(this.numericUpDown2);
            this.gB_wettbuero.Controls.Add(this.label3);
            this.gB_wettbuero.Controls.Add(this.numericUpDown1);
            this.gB_wettbuero.Controls.Add(this.btn_wettet);
            this.gB_wettbuero.Controls.Add(this.label2);
            this.gB_wettbuero.Controls.Add(this.rb_3);
            this.gB_wettbuero.Controls.Add(this.rb_2);
            this.gB_wettbuero.Controls.Add(this.rb_1);
            this.gB_wettbuero.Controls.Add(this.label1);
            this.gB_wettbuero.Location = new System.Drawing.Point(13, 285);
            this.gB_wettbuero.Name = "gB_wettbuero";
            this.gB_wettbuero.Size = new System.Drawing.Size(742, 172);
            this.gB_wettbuero.TabIndex = 1;
            this.gB_wettbuero.TabStop = false;
            this.gB_wettbuero.Text = "Wettbüro";
            // 
            // lbl_wette3
            // 
            this.lbl_wette3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_wette3.Location = new System.Drawing.Point(336, 101);
            this.lbl_wette3.Name = "lbl_wette3";
            this.lbl_wette3.Size = new System.Drawing.Size(205, 23);
            this.lbl_wette3.TabIndex = 13;
            this.lbl_wette3.Text = "Jans Wette";
            this.lbl_wette3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_wette2
            // 
            this.lbl_wette2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_wette2.Location = new System.Drawing.Point(336, 77);
            this.lbl_wette2.Name = "lbl_wette2";
            this.lbl_wette2.Size = new System.Drawing.Size(205, 23);
            this.lbl_wette2.TabIndex = 12;
            this.lbl_wette2.Text = "Toms Wette";
            this.lbl_wette2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_wette1
            // 
            this.lbl_wette1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_wette1.Location = new System.Drawing.Point(336, 53);
            this.lbl_wette1.Name = "lbl_wette1";
            this.lbl_wette1.Size = new System.Drawing.Size(205, 23);
            this.lbl_wette1.TabIndex = 11;
            this.lbl_wette1.Text = "Tims Wette";
            this.lbl_wette1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(336, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Wetten";
            // 
            // btn_Rennen
            // 
            this.btn_Rennen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btn_Rennen.Location = new System.Drawing.Point(573, 53);
            this.btn_Rennen.Name = "btn_Rennen";
            this.btn_Rennen.Size = new System.Drawing.Size(124, 71);
            this.btn_Rennen.TabIndex = 9;
            this.btn_Rennen.Text = "Rennen!";
            this.btn_Rennen.UseVisualStyleBackColor = true;
            this.btn_Rennen.Click += new System.EventHandler(this.btn_Rennen_Click);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(361, 132);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(58, 20);
            this.numericUpDown2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "€ auf Hund Nummer";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(170, 132);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(62, 20);
            this.numericUpDown1.TabIndex = 6;
            // 
            // btn_wettet
            // 
            this.btn_wettet.Location = new System.Drawing.Point(73, 129);
            this.btn_wettet.Name = "btn_wettet";
            this.btn_wettet.Size = new System.Drawing.Size(75, 23);
            this.btn_wettet.TabIndex = 5;
            this.btn_wettet.Text = "wettet";
            this.btn_wettet.UseVisualStyleBackColor = true;
            this.btn_wettet.Click += new System.EventHandler(this.btn_wettet_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "wetter";
            // 
            // rb_3
            // 
            this.rb_3.AutoSize = true;
            this.rb_3.Location = new System.Drawing.Point(7, 101);
            this.rb_3.Name = "rb_3";
            this.rb_3.Size = new System.Drawing.Size(42, 17);
            this.rb_3.TabIndex = 3;
            this.rb_3.TabStop = true;
            this.rb_3.Tag = "2";
            this.rb_3.Text = "Jan";
            this.rb_3.UseVisualStyleBackColor = true;
            this.rb_3.CheckedChanged += new System.EventHandler(this.RBCheck);
            // 
            // rb_2
            // 
            this.rb_2.AutoSize = true;
            this.rb_2.Location = new System.Drawing.Point(7, 77);
            this.rb_2.Name = "rb_2";
            this.rb_2.Size = new System.Drawing.Size(46, 17);
            this.rb_2.TabIndex = 2;
            this.rb_2.TabStop = true;
            this.rb_2.Tag = "1";
            this.rb_2.Text = "Tom";
            this.rb_2.UseVisualStyleBackColor = true;
            this.rb_2.CheckedChanged += new System.EventHandler(this.RBCheck);
            // 
            // rb_1
            // 
            this.rb_1.AutoSize = true;
            this.rb_1.Location = new System.Drawing.Point(7, 53);
            this.rb_1.Name = "rb_1";
            this.rb_1.Size = new System.Drawing.Size(42, 17);
            this.rb_1.TabIndex = 1;
            this.rb_1.TabStop = true;
            this.rb_1.Tag = "0";
            this.rb_1.Text = "Tim";
            this.rb_1.UseVisualStyleBackColor = true;
            this.rb_1.CheckedChanged += new System.EventHandler(this.RBCheck);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mindestwetteinsatz 5€";
            // 
            // lblH1Pos
            // 
            this.lblH1Pos.AutoSize = true;
            this.lblH1Pos.Location = new System.Drawing.Point(173, 55);
            this.lblH1Pos.Name = "lblH1Pos";
            this.lblH1Pos.Size = new System.Drawing.Size(35, 13);
            this.lblH1Pos.TabIndex = 14;
            this.lblH1Pos.Text = "label5";
            // 
            // lblH2Pos
            // 
            this.lblH2Pos.AutoSize = true;
            this.lblH2Pos.Location = new System.Drawing.Point(173, 68);
            this.lblH2Pos.Name = "lblH2Pos";
            this.lblH2Pos.Size = new System.Drawing.Size(35, 13);
            this.lblH2Pos.TabIndex = 15;
            this.lblH2Pos.Text = "label6";
            // 
            // lblH3Pos
            // 
            this.lblH3Pos.AutoSize = true;
            this.lblH3Pos.Location = new System.Drawing.Point(173, 82);
            this.lblH3Pos.Name = "lblH3Pos";
            this.lblH3Pos.Size = new System.Drawing.Size(35, 13);
            this.lblH3Pos.TabIndex = 16;
            this.lblH3Pos.Text = "label7";
            // 
            // lblH4Pos
            // 
            this.lblH4Pos.AutoSize = true;
            this.lblH4Pos.Location = new System.Drawing.Point(173, 95);
            this.lblH4Pos.Name = "lblH4Pos";
            this.lblH4Pos.Size = new System.Drawing.Size(35, 13);
            this.lblH4Pos.TabIndex = 17;
            this.lblH4Pos.Text = "label8";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 469);
            this.Controls.Add(this.gB_wettbuero);
            this.Controls.Add(this.pb_hintergrund);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pb_hintergrund)).EndInit();
            this.gB_wettbuero.ResumeLayout(false);
            this.gB_wettbuero.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_hintergrund;
        private System.Windows.Forms.GroupBox gB_wettbuero;
        private System.Windows.Forms.Label lbl_wette3;
        private System.Windows.Forms.Label lbl_wette2;
        private System.Windows.Forms.Label lbl_wette1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Rennen;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btn_wettet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rb_3;
        private System.Windows.Forms.RadioButton rb_2;
        private System.Windows.Forms.RadioButton rb_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblH3Pos;
        private System.Windows.Forms.Label lblH2Pos;
        private System.Windows.Forms.Label lblH1Pos;
        private System.Windows.Forms.Label lblH4Pos;
    }
}

