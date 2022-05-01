namespace Excersie_4___2nd_program
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
            this.CalculateBtn = new System.Windows.Forms.Button();
            this.Num1Label = new System.Windows.Forms.Label();
            this.Num2Label = new System.Windows.Forms.Label();
            this.Num3Label = new System.Windows.Forms.Label();
            this.HeadingLabel = new System.Windows.Forms.Label();
            this.FirstOutPut = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SecondOutPut = new System.Windows.Forms.Label();
            this.ThirdOutPut = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CalculateBtn
            // 
            this.CalculateBtn.Location = new System.Drawing.Point(210, 181);
            this.CalculateBtn.Name = "CalculateBtn";
            this.CalculateBtn.Size = new System.Drawing.Size(75, 23);
            this.CalculateBtn.TabIndex = 0;
            this.CalculateBtn.Text = "Claculate";
            this.CalculateBtn.UseVisualStyleBackColor = true;
            this.CalculateBtn.Click += new System.EventHandler(this.CalculateBtn_Click);
            // 
            // Num1Label
            // 
            this.Num1Label.AutoSize = true;
            this.Num1Label.Location = new System.Drawing.Point(72, 82);
            this.Num1Label.Name = "Num1Label";
            this.Num1Label.Size = new System.Drawing.Size(53, 13);
            this.Num1Label.TabIndex = 1;
            this.Num1Label.Text = "Number 1";
            // 
            // Num2Label
            // 
            this.Num2Label.AutoSize = true;
            this.Num2Label.Location = new System.Drawing.Point(229, 82);
            this.Num2Label.Name = "Num2Label";
            this.Num2Label.Size = new System.Drawing.Size(53, 13);
            this.Num2Label.TabIndex = 2;
            this.Num2Label.Text = "Number 2";
            // 
            // Num3Label
            // 
            this.Num3Label.AutoSize = true;
            this.Num3Label.Location = new System.Drawing.Point(382, 82);
            this.Num3Label.Name = "Num3Label";
            this.Num3Label.Size = new System.Drawing.Size(53, 13);
            this.Num3Label.TabIndex = 3;
            this.Num3Label.Text = "Number 3";
            // 
            // HeadingLabel
            // 
            this.HeadingLabel.AutoSize = true;
            this.HeadingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadingLabel.Location = new System.Drawing.Point(134, 32);
            this.HeadingLabel.Name = "HeadingLabel";
            this.HeadingLabel.Size = new System.Drawing.Size(236, 18);
            this.HeadingLabel.TabIndex = 4;
            this.HeadingLabel.Text = "Excersie 4 - Number Variables";
            // 
            // FirstOutPut
            // 
            this.FirstOutPut.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.FirstOutPut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FirstOutPut.Location = new System.Drawing.Point(72, 237);
            this.FirstOutPut.Name = "FirstOutPut";
            this.FirstOutPut.Size = new System.Drawing.Size(53, 24);
            this.FirstOutPut.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(49, 131);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(197, 131);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(352, 131);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 10;
            // 
            // SecondOutPut
            // 
            this.SecondOutPut.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SecondOutPut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SecondOutPut.Location = new System.Drawing.Point(229, 237);
            this.SecondOutPut.Name = "SecondOutPut";
            this.SecondOutPut.Size = new System.Drawing.Size(53, 24);
            this.SecondOutPut.TabIndex = 11;
            // 
            // ThirdOutPut
            // 
            this.ThirdOutPut.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ThirdOutPut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ThirdOutPut.Location = new System.Drawing.Point(382, 237);
            this.ThirdOutPut.Name = "ThirdOutPut";
            this.ThirdOutPut.Size = new System.Drawing.Size(53, 24);
            this.ThirdOutPut.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 324);
            this.Controls.Add(this.ThirdOutPut);
            this.Controls.Add(this.SecondOutPut);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.FirstOutPut);
            this.Controls.Add(this.HeadingLabel);
            this.Controls.Add(this.Num3Label);
            this.Controls.Add(this.Num2Label);
            this.Controls.Add(this.Num1Label);
            this.Controls.Add(this.CalculateBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalculateBtn;
        private System.Windows.Forms.Label Num1Label;
        private System.Windows.Forms.Label Num2Label;
        private System.Windows.Forms.Label Num3Label;
        private System.Windows.Forms.Label HeadingLabel;
        private System.Windows.Forms.Label FirstOutPut;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label SecondOutPut;
        private System.Windows.Forms.Label ThirdOutPut;
    }
}

