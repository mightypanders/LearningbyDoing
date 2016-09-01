namespace KreisAlsForm
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
            this.txt_Radinput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_FlOutput = new System.Windows.Forms.TextBox();
            this.txt_UmfOut = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Radinput
            // 
            this.txt_Radinput.Location = new System.Drawing.Point(41, 55);
            this.txt_Radinput.Name = "txt_Radinput";
            this.txt_Radinput.Size = new System.Drawing.Size(100, 20);
            this.txt_Radinput.TabIndex = 0;
            this.txt_Radinput.TextChanged += new System.EventHandler(this.txt_Radinput_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Radius eingeben";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fläche:";
            // 
            // txt_FlOutput
            // 
            this.txt_FlOutput.Location = new System.Drawing.Point(41, 94);
            this.txt_FlOutput.Name = "txt_FlOutput";
            this.txt_FlOutput.Size = new System.Drawing.Size(100, 20);
            this.txt_FlOutput.TabIndex = 3;
            // 
            // txt_UmfOut
            // 
            this.txt_UmfOut.Location = new System.Drawing.Point(41, 133);
            this.txt_UmfOut.Name = "txt_UmfOut";
            this.txt_UmfOut.Size = new System.Drawing.Size(100, 20);
            this.txt_UmfOut.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Umfang:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(183, 201);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_UmfOut);
            this.Controls.Add(this.txt_FlOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Radinput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Radinput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_FlOutput;
        private System.Windows.Forms.TextBox txt_UmfOut;
        private System.Windows.Forms.Label label3;
    }
}

