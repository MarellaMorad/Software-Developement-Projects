namespace Validation___Practice
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
            this.CalcAgeBtn = new System.Windows.Forms.Button();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.AnsLabel = new System.Windows.Forms.Label();
            this.YOBTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CalcAgeBtn
            // 
            this.CalcAgeBtn.Location = new System.Drawing.Point(199, 273);
            this.CalcAgeBtn.Name = "CalcAgeBtn";
            this.CalcAgeBtn.Size = new System.Drawing.Size(135, 80);
            this.CalcAgeBtn.TabIndex = 0;
            this.CalcAgeBtn.Text = "Calculate Age";
            this.CalcAgeBtn.UseVisualStyleBackColor = true;
            this.CalcAgeBtn.Click += new System.EventHandler(this.CalcAgeBtn_Click);
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Location = new System.Drawing.Point(57, 48);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(260, 20);
            this.InfoLabel.TabIndex = 1;
            this.InfoLabel.Text = "Please enter your YEAR OF BIRTH";
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ErrorLabel.Location = new System.Drawing.Point(57, 124);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(260, 42);
            this.ErrorLabel.TabIndex = 2;
            // 
            // AnsLabel
            // 
            this.AnsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AnsLabel.Location = new System.Drawing.Point(57, 190);
            this.AnsLabel.Name = "AnsLabel";
            this.AnsLabel.Size = new System.Drawing.Size(260, 43);
            this.AnsLabel.TabIndex = 3;
            // 
            // YOBTextBox
            // 
            this.YOBTextBox.Location = new System.Drawing.Point(323, 42);
            this.YOBTextBox.Name = "YOBTextBox";
            this.YOBTextBox.Size = new System.Drawing.Size(100, 26);
            this.YOBTextBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 401);
            this.Controls.Add(this.YOBTextBox);
            this.Controls.Add(this.AnsLabel);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.CalcAgeBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalcAgeBtn;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Label AnsLabel;
        private System.Windows.Forms.TextBox YOBTextBox;
    }
}

