namespace KK04___XML_Practice
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
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.AgeTextBox = new System.Windows.Forms.TextBox();
            this.NameHeadingLabel = new System.Windows.Forms.Label();
            this.AgeHeadingLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AgeAveLabel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(181, 88);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(114, 20);
            this.NameTextBox.TabIndex = 1;
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.Location = new System.Drawing.Point(181, 125);
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.Size = new System.Drawing.Size(114, 20);
            this.AgeTextBox.TabIndex = 2;
            // 
            // NameHeadingLabel
            // 
            this.NameHeadingLabel.AutoSize = true;
            this.NameHeadingLabel.Location = new System.Drawing.Point(109, 87);
            this.NameHeadingLabel.Name = "NameHeadingLabel";
            this.NameHeadingLabel.Size = new System.Drawing.Size(35, 13);
            this.NameHeadingLabel.TabIndex = 3;
            this.NameHeadingLabel.Text = "Name";
            // 
            // AgeHeadingLabel
            // 
            this.AgeHeadingLabel.AutoSize = true;
            this.AgeHeadingLabel.Location = new System.Drawing.Point(109, 125);
            this.AgeHeadingLabel.Name = "AgeHeadingLabel";
            this.AgeHeadingLabel.Size = new System.Drawing.Size(26, 13);
            this.AgeHeadingLabel.TabIndex = 4;
            this.AgeHeadingLabel.Text = "Age";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(121, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 65);
            this.button1.TabIndex = 3;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(69, 256);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(279, 82);
            this.listBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Age Average";
            // 
            // AgeAveLabel
            // 
            this.AgeAveLabel.Location = new System.Drawing.Point(181, 359);
            this.AgeAveLabel.Name = "AgeAveLabel";
            this.AgeAveLabel.Size = new System.Drawing.Size(114, 20);
            this.AgeAveLabel.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 432);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AgeAveLabel);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AgeHeadingLabel);
            this.Controls.Add(this.NameHeadingLabel);
            this.Controls.Add(this.AgeTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox AgeTextBox;
        private System.Windows.Forms.Label NameHeadingLabel;
        private System.Windows.Forms.Label AgeHeadingLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AgeAveLabel;
    }
}

