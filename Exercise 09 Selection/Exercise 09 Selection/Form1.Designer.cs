namespace Exercise_09_Selection
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
            this.ScoreTextBox = new System.Windows.Forms.TextBox();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.GradeLabel = new System.Windows.Forms.Label();
            this.RunBtn = new System.Windows.Forms.Button();
            this.CommentLabel = new System.Windows.Forms.Label();
            this.HeadingLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ScoreTextBox
            // 
            this.ScoreTextBox.Location = new System.Drawing.Point(201, 66);
            this.ScoreTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ScoreTextBox.Name = "ScoreTextBox";
            this.ScoreTextBox.Size = new System.Drawing.Size(93, 20);
            this.ScoreTextBox.TabIndex = 0;
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Location = new System.Drawing.Point(60, 66);
            this.InfoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(118, 13);
            this.InfoLabel.TabIndex = 1;
            this.InfoLabel.Text = "Please enter your score";
            // 
            // GradeLabel
            // 
            this.GradeLabel.BackColor = System.Drawing.SystemColors.Control;
            this.GradeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GradeLabel.Location = new System.Drawing.Point(60, 113);
            this.GradeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GradeLabel.Name = "GradeLabel";
            this.GradeLabel.Size = new System.Drawing.Size(175, 33);
            this.GradeLabel.TabIndex = 3;
            // 
            // RunBtn
            // 
            this.RunBtn.Location = new System.Drawing.Point(140, 237);
            this.RunBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RunBtn.Name = "RunBtn";
            this.RunBtn.Size = new System.Drawing.Size(127, 45);
            this.RunBtn.TabIndex = 4;
            this.RunBtn.Text = "Run";
            this.RunBtn.UseVisualStyleBackColor = true;
            this.RunBtn.Click += new System.EventHandler(this.RunBtn_Click);
            // 
            // CommentLabel
            // 
            this.CommentLabel.BackColor = System.Drawing.SystemColors.Control;
            this.CommentLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CommentLabel.Location = new System.Drawing.Point(60, 171);
            this.CommentLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CommentLabel.Name = "CommentLabel";
            this.CommentLabel.Size = new System.Drawing.Size(175, 33);
            this.CommentLabel.TabIndex = 5;
            // 
            // HeadingLabel
            // 
            this.HeadingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadingLabel.Location = new System.Drawing.Point(103, 13);
            this.HeadingLabel.Name = "HeadingLabel";
            this.HeadingLabel.Size = new System.Drawing.Size(172, 32);
            this.HeadingLabel.TabIndex = 6;
            this.HeadingLabel.Text = "Grade Converter";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 319);
            this.Controls.Add(this.HeadingLabel);
            this.Controls.Add(this.CommentLabel);
            this.Controls.Add(this.RunBtn);
            this.Controls.Add(this.GradeLabel);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.ScoreTextBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ScoreTextBox;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.Label GradeLabel;
        private System.Windows.Forms.Button RunBtn;
        private System.Windows.Forms.Label CommentLabel;
        private System.Windows.Forms.Label HeadingLabel;
    }
}

