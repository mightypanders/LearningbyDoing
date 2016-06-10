namespace WindowsFormsApplication1
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
            this.btn_Laden = new System.Windows.Forms.Button();
            this.txt_left = new System.Windows.Forms.TextBox();
            this.txt_right = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Laden
            // 
            this.btn_Laden.Location = new System.Drawing.Point(13, 13);
            this.btn_Laden.Name = "btn_Laden";
            this.btn_Laden.Size = new System.Drawing.Size(75, 23);
            this.btn_Laden.TabIndex = 0;
            this.btn_Laden.Text = "Laden";
            this.btn_Laden.UseVisualStyleBackColor = true;
            this.btn_Laden.Click += new System.EventHandler(this.btn_Laden_Click);
            // 
            // txt_left
            // 
            this.txt_left.Location = new System.Drawing.Point(13, 77);
            this.txt_left.Multiline = true;
            this.txt_left.Name = "txt_left";
            this.txt_left.Size = new System.Drawing.Size(164, 223);
            this.txt_left.TabIndex = 1;
            // 
            // txt_right
            // 
            this.txt_right.Location = new System.Drawing.Point(184, 77);
            this.txt_right.Multiline = true;
            this.txt_right.Name = "txt_right";
            this.txt_right.Size = new System.Drawing.Size(168, 223);
            this.txt_right.TabIndex = 2;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 48);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(339, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(102, 12);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 4;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 312);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.txt_right);
            this.Controls.Add(this.txt_left);
            this.Controls.Add(this.btn_Laden);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Laden;
        private System.Windows.Forms.TextBox txt_left;
        private System.Windows.Forms.TextBox txt_right;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btn_cancel;
    }
}

