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
            ((System.ComponentModel.ISupportInitialize)(this.pb_hintergrund)).BeginInit();
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 469);
            this.Controls.Add(this.pb_hintergrund);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pb_hintergrund)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_hintergrund;
    }
}

