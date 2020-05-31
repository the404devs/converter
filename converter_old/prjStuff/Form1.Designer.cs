namespace prjStuff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnItoC = new System.Windows.Forms.Button();
            this.btnFtoC = new System.Windows.Forms.Button();
            this.btnYtoM = new System.Windows.Forms.Button();
            this.btnMitoK = new System.Windows.Forms.Button();
            this.btnCtoI = new System.Windows.Forms.Button();
            this.btnCtoF = new System.Windows.Forms.Button();
            this.btnMtoY = new System.Windows.Forms.Button();
            this.btnKtoMi = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabLength = new System.Windows.Forms.TabPage();
            this.tabTemp = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabLength.SuspendLayout();
            this.tabTemp.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnItoC
            // 
            this.btnItoC.Location = new System.Drawing.Point(8, 63);
            this.btnItoC.Name = "btnItoC";
            this.btnItoC.Size = new System.Drawing.Size(176, 34);
            this.btnItoC.TabIndex = 0;
            this.btnItoC.Text = "Inches to Centimetres";
            this.btnItoC.UseVisualStyleBackColor = true;
            this.btnItoC.Click += new System.EventHandler(this.btnItoC_Click);
            // 
            // btnFtoC
            // 
            this.btnFtoC.Location = new System.Drawing.Point(8, 103);
            this.btnFtoC.Name = "btnFtoC";
            this.btnFtoC.Size = new System.Drawing.Size(176, 34);
            this.btnFtoC.TabIndex = 1;
            this.btnFtoC.Text = "Feet to Centimetres";
            this.btnFtoC.UseVisualStyleBackColor = true;
            this.btnFtoC.Click += new System.EventHandler(this.btnFtoC_Click);
            // 
            // btnYtoM
            // 
            this.btnYtoM.Location = new System.Drawing.Point(8, 143);
            this.btnYtoM.Name = "btnYtoM";
            this.btnYtoM.Size = new System.Drawing.Size(176, 34);
            this.btnYtoM.TabIndex = 2;
            this.btnYtoM.Text = "Yards to Metres";
            this.btnYtoM.UseVisualStyleBackColor = true;
            this.btnYtoM.Click += new System.EventHandler(this.btnYtoM_Click);
            // 
            // btnMitoK
            // 
            this.btnMitoK.Location = new System.Drawing.Point(8, 183);
            this.btnMitoK.Name = "btnMitoK";
            this.btnMitoK.Size = new System.Drawing.Size(176, 34);
            this.btnMitoK.TabIndex = 3;
            this.btnMitoK.Text = "Miles to Kilometres";
            this.btnMitoK.UseVisualStyleBackColor = true;
            this.btnMitoK.Click += new System.EventHandler(this.btnMitoK_Click);
            // 
            // btnCtoI
            // 
            this.btnCtoI.Location = new System.Drawing.Point(190, 63);
            this.btnCtoI.Name = "btnCtoI";
            this.btnCtoI.Size = new System.Drawing.Size(176, 34);
            this.btnCtoI.TabIndex = 4;
            this.btnCtoI.Text = "Centimetres to Inches";
            this.btnCtoI.UseVisualStyleBackColor = true;
            this.btnCtoI.Click += new System.EventHandler(this.btnCtoI_Click);
            // 
            // btnCtoF
            // 
            this.btnCtoF.Location = new System.Drawing.Point(190, 103);
            this.btnCtoF.Name = "btnCtoF";
            this.btnCtoF.Size = new System.Drawing.Size(176, 34);
            this.btnCtoF.TabIndex = 5;
            this.btnCtoF.Text = "Centimetres to Feet";
            this.btnCtoF.UseVisualStyleBackColor = true;
            this.btnCtoF.Click += new System.EventHandler(this.btnCtoF_Click);
            // 
            // btnMtoY
            // 
            this.btnMtoY.Location = new System.Drawing.Point(190, 143);
            this.btnMtoY.Name = "btnMtoY";
            this.btnMtoY.Size = new System.Drawing.Size(176, 34);
            this.btnMtoY.TabIndex = 6;
            this.btnMtoY.Text = "Meters to Yards";
            this.btnMtoY.UseVisualStyleBackColor = true;
            this.btnMtoY.Click += new System.EventHandler(this.btnMtoY_Click);
            // 
            // btnKtoMi
            // 
            this.btnKtoMi.Location = new System.Drawing.Point(190, 183);
            this.btnKtoMi.Name = "btnKtoMi";
            this.btnKtoMi.Size = new System.Drawing.Size(176, 34);
            this.btnKtoMi.TabIndex = 7;
            this.btnKtoMi.Text = "Kilometres to Miles";
            this.btnKtoMi.UseVisualStyleBackColor = true;
            this.btnKtoMi.Click += new System.EventHandler(this.btnKtoMi_Click);
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(97, 26);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(87, 22);
            this.txtInput.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Enter a number:";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(190, 31);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(10, 13);
            this.lblOutput.TabIndex = 11;
            this.lblOutput.Text = " ";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabTemp);
            this.tabControl1.Controls.Add(this.tabLength);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(385, 259);
            this.tabControl1.TabIndex = 12;
            // 
            // tabLength
            // 
            this.tabLength.Controls.Add(this.label2);
            this.tabLength.Controls.Add(this.label1);
            this.tabLength.Controls.Add(this.lblOutput);
            this.tabLength.Controls.Add(this.btnItoC);
            this.tabLength.Controls.Add(this.btnFtoC);
            this.tabLength.Controls.Add(this.txtInput);
            this.tabLength.Controls.Add(this.btnYtoM);
            this.tabLength.Controls.Add(this.btnKtoMi);
            this.tabLength.Controls.Add(this.btnMitoK);
            this.tabLength.Controls.Add(this.btnMtoY);
            this.tabLength.Controls.Add(this.btnCtoI);
            this.tabLength.Controls.Add(this.btnCtoF);
            this.tabLength.Location = new System.Drawing.Point(4, 22);
            this.tabLength.Name = "tabLength";
            this.tabLength.Padding = new System.Windows.Forms.Padding(3);
            this.tabLength.Size = new System.Drawing.Size(377, 233);
            this.tabLength.TabIndex = 0;
            this.tabLength.Text = "Length";
            this.tabLength.UseVisualStyleBackColor = true;
            // 
            // tabTemp
            // 
            this.tabTemp.Controls.Add(this.label4);
            this.tabTemp.Controls.Add(this.textBox1);
            this.tabTemp.Controls.Add(this.label3);
            this.tabTemp.Location = new System.Drawing.Point(4, 22);
            this.tabTemp.Name = "tabTemp";
            this.tabTemp.Padding = new System.Windows.Forms.Padding(3);
            this.tabTemp.Size = new System.Drawing.Size(377, 233);
            this.tabTemp.TabIndex = 1;
            this.tabTemp.Text = "Temperature";
            this.tabTemp.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Length Converter";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Temperature Converter";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(99, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 20);
            this.textBox1.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Celcius:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 271);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Length Converter";
            this.tabControl1.ResumeLayout(false);
            this.tabLength.ResumeLayout(false);
            this.tabLength.PerformLayout();
            this.tabTemp.ResumeLayout(false);
            this.tabTemp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnItoC;
        private System.Windows.Forms.Button btnFtoC;
        private System.Windows.Forms.Button btnYtoM;
        private System.Windows.Forms.Button btnMitoK;
        private System.Windows.Forms.Button btnCtoI;
        private System.Windows.Forms.Button btnCtoF;
        private System.Windows.Forms.Button btnMtoY;
        private System.Windows.Forms.Button btnKtoMi;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabTemp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabLength;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
    }
}

