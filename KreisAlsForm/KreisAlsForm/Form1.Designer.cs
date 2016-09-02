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
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.txt_Oberfl = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Volumen = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_Radinput
            // 
            this.txt_Radinput.Location = new System.Drawing.Point(100, 35);
            this.txt_Radinput.Name = "txt_Radinput";
            this.txt_Radinput.Size = new System.Drawing.Size(100, 20);
            this.txt_Radinput.TabIndex = 0;
            this.txt_Radinput.TextChanged += new System.EventHandler(this.txt_InputTextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Radius eingeben";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fläche:";
            // 
            // txt_FlOutput
            // 
            this.txt_FlOutput.Location = new System.Drawing.Point(100, 74);
            this.txt_FlOutput.Name = "txt_FlOutput";
            this.txt_FlOutput.Size = new System.Drawing.Size(100, 20);
            this.txt_FlOutput.TabIndex = 3;
            // 
            // txt_UmfOut
            // 
            this.txt_UmfOut.Location = new System.Drawing.Point(215, 74);
            this.txt_UmfOut.Name = "txt_UmfOut";
            this.txt_UmfOut.Size = new System.Drawing.Size(100, 20);
            this.txt_UmfOut.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Umfang:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(12, 12);
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
            this.radioButton2.Location = new System.Drawing.Point(12, 35);
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
            this.txt_SeiteBinput.Location = new System.Drawing.Point(215, 16);
            this.txt_SeiteBinput.Name = "txt_SeiteBinput";
            this.txt_SeiteBinput.Size = new System.Drawing.Size(91, 13);
            this.txt_SeiteBinput.TabIndex = 9;
            this.txt_SeiteBinput.Text = "Seite B eingeben:";
            this.txt_SeiteBinput.Visible = false;
            // 
            // txt_Binput
            // 
            this.txt_Binput.Location = new System.Drawing.Point(215, 35);
            this.txt_Binput.Name = "txt_Binput";
            this.txt_Binput.Size = new System.Drawing.Size(100, 20);
            this.txt_Binput.TabIndex = 8;
            this.txt_Binput.Visible = false;
            this.txt_Binput.TextChanged += new System.EventHandler(this.txt_InputTextChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(12, 59);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(52, 17);
            this.radioButton3.TabIndex = 10;
            this.radioButton3.Text = "Kugel";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // txt_Oberfl
            // 
            this.txt_Oberfl.Location = new System.Drawing.Point(100, 115);
            this.txt_Oberfl.Name = "txt_Oberfl";
            this.txt_Oberfl.Size = new System.Drawing.Size(100, 20);
            this.txt_Oberfl.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Oberfläche:";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(12, 82);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(52, 17);
            this.radioButton4.TabIndex = 13;
            this.radioButton4.Text = "Kegel";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(12, 105);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(62, 17);
            this.radioButton5.TabIndex = 14;
            this.radioButton5.Text = "Zylinder";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(215, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Volumen:";
            // 
            // txt_Volumen
            // 
            this.txt_Volumen.Location = new System.Drawing.Point(215, 115);
            this.txt_Volumen.Name = "txt_Volumen";
            this.txt_Volumen.Size = new System.Drawing.Size(100, 20);
            this.txt_Volumen.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 156);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Volumen);
            this.Controls.Add(this.radioButton5);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Oberfl);
            this.Controls.Add(this.radioButton3);
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
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.TextBox txt_Oberfl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Volumen;
    }
}

