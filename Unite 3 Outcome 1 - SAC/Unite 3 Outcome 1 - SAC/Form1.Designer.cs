namespace Unite_3_Outcome_1___SAC
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
            this.BMIHeadLabel = new System.Windows.Forms.Label();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.CalcButton = new System.Windows.Forms.Button();
            this.BMIHeadLabel2 = new System.Windows.Forms.Label();
            this.CatHeadLabel = new System.Windows.Forms.Label();
            this.BMIAveHeadLabel = new System.Windows.Forms.Label();
            this.BMIMinHeadLabel = new System.Windows.Forms.Label();
            this.BMIMaxHeadLabel = new System.Windows.Forms.Label();
            this.BMILabel = new System.Windows.Forms.Label();
            this.CatLabel = new System.Windows.Forms.Label();
            this.BMIAveLabel = new System.Windows.Forms.Label();
            this.BMIMinLabel = new System.Windows.Forms.Label();
            this.BMIMaxLabel = new System.Windows.Forms.Label();
            this.InstructionsLabel1 = new System.Windows.Forms.Label();
            this.InstructionsLabel2 = new System.Windows.Forms.Label();
            this.BMISearchTextBox = new System.Windows.Forms.TextBox();
            this.BMISearchLabel = new System.Windows.Forms.Label();
            this.FoundLabel = new System.Windows.Forms.Label();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BMIHeadLabel
            // 
            this.BMIHeadLabel.AutoSize = true;
            this.BMIHeadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMIHeadLabel.Location = new System.Drawing.Point(136, 38);
            this.BMIHeadLabel.Name = "BMIHeadLabel";
            this.BMIHeadLabel.Size = new System.Drawing.Size(206, 33);
            this.BMIHeadLabel.TabIndex = 0;
            this.BMIHeadLabel.Text = "BMI Calculator";
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Location = new System.Drawing.Point(30, 136);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(62, 13);
            this.WeightLabel.TabIndex = 1;
            this.WeightLabel.Text = "Weight (kg)";
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Location = new System.Drawing.Point(30, 171);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(55, 13);
            this.HeightLabel.TabIndex = 2;
            this.HeightLabel.Text = "Height (m)";
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Location = new System.Drawing.Point(107, 133);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(118, 20);
            this.WeightTextBox.TabIndex = 3;
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Location = new System.Drawing.Point(107, 168);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(118, 20);
            this.HeightTextBox.TabIndex = 4;
            // 
            // CalcButton
            // 
            this.CalcButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalcButton.Location = new System.Drawing.Point(55, 222);
            this.CalcButton.Name = "CalcButton";
            this.CalcButton.Size = new System.Drawing.Size(158, 73);
            this.CalcButton.TabIndex = 5;
            this.CalcButton.Text = "Calculate BMI";
            this.CalcButton.UseVisualStyleBackColor = true;
            this.CalcButton.Click += new System.EventHandler(this.CalcButton_Click);
            // 
            // BMIHeadLabel2
            // 
            this.BMIHeadLabel2.AutoSize = true;
            this.BMIHeadLabel2.Location = new System.Drawing.Point(293, 133);
            this.BMIHeadLabel2.Name = "BMIHeadLabel2";
            this.BMIHeadLabel2.Size = new System.Drawing.Size(29, 13);
            this.BMIHeadLabel2.TabIndex = 6;
            this.BMIHeadLabel2.Text = "BMI:";
            // 
            // CatHeadLabel
            // 
            this.CatHeadLabel.AutoSize = true;
            this.CatHeadLabel.Location = new System.Drawing.Point(270, 168);
            this.CatHeadLabel.Name = "CatHeadLabel";
            this.CatHeadLabel.Size = new System.Drawing.Size(52, 13);
            this.CatHeadLabel.TabIndex = 7;
            this.CatHeadLabel.Text = "Category:";
            // 
            // BMIAveHeadLabel
            // 
            this.BMIAveHeadLabel.AutoSize = true;
            this.BMIAveHeadLabel.Location = new System.Drawing.Point(290, 199);
            this.BMIAveHeadLabel.Name = "BMIAveHeadLabel";
            this.BMIAveHeadLabel.Size = new System.Drawing.Size(32, 13);
            this.BMIAveHeadLabel.TabIndex = 8;
            this.BMIAveHeadLabel.Text = "AVG:";
            // 
            // BMIMinHeadLabel
            // 
            this.BMIMinHeadLabel.AutoSize = true;
            this.BMIMinHeadLabel.Location = new System.Drawing.Point(290, 233);
            this.BMIMinHeadLabel.Name = "BMIMinHeadLabel";
            this.BMIMinHeadLabel.Size = new System.Drawing.Size(30, 13);
            this.BMIMinHeadLabel.TabIndex = 9;
            this.BMIMinHeadLabel.Text = "MIN:";
            // 
            // BMIMaxHeadLabel
            // 
            this.BMIMaxHeadLabel.AutoSize = true;
            this.BMIMaxHeadLabel.Location = new System.Drawing.Point(290, 266);
            this.BMIMaxHeadLabel.Name = "BMIMaxHeadLabel";
            this.BMIMaxHeadLabel.Size = new System.Drawing.Size(33, 13);
            this.BMIMaxHeadLabel.TabIndex = 10;
            this.BMIMaxHeadLabel.Text = "MAX:";
            // 
            // BMILabel
            // 
            this.BMILabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BMILabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BMILabel.Location = new System.Drawing.Point(328, 132);
            this.BMILabel.Name = "BMILabel";
            this.BMILabel.Size = new System.Drawing.Size(91, 20);
            this.BMILabel.TabIndex = 11;
            // 
            // CatLabel
            // 
            this.CatLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CatLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CatLabel.Location = new System.Drawing.Point(328, 167);
            this.CatLabel.Name = "CatLabel";
            this.CatLabel.Size = new System.Drawing.Size(91, 20);
            this.CatLabel.TabIndex = 12;
            // 
            // BMIAveLabel
            // 
            this.BMIAveLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BMIAveLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BMIAveLabel.Location = new System.Drawing.Point(328, 198);
            this.BMIAveLabel.Name = "BMIAveLabel";
            this.BMIAveLabel.Size = new System.Drawing.Size(91, 20);
            this.BMIAveLabel.TabIndex = 13;
            // 
            // BMIMinLabel
            // 
            this.BMIMinLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BMIMinLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BMIMinLabel.Location = new System.Drawing.Point(326, 232);
            this.BMIMinLabel.Name = "BMIMinLabel";
            this.BMIMinLabel.Size = new System.Drawing.Size(91, 20);
            this.BMIMinLabel.TabIndex = 14;
            // 
            // BMIMaxLabel
            // 
            this.BMIMaxLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BMIMaxLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BMIMaxLabel.Location = new System.Drawing.Point(326, 265);
            this.BMIMaxLabel.Name = "BMIMaxLabel";
            this.BMIMaxLabel.Size = new System.Drawing.Size(91, 20);
            this.BMIMaxLabel.TabIndex = 15;
            // 
            // InstructionsLabel1
            // 
            this.InstructionsLabel1.AutoSize = true;
            this.InstructionsLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructionsLabel1.Location = new System.Drawing.Point(31, 92);
            this.InstructionsLabel1.Name = "InstructionsLabel1";
            this.InstructionsLabel1.Size = new System.Drawing.Size(212, 15);
            this.InstructionsLabel1.TabIndex = 16;
            this.InstructionsLabel1.Text = "Please enter your details below:";
            // 
            // InstructionsLabel2
            // 
            this.InstructionsLabel2.AutoSize = true;
            this.InstructionsLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructionsLabel2.Location = new System.Drawing.Point(31, 330);
            this.InstructionsLabel2.Name = "InstructionsLabel2";
            this.InstructionsLabel2.Size = new System.Drawing.Size(404, 15);
            this.InstructionsLabel2.TabIndex = 17;
            this.InstructionsLabel2.Text = "Please enter the BMI value you would like to search for below:";
            // 
            // BMISearchTextBox
            // 
            this.BMISearchTextBox.Location = new System.Drawing.Point(107, 367);
            this.BMISearchTextBox.Name = "BMISearchTextBox";
            this.BMISearchTextBox.Size = new System.Drawing.Size(118, 20);
            this.BMISearchTextBox.TabIndex = 19;
            // 
            // BMISearchLabel
            // 
            this.BMISearchLabel.AutoSize = true;
            this.BMISearchLabel.Location = new System.Drawing.Point(34, 370);
            this.BMISearchLabel.Name = "BMISearchLabel";
            this.BMISearchLabel.Size = new System.Drawing.Size(58, 13);
            this.BMISearchLabel.TabIndex = 18;
            this.BMISearchLabel.Text = "BMI value:";
            // 
            // FoundLabel
            // 
            this.FoundLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FoundLabel.Location = new System.Drawing.Point(67, 406);
            this.FoundLabel.Name = "FoundLabel";
            this.FoundLabel.Size = new System.Drawing.Size(112, 29);
            this.FoundLabel.TabIndex = 20;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.Location = new System.Drawing.Point(296, 367);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(134, 58);
            this.SearchBtn.TabIndex = 22;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 457);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.FoundLabel);
            this.Controls.Add(this.BMISearchTextBox);
            this.Controls.Add(this.BMISearchLabel);
            this.Controls.Add(this.InstructionsLabel2);
            this.Controls.Add(this.InstructionsLabel1);
            this.Controls.Add(this.BMIMaxLabel);
            this.Controls.Add(this.BMIMinLabel);
            this.Controls.Add(this.BMIAveLabel);
            this.Controls.Add(this.CatLabel);
            this.Controls.Add(this.BMILabel);
            this.Controls.Add(this.BMIMaxHeadLabel);
            this.Controls.Add(this.BMIMinHeadLabel);
            this.Controls.Add(this.BMIAveHeadLabel);
            this.Controls.Add(this.CatHeadLabel);
            this.Controls.Add(this.BMIHeadLabel2);
            this.Controls.Add(this.CalcButton);
            this.Controls.Add(this.HeightTextBox);
            this.Controls.Add(this.WeightTextBox);
            this.Controls.Add(this.HeightLabel);
            this.Controls.Add(this.WeightLabel);
            this.Controls.Add(this.BMIHeadLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BMIHeadLabel;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.Button CalcButton;
        private System.Windows.Forms.Label BMIHeadLabel2;
        private System.Windows.Forms.Label CatHeadLabel;
        private System.Windows.Forms.Label BMIAveHeadLabel;
        private System.Windows.Forms.Label BMIMinHeadLabel;
        private System.Windows.Forms.Label BMIMaxHeadLabel;
        private System.Windows.Forms.Label BMILabel;
        private System.Windows.Forms.Label CatLabel;
        private System.Windows.Forms.Label BMIAveLabel;
        private System.Windows.Forms.Label BMIMinLabel;
        private System.Windows.Forms.Label BMIMaxLabel;
        private System.Windows.Forms.Label InstructionsLabel1;
        private System.Windows.Forms.Label InstructionsLabel2;
        private System.Windows.Forms.TextBox BMISearchTextBox;
        private System.Windows.Forms.Label BMISearchLabel;
        private System.Windows.Forms.Label FoundLabel;
        private System.Windows.Forms.Button SearchBtn;
    }
}

