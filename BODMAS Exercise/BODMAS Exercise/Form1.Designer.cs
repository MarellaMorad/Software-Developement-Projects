namespace BODMAS_Exercise
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
            this.Num1TextBox = new System.Windows.Forms.TextBox();
            this.Num3TextBox = new System.Windows.Forms.TextBox();
            this.Num2TextBox = new System.Windows.Forms.TextBox();
            this.CalculateBtn = new System.Windows.Forms.Button();
            this.AnsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HeadingLabel
            // 
            this.HeadingLabel.AutoSize = true;
            this.HeadingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadingLabel.Location = new System.Drawing.Point(147, 13);
            this.HeadingLabel.Name = "HeadingLabel";
            this.HeadingLabel.Size = new System.Drawing.Size(149, 18);
            this.HeadingLabel.TabIndex = 0;
            this.HeadingLabel.Text = "BODMAS Exercise";
            // 
            // Num1Label
            // 
            this.Num1Label.AutoSize = true;
            this.Num1Label.Location = new System.Drawing.Point(62, 61);
            this.Num1Label.Name = "Num1Label";
            this.Num1Label.Size = new System.Drawing.Size(53, 13);
            this.Num1Label.TabIndex = 1;
            this.Num1Label.Text = "Number 1";
            // 
            // Num2Label
            // 
            this.Num2Label.AutoSize = true;
            this.Num2Label.Location = new System.Drawing.Point(195, 61);
            this.Num2Label.Name = "Num2Label";
            this.Num2Label.Size = new System.Drawing.Size(53, 13);
            this.Num2Label.TabIndex = 2;
            this.Num2Label.Text = "Number 2";
            // 
            // Num3Label
            // 
            this.Num3Label.AutoSize = true;
            this.Num3Label.Location = new System.Drawing.Point(330, 61);
            this.Num3Label.Name = "Num3Label";
            this.Num3Label.Size = new System.Drawing.Size(53, 13);
            this.Num3Label.TabIndex = 3;
            this.Num3Label.Text = "Number 3";
            // 
            // Num1TextBox
            // 
            this.Num1TextBox.Location = new System.Drawing.Point(40, 92);
            this.Num1TextBox.Name = "Num1TextBox";
            this.Num1TextBox.Size = new System.Drawing.Size(100, 20);
            this.Num1TextBox.TabIndex = 4;
            // 
            // Num3TextBox
            // 
            this.Num3TextBox.Location = new System.Drawing.Point(308, 92);
            this.Num3TextBox.Name = "Num3TextBox";
            this.Num3TextBox.Size = new System.Drawing.Size(100, 20);
            this.Num3TextBox.TabIndex = 5;
            // 
            // Num2TextBox
            // 
            this.Num2TextBox.Location = new System.Drawing.Point(171, 92);
            this.Num2TextBox.Name = "Num2TextBox";
            this.Num2TextBox.Size = new System.Drawing.Size(100, 20);
            this.Num2TextBox.TabIndex = 6;
            // 
            // CalculateBtn
            // 
            this.CalculateBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.CalculateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateBtn.Location = new System.Drawing.Point(159, 149);
            this.CalculateBtn.Name = "CalculateBtn";
            this.CalculateBtn.Size = new System.Drawing.Size(125, 63);
            this.CalculateBtn.TabIndex = 7;
            this.CalculateBtn.Text = "Calculate";
            this.CalculateBtn.UseVisualStyleBackColor = false;
            this.CalculateBtn.Click += new System.EventHandler(this.CalculateBtn_Click);
            // 
            // AnsLabel
            // 
            this.AnsLabel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.AnsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AnsLabel.Location = new System.Drawing.Point(183, 241);
            this.AnsLabel.Name = "AnsLabel";
            this.AnsLabel.Size = new System.Drawing.Size(77, 55);
            this.AnsLabel.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 325);
            this.Controls.Add(this.AnsLabel);
            this.Controls.Add(this.CalculateBtn);
            this.Controls.Add(this.Num2TextBox);
            this.Controls.Add(this.Num3TextBox);
            this.Controls.Add(this.Num1TextBox);
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
        private System.Windows.Forms.TextBox Num1TextBox;
        private System.Windows.Forms.TextBox Num3TextBox;
        private System.Windows.Forms.TextBox Num2TextBox;
        private System.Windows.Forms.Button CalculateBtn;
        private System.Windows.Forms.Label AnsLabel;
    }
}

