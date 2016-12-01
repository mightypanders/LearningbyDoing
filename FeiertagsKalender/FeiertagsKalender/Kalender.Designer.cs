namespace FeiertagsKalender
{
    partial class Kalender
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
            this.btn_Wochentag = new System.Windows.Forms.Button();
            this.UD_Tag = new System.Windows.Forms.NumericUpDown();
            this.UD_Jahr = new System.Windows.Forms.NumericUpDown();
            this.UD_Monat = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_wochentag = new System.Windows.Forms.Label();
            this.btn_CheckJahr = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Schaltjahr = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UD_Tag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UD_Jahr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UD_Monat)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Wochentag
            // 
            this.btn_Wochentag.Location = new System.Drawing.Point(173, 27);
            this.btn_Wochentag.Name = "btn_Wochentag";
            this.btn_Wochentag.Size = new System.Drawing.Size(112, 30);
            this.btn_Wochentag.TabIndex = 4;
            this.btn_Wochentag.Text = "Ermittle Wochentag";
            this.btn_Wochentag.UseVisualStyleBackColor = true;
            this.btn_Wochentag.Click += new System.EventHandler(this.button1_Click);
            // 
            // UD_Tag
            // 
            this.UD_Tag.Location = new System.Drawing.Point(26, 34);
            this.UD_Tag.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.UD_Tag.Name = "UD_Tag";
            this.UD_Tag.Size = new System.Drawing.Size(33, 20);
            this.UD_Tag.TabIndex = 1;
            // 
            // UD_Jahr
            // 
            this.UD_Jahr.Location = new System.Drawing.Point(112, 34);
            this.UD_Jahr.Maximum = new decimal(new int[] {
            2170,
            0,
            0,
            0});
            this.UD_Jahr.Name = "UD_Jahr";
            this.UD_Jahr.Size = new System.Drawing.Size(55, 20);
            this.UD_Jahr.TabIndex = 3;
            // 
            // UD_Monat
            // 
            this.UD_Monat.Location = new System.Drawing.Point(65, 34);
            this.UD_Monat.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.UD_Monat.Name = "UD_Monat";
            this.UD_Monat.Size = new System.Drawing.Size(41, 20);
            this.UD_Monat.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Wochentag:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_wochentag
            // 
            this.lbl_wochentag.AutoSize = true;
            this.lbl_wochentag.Location = new System.Drawing.Point(98, 54);
            this.lbl_wochentag.Name = "lbl_wochentag";
            this.lbl_wochentag.Size = new System.Drawing.Size(0, 13);
            this.lbl_wochentag.TabIndex = 8;
            // 
            // btn_CheckJahr
            // 
            this.btn_CheckJahr.Location = new System.Drawing.Point(173, 63);
            this.btn_CheckJahr.Name = "btn_CheckJahr";
            this.btn_CheckJahr.Size = new System.Drawing.Size(112, 30);
            this.btn_CheckJahr.TabIndex = 11;
            this.btn_CheckJahr.Text = "Ermittle Schaltjahr";
            this.btn_CheckJahr.UseVisualStyleBackColor = true;
            this.btn_CheckJahr.Click += new System.EventHandler(this.btn_CheckJahr_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Schaltjahr:";
            // 
            // lbl_Schaltjahr
            // 
            this.lbl_Schaltjahr.AutoSize = true;
            this.lbl_Schaltjahr.Location = new System.Drawing.Point(235, 9);
            this.lbl_Schaltjahr.Name = "lbl_Schaltjahr";
            this.lbl_Schaltjahr.Size = new System.Drawing.Size(0, 13);
            this.lbl_Schaltjahr.TabIndex = 13;
            // 
            // Kalender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 261);
            this.Controls.Add(this.lbl_Schaltjahr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_CheckJahr);
            this.Controls.Add(this.lbl_wochentag);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UD_Monat);
            this.Controls.Add(this.UD_Jahr);
            this.Controls.Add(this.UD_Tag);
            this.Controls.Add(this.btn_Wochentag);
            this.Name = "Kalender";
            this.Text = "Kalender";
            ((System.ComponentModel.ISupportInitialize)(this.UD_Tag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UD_Jahr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UD_Monat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Wochentag;
        private System.Windows.Forms.NumericUpDown UD_Tag;
        private System.Windows.Forms.NumericUpDown UD_Jahr;
        private System.Windows.Forms.NumericUpDown UD_Monat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_wochentag;
        private System.Windows.Forms.Button btn_CheckJahr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Schaltjahr;
    }
}

