namespace Tippspiel
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
            this.components = new System.ComponentModel.Container();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbl_richtig = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_falsch = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_gesamt = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_trefferquote = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_schwierigkeit = new System.Windows.Forms.ToolStripStatusLabel();
            this.pgb_schwierigkeit = new System.Windows.Forms.ToolStripProgressBar();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 108;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Margin = new System.Windows.Forms.Padding(28, 25, 28, 25);
            this.listBox1.MultiColumn = true;
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(945, 126);
            this.listBox1.TabIndex = 0;
            this.listBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBox1_KeyDown);
            // 
            // timer1
            // 
            this.timer1.Interval = 800;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_richtig,
            this.lbl_falsch,
            this.lbl_gesamt,
            this.lbl_trefferquote,
            this.lbl_schwierigkeit,
            this.pgb_schwierigkeit});
            this.statusStrip1.Location = new System.Drawing.Point(0, 104);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(945, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbl_richtig
            // 
            this.lbl_richtig.Name = "lbl_richtig";
            this.lbl_richtig.Size = new System.Drawing.Size(56, 17);
            this.lbl_richtig.Text = "Richtig: 0";
            // 
            // lbl_falsch
            // 
            this.lbl_falsch.Name = "lbl_falsch";
            this.lbl_falsch.Size = new System.Drawing.Size(52, 17);
            this.lbl_falsch.Text = "Falsch: 0";
            // 
            // lbl_gesamt
            // 
            this.lbl_gesamt.Name = "lbl_gesamt";
            this.lbl_gesamt.Size = new System.Drawing.Size(59, 17);
            this.lbl_gesamt.Text = "Gesamt: 0";
            // 
            // lbl_trefferquote
            // 
            this.lbl_trefferquote.Name = "lbl_trefferquote";
            this.lbl_trefferquote.Size = new System.Drawing.Size(95, 17);
            this.lbl_trefferquote.Text = "Trefferquote: 0%";
            // 
            // lbl_schwierigkeit
            // 
            this.lbl_schwierigkeit.Name = "lbl_schwierigkeit";
            this.lbl_schwierigkeit.Size = new System.Drawing.Size(535, 17);
            this.lbl_schwierigkeit.Spring = true;
            this.lbl_schwierigkeit.Text = "Schwierigkeit";
            this.lbl_schwierigkeit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pgb_schwierigkeit
            // 
            this.pgb_schwierigkeit.Maximum = 800;
            this.pgb_schwierigkeit.Name = "pgb_schwierigkeit";
            this.pgb_schwierigkeit.Size = new System.Drawing.Size(100, 16);
            this.pgb_schwierigkeit.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(56F, 108F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 126);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.listBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(28, 25, 28, 25);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_richtig;
        private System.Windows.Forms.ToolStripStatusLabel lbl_falsch;
        private System.Windows.Forms.ToolStripStatusLabel lbl_gesamt;
        private System.Windows.Forms.ToolStripStatusLabel lbl_trefferquote;
        private System.Windows.Forms.ToolStripStatusLabel lbl_schwierigkeit;
        private System.Windows.Forms.ToolStripProgressBar pgb_schwierigkeit;
    }
}

