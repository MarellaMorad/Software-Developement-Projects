namespace Exercise_10_Validation
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
            this.InfoLabel = new System.Windows.Forms.Label();
            this.PCTextBox = new System.Windows.Forms.TextBox();
            this.CheckLabel = new System.Windows.Forms.Label();
            this.CheckBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Location = new System.Drawing.Point(59, 69);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(181, 20);
            this.InfoLabel.TabIndex = 0;
            this.InfoLabel.Text = "Please enter a postcode";
            // 
            // PCTextBox
            // 
            this.PCTextBox.Location = new System.Drawing.Point(279, 69);
            this.PCTextBox.Name = "PCTextBox";
            this.PCTextBox.Size = new System.Drawing.Size(100, 26);
            this.PCTextBox.TabIndex = 1;
            // 
            // CheckLabel
            // 
            this.CheckLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CheckLabel.Location = new System.Drawing.Point(116, 132);
            this.CheckLabel.Name = "CheckLabel";
            this.CheckLabel.Size = new System.Drawing.Size(193, 42);
            this.CheckLabel.TabIndex = 2;
            // 
            // CheckBtn
            // 
            this.CheckBtn.Location = new System.Drawing.Point(116, 221);
            this.CheckBtn.Name = "CheckBtn";
            this.CheckBtn.Size = new System.Drawing.Size(193, 76);
            this.CheckBtn.TabIndex = 3;
            this.CheckBtn.Text = "Check";
            this.CheckBtn.UseVisualStyleBackColor = true;
            this.CheckBtn.Click += new System.EventHandler(this.CheckBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 380);
            this.Controls.Add(this.CheckBtn);
            this.Controls.Add(this.CheckLabel);
            this.Controls.Add(this.PCTextBox);
            this.Controls.Add(this.InfoLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.TextBox PCTextBox;
        private System.Windows.Forms.Label CheckLabel;
        private System.Windows.Forms.Button CheckBtn;
    }
}

