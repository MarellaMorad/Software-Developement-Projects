namespace Exercise_2___Arrays_and_record
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
            this.Above170 = new System.Windows.Forms.Label();
            this.AverageLabel = new System.Windows.Forms.Label();
            this.AvHHeadingLabel = new System.Windows.Forms.Label();
            this.Above170HeadingLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Above170
            // 
            this.Above170.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Above170.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Above170.Location = new System.Drawing.Point(215, 221);
            this.Above170.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Above170.Name = "Above170";
            this.Above170.Size = new System.Drawing.Size(194, 56);
            this.Above170.TabIndex = 1;
            // 
            // AverageLabel
            // 
            this.AverageLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AverageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AverageLabel.Location = new System.Drawing.Point(215, 133);
            this.AverageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AverageLabel.Name = "AverageLabel";
            this.AverageLabel.Size = new System.Drawing.Size(194, 56);
            this.AverageLabel.TabIndex = 2;
            // 
            // AvHHeadingLabel
            // 
            this.AvHHeadingLabel.AutoSize = true;
            this.AvHHeadingLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvHHeadingLabel.Location = new System.Drawing.Point(26, 146);
            this.AvHHeadingLabel.Name = "AvHHeadingLabel";
            this.AvHHeadingLabel.Size = new System.Drawing.Size(182, 29);
            this.AvHHeadingLabel.TabIndex = 3;
            this.AvHHeadingLabel.Text = "Average Height:";
            // 
            // Above170HeadingLabel
            // 
            this.Above170HeadingLabel.AutoSize = true;
            this.Above170HeadingLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Above170HeadingLabel.Location = new System.Drawing.Point(47, 236);
            this.Above170HeadingLabel.Name = "Above170HeadingLabel";
            this.Above170HeadingLabel.Size = new System.Drawing.Size(161, 29);
            this.Above170HeadingLabel.TabIndex = 4;
            this.Above170HeadingLabel.Text = "Above 170cm:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 382);
            this.Controls.Add(this.Above170HeadingLabel);
            this.Controls.Add(this.AvHHeadingLabel);
            this.Controls.Add(this.AverageLabel);
            this.Controls.Add(this.Above170);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Above170;
        private System.Windows.Forms.Label AverageLabel;
        private System.Windows.Forms.Label AvHHeadingLabel;
        private System.Windows.Forms.Label Above170HeadingLabel;
    }
}

