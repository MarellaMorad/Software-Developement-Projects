namespace Input_Box_Array_Practice
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
			this.ScoresHeading = new System.Windows.Forms.Label();
			this.ScoresLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// ScoresHeading
			// 
			this.ScoresHeading.AutoSize = true;
			this.ScoresHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ScoresHeading.Location = new System.Drawing.Point(48, 69);
			this.ScoresHeading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.ScoresHeading.Name = "ScoresHeading";
			this.ScoresHeading.Size = new System.Drawing.Size(122, 37);
			this.ScoresHeading.TabIndex = 0;
			this.ScoresHeading.Text = "Scores";
			// 
			// ScoresLabel
			// 
			this.ScoresLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ScoresLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ScoresLabel.Location = new System.Drawing.Point(56, 135);
			this.ScoresLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.ScoresLabel.Name = "ScoresLabel";
			this.ScoresLabel.Size = new System.Drawing.Size(242, 48);
			this.ScoresLabel.TabIndex = 1;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(398, 282);
			this.Controls.Add(this.ScoresLabel);
			this.Controls.Add(this.ScoresHeading);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Form1";
			this.Text = "InputBox Pracitce";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ScoresHeading;
        private System.Windows.Forms.Label ScoresLabel;
    }
}

