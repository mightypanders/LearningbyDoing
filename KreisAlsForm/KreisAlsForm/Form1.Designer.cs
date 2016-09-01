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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.txt_SeiteBinput = new System.Windows.Forms.Label();
            this.txt_Binput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_Radinput
            // 
            this.txt_Radinput.Location = new System.Drawing.Point(41, 78);
            this.txt_Radinput.Name = "txt_Radinput";
            this.txt_Radinput.Size = new System.Drawing.Size(100, 20);
            this.txt_Radinput.TabIndex = 0;
            this.txt_Radinput.TextChanged += new System.EventHandler(this.txt_Radinput_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Radius eingeben";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fläche:";
            // 
            // txt_FlOutput
            // 
            this.txt_FlOutput.Location = new System.Drawing.Point(41, 117);
            this.txt_FlOutput.Name = "txt_FlOutput";
            this.txt_FlOutput.Size = new System.Drawing.Size(100, 20);
            this.txt_FlOutput.TabIndex = 3;
            // 
            // txt_UmfOut
            // 
            this.txt_UmfOut.Location = new System.Drawing.Point(156, 117);
            this.txt_UmfOut.Name = "txt_UmfOut";
            this.txt_UmfOut.Size = new System.Drawing.Size(100, 20);
            this.txt_UmfOut.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Umfang:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(44, 13);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(48, 17);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Kreis";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(159, 12);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(72, 17);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.Text = "Rechteck";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // txt_SeiteBinput
            // 
            this.txt_SeiteBinput.AutoSize = true;
            this.txt_SeiteBinput.Location = new System.Drawing.Point(156, 59);
            this.txt_SeiteBinput.Name = "txt_SeiteBinput";
            this.txt_SeiteBinput.Size = new System.Drawing.Size(91, 13);
            this.txt_SeiteBinput.TabIndex = 9;
            this.txt_SeiteBinput.Text = "Seite B eingeben:";
            this.txt_SeiteBinput.Visible = false;
            // 
            // txt_Binput
            // 
            this.txt_Binput.Location = new System.Drawing.Point(156, 78);
            this.txt_Binput.Name = "txt_Binput";
            this.txt_Binput.Size = new System.Drawing.Size(100, 20);
            this.txt_Binput.TabIndex = 8;
            this.txt_Binput.Visible = false;
            this.txt_Binput.TextChanged += new System.EventHandler(this.txt_Binput_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 156);
            this.Controls.Add(this.txt_SeiteBinput);
            this.Controls.Add(this.txt_Binput);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
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
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label txt_SeiteBinput;
        private System.Windows.Forms.TextBox txt_Binput;
    }
}

