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
            this.UD_Tag = new System.Windows.Forms.NumericUpDown();
            this.UD_Jahr = new System.Windows.Forms.NumericUpDown();
            this.UD_Monat = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_wochentag = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Schaltjahr = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_showMonat = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.UD_Tag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UD_Jahr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UD_Monat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            // 
            // lbl_wochentag
            // 
            this.lbl_wochentag.AutoSize = true;
            this.lbl_wochentag.Location = new System.Drawing.Point(98, 54);
            this.lbl_wochentag.Name = "lbl_wochentag";
            this.lbl_wochentag.Size = new System.Drawing.Size(0, 13);
            this.lbl_wochentag.TabIndex = 8;
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(12, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(281, 244);
            this.dataGridView1.TabIndex = 14;
            // 
            // btn_showMonat
            // 
            this.btn_showMonat.Location = new System.Drawing.Point(175, 34);
            this.btn_showMonat.Name = "btn_showMonat";
            this.btn_showMonat.Size = new System.Drawing.Size(75, 23);
            this.btn_showMonat.TabIndex = 15;
            this.btn_showMonat.Text = "Zeige Monat";
            this.btn_showMonat.UseVisualStyleBackColor = true;
            this.btn_showMonat.Click += new System.EventHandler(this.showMonat);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column1.HeaderText = "M";
            this.Column1.Name = "Column1";
            this.Column1.Width = 41;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column2.HeaderText = "D";
            this.Column2.Name = "Column2";
            this.Column2.Width = 40;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column3.HeaderText = "M";
            this.Column3.Name = "Column3";
            this.Column3.Width = 41;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column4.HeaderText = "D";
            this.Column4.Name = "Column4";
            this.Column4.Width = 40;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column5.HeaderText = "F";
            this.Column5.Name = "Column5";
            this.Column5.Width = 38;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column6.HeaderText = "S";
            this.Column6.Name = "Column6";
            this.Column6.Width = 39;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column7.HeaderText = "S";
            this.Column7.Name = "Column7";
            this.Column7.Width = 39;
            // 
            // Kalender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 317);
            this.Controls.Add(this.btn_showMonat);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_Schaltjahr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_wochentag);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UD_Monat);
            this.Controls.Add(this.UD_Jahr);
            this.Controls.Add(this.UD_Tag);
            this.Name = "Kalender";
            this.Text = "Kalender";
            ((System.ComponentModel.ISupportInitialize)(this.UD_Tag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UD_Jahr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UD_Monat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown UD_Tag;
        private System.Windows.Forms.NumericUpDown UD_Jahr;
        private System.Windows.Forms.NumericUpDown UD_Monat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_wochentag;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Schaltjahr;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_showMonat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}

