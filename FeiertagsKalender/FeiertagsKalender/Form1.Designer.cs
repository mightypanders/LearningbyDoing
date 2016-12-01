namespace FeiertagsKalender
{
    partial class Form1
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
            this.UP_Tag = new System.Windows.Forms.NumericUpDown();
            this.UD_Jahr = new System.Windows.Forms.NumericUpDown();
            this.UD_Monat = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_wochentag = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UP_Tag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UD_Jahr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UD_Monat)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Wochentag
            // 
            this.btn_Wochentag.Location = new System.Drawing.Point(173, 27);
            this.btn_Wochentag.Name = "btn_Wochentag";
            this.btn_Wochentag.Size = new System.Drawing.Size(112, 23);
            this.btn_Wochentag.TabIndex = 4;
            this.btn_Wochentag.Text = "Ermittle Wochentag";
            this.btn_Wochentag.UseVisualStyleBackColor = true;
            this.btn_Wochentag.Click += new System.EventHandler(this.button1_Click);
            // 
            // UP_Tag
            // 
            this.UP_Tag.Location = new System.Drawing.Point(26, 27);
            this.UP_Tag.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.UP_Tag.Name = "UP_Tag";
            this.UP_Tag.Size = new System.Drawing.Size(33, 20);
            this.UP_Tag.TabIndex = 1;
            // 
            // UD_Jahr
            // 
            this.UD_Jahr.Location = new System.Drawing.Point(112, 27);
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
            this.UD_Monat.Location = new System.Drawing.Point(65, 27);
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
            this.label1.Location = new System.Drawing.Point(26, 54);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 261);
            this.Controls.Add(this.lbl_wochentag);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UD_Monat);
            this.Controls.Add(this.UD_Jahr);
            this.Controls.Add(this.UP_Tag);
            this.Controls.Add(this.btn_Wochentag);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.UP_Tag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UD_Jahr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UD_Monat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Wochentag;
        private System.Windows.Forms.NumericUpDown UP_Tag;
        private System.Windows.Forms.NumericUpDown UD_Jahr;
        private System.Windows.Forms.NumericUpDown UD_Monat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_wochentag;
    }
}

