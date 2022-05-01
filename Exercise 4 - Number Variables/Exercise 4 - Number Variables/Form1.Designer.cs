namespace Exercise_4___Number_Variables
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
            this.HeadingLabel = new System.Windows.Forms.Label();
            this.Num1Label = new System.Windows.Forms.Label();
            this.Num2Label = new System.Windows.Forms.Label();
            this.Num3Label = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.FirstLabel = new System.Windows.Forms.Label();
            this.SecondLabel = new System.Windows.Forms.Label();
            this.ThirdLabel = new System.Windows.Forms.Label();
            this.CalculateBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HeadingLabel
            // 
            this.HeadingLabel.AutoSize = true;
            this.HeadingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadingLabel.Location = new System.Drawing.Point(92, 26);
            this.HeadingLabel.Name = "HeadingLabel";
            this.HeadingLabel.Size = new System.Drawing.Size(281, 24);
            this.HeadingLabel.TabIndex = 0;
            this.HeadingLabel.Text = "Exersie 4 - Number variables";
            // 
            // Num1Label
            // 
            this.Num1Label.AutoSize = true;
            this.Num1Label.Location = new System.Drawing.Point(82, 78);
            this.Num1Label.Name = "Num1Label";
            this.Num1Label.Size = new System.Drawing.Size(53, 13);
            this.Num1Label.TabIndex = 1;
            this.Num1Label.Text = "Number 1";
            // 
            // Num2Label
            // 
            this.Num2Label.AutoSize = true;
            this.Num2Label.Location = new System.Drawing.Point(196, 78);
            this.Num2Label.Name = "Num2Label";
            this.Num2Label.Size = new System.Drawing.Size(53, 13);
            this.Num2Label.TabIndex = 2;
            this.Num2Label.Text = "Number 2";
            // 
            // Num3Label
            // 
            this.Num3Label.AutoSize = true;
            this.Num3Label.Location = new System.Drawing.Point(326, 78);
            this.Num3Label.Name = "Num3Label";
            this.Num3Label.Size = new System.Drawing.Size(53, 13);
            this.Num3Label.TabIndex = 3;
            this.Num3Label.Text = "Number 3";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(54, 110);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(174, 110);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(303, 110);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            // 
            // FirstLabel
            // 
            this.FirstLabel.AutoSize = true;
            this.FirstLabel.Location = new System.Drawing.Point(82, 157);
            this.FirstLabel.Name = "FirstLabel";
            this.FirstLabel.Size = new System.Drawing.Size(48, 13);
            this.FirstLabel.TabIndex = 7;
            this.FirstLabel.Text = "Output 1";
            // 
            // SecondLabel
            // 
            this.SecondLabel.AutoSize = true;
            this.SecondLabel.Location = new System.Drawing.Point(196, 157);
            this.SecondLabel.Name = "SecondLabel";
            this.SecondLabel.Size = new System.Drawing.Size(48, 13);
            this.SecondLabel.TabIndex = 8;
            this.SecondLabel.Text = "Output 2";
            // 
            // ThirdLabel
            // 
            this.ThirdLabel.AutoSize = true;
            this.ThirdLabel.Location = new System.Drawing.Point(325, 157);
            this.ThirdLabel.Name = "ThirdLabel";
            this.ThirdLabel.Size = new System.Drawing.Size(48, 13);
            this.ThirdLabel.TabIndex = 9;
            this.ThirdLabel.Text = "Output 3";
            // 
            // CalculateBtn
            // 
            this.CalculateBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.CalculateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateBtn.Location = new System.Drawing.Point(175, 208);
            this.CalculateBtn.Name = "CalculateBtn";
            this.CalculateBtn.Size = new System.Drawing.Size(121, 85);
            this.CalculateBtn.TabIndex = 10;
            this.CalculateBtn.Text = "Calculate";
            this.CalculateBtn.UseVisualStyleBackColor = false;
            this.CalculateBtn.Click += new System.EventHandler(this.CalculateBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 334);
            this.Controls.Add(this.CalculateBtn);
            this.Controls.Add(this.ThirdLabel);
            this.Controls.Add(this.SecondLabel);
            this.Controls.Add(this.FirstLabel);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Num3Label);
            this.Controls.Add(this.Num2Label);
            this.Controls.Add(this.Num1Label);
            this.Controls.Add(this.HeadingLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeadingLabel;
        private System.Windows.Forms.Label Num1Label;
        private System.Windows.Forms.Label Num2Label;
        private System.Windows.Forms.Label Num3Label;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label FirstLabel;
        private System.Windows.Forms.Label SecondLabel;
        private System.Windows.Forms.Label ThirdLabel;
        private System.Windows.Forms.Button CalculateBtn;
    }
}

