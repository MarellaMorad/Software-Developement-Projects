namespace Presentation_2_Exercise
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MainHeadingLabel = new System.Windows.Forms.Label();
            this.ExampleLabel = new System.Windows.Forms.Label();
            this.ChangeLabelButton = new System.Windows.Forms.Button();
            this.ShowPicButton = new System.Windows.Forms.Button();
            this.ExampleTextBox = new System.Windows.Forms.TextBox();
            this.ExamplePictureBox = new System.Windows.Forms.PictureBox();
            this.HidePicButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ExamplePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MainHeadingLabel
            // 
            this.MainHeadingLabel.AutoSize = true;
            this.MainHeadingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainHeadingLabel.Location = new System.Drawing.Point(111, 19);
            this.MainHeadingLabel.Name = "MainHeadingLabel";
            this.MainHeadingLabel.Size = new System.Drawing.Size(285, 29);
            this.MainHeadingLabel.TabIndex = 0;
            this.MainHeadingLabel.Text = "My First Form Application";
            // 
            // ExampleLabel
            // 
            this.ExampleLabel.AutoSize = true;
            this.ExampleLabel.Location = new System.Drawing.Point(12, 85);
            this.ExampleLabel.Name = "ExampleLabel";
            this.ExampleLabel.Size = new System.Drawing.Size(140, 13);
            this.ExampleLabel.TabIndex = 1;
            this.ExampleLabel.Text = "This is an example of a label";
            // 
            // ChangeLabelButton
            // 
            this.ChangeLabelButton.Location = new System.Drawing.Point(355, 62);
            this.ChangeLabelButton.Name = "ChangeLabelButton";
            this.ChangeLabelButton.Size = new System.Drawing.Size(113, 58);
            this.ChangeLabelButton.TabIndex = 2;
            this.ChangeLabelButton.Text = "Change Label";
            this.ChangeLabelButton.UseVisualStyleBackColor = true;
            this.ChangeLabelButton.Click += new System.EventHandler(this.ChangeLabelButton_Click);
            // 
            // ShowPicButton
            // 
            this.ShowPicButton.Location = new System.Drawing.Point(355, 126);
            this.ShowPicButton.Name = "ShowPicButton";
            this.ShowPicButton.Size = new System.Drawing.Size(113, 57);
            this.ShowPicButton.TabIndex = 3;
            this.ShowPicButton.Text = "Show Image";
            this.ShowPicButton.UseVisualStyleBackColor = true;
            this.ShowPicButton.Click += new System.EventHandler(this.ShowPicButton_Click);
            // 
            // ExampleTextBox
            // 
            this.ExampleTextBox.Location = new System.Drawing.Point(15, 109);
            this.ExampleTextBox.Name = "ExampleTextBox";
            this.ExampleTextBox.Size = new System.Drawing.Size(136, 20);
            this.ExampleTextBox.TabIndex = 4;
            // 
            // ExamplePictureBox
            // 
            this.ExamplePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("ExamplePictureBox.Image")));
            this.ExamplePictureBox.Location = new System.Drawing.Point(15, 148);
            this.ExamplePictureBox.Name = "ExamplePictureBox";
            this.ExamplePictureBox.Size = new System.Drawing.Size(233, 246);
            this.ExamplePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ExamplePictureBox.TabIndex = 5;
            this.ExamplePictureBox.TabStop = false;
            this.ExamplePictureBox.Visible = false;
            // 
            // HidePicButton
            // 
            this.HidePicButton.Location = new System.Drawing.Point(355, 189);
            this.HidePicButton.Name = "HidePicButton";
            this.HidePicButton.Size = new System.Drawing.Size(113, 57);
            this.HidePicButton.TabIndex = 6;
            this.HidePicButton.Text = "Hide Image";
            this.HidePicButton.UseVisualStyleBackColor = true;
            this.HidePicButton.Click += new System.EventHandler(this.HidePicButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(357, 260);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(110, 67);
            this.ResetButton.TabIndex = 7;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 480);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.HidePicButton);
            this.Controls.Add(this.ExamplePictureBox);
            this.Controls.Add(this.ExampleTextBox);
            this.Controls.Add(this.ShowPicButton);
            this.Controls.Add(this.ChangeLabelButton);
            this.Controls.Add(this.ExampleLabel);
            this.Controls.Add(this.MainHeadingLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ExamplePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MainHeadingLabel;
        private System.Windows.Forms.Label ExampleLabel;
        private System.Windows.Forms.Button ChangeLabelButton;
        private System.Windows.Forms.Button ShowPicButton;
        private System.Windows.Forms.TextBox ExampleTextBox;
        private System.Windows.Forms.PictureBox ExamplePictureBox;
        private System.Windows.Forms.Button HidePicButton;
        private System.Windows.Forms.Button ResetButton;
    }
}

