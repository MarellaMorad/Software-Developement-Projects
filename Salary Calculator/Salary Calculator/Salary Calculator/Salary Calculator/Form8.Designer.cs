namespace Marella_MORAD___SD_SAT___2019
{
    partial class Form8
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.CheckAnsBtn = new System.Windows.Forms.Button();
            this.AnsTextBox = new System.Windows.Forms.TextBox();
            this.QnsLabel = new System.Windows.Forms.Label();
            this.SubmitUNBtn = new System.Windows.Forms.Button();
            this.UNTextBox = new System.Windows.Forms.TextBox();
            this.UNInstLabel = new System.Windows.Forms.Label();
            this.InstLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 318);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 26);
            this.label1.TabIndex = 55;
            this.label1.Text = "Answer:";
            // 
            // CheckAnsBtn
            // 
            this.CheckAnsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckAnsBtn.Location = new System.Drawing.Point(118, 358);
            this.CheckAnsBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CheckAnsBtn.Name = "CheckAnsBtn";
            this.CheckAnsBtn.Size = new System.Drawing.Size(201, 43);
            this.CheckAnsBtn.TabIndex = 3;
            this.CheckAnsBtn.Text = "Check Answer";
            this.toolTip1.SetToolTip(this.CheckAnsBtn, "Click to check your answer and display your password");
            this.CheckAnsBtn.UseVisualStyleBackColor = true;
            this.CheckAnsBtn.Click += new System.EventHandler(this.CheckAnsBtn_Click);
            // 
            // AnsTextBox
            // 
            this.AnsTextBox.Location = new System.Drawing.Point(118, 318);
            this.AnsTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AnsTextBox.Name = "AnsTextBox";
            this.AnsTextBox.Size = new System.Drawing.Size(297, 26);
            this.AnsTextBox.TabIndex = 2;
            this.toolTip1.SetToolTip(this.AnsTextBox, "Enter your answer here - based on the question displayed above");
            // 
            // QnsLabel
            // 
            this.QnsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QnsLabel.Location = new System.Drawing.Point(24, 250);
            this.QnsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.QnsLabel.Name = "QnsLabel";
            this.QnsLabel.Size = new System.Drawing.Size(402, 64);
            this.QnsLabel.TabIndex = 52;
            this.QnsLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // SubmitUNBtn
            // 
            this.SubmitUNBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitUNBtn.Location = new System.Drawing.Point(134, 171);
            this.SubmitUNBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SubmitUNBtn.Name = "SubmitUNBtn";
            this.SubmitUNBtn.Size = new System.Drawing.Size(168, 43);
            this.SubmitUNBtn.TabIndex = 1;
            this.SubmitUNBtn.Text = "Submit";
            this.toolTip1.SetToolTip(this.SubmitUNBtn, "Click to submit your usernmae");
            this.SubmitUNBtn.UseVisualStyleBackColor = true;
            this.SubmitUNBtn.Click += new System.EventHandler(this.SubmitUNBtn_Click);
            // 
            // UNTextBox
            // 
            this.UNTextBox.Location = new System.Drawing.Point(96, 131);
            this.UNTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UNTextBox.Name = "UNTextBox";
            this.UNTextBox.Size = new System.Drawing.Size(319, 26);
            this.UNTextBox.TabIndex = 0;
            this.toolTip1.SetToolTip(this.UNTextBox, "Enter your Username here");
            // 
            // UNInstLabel
            // 
            this.UNInstLabel.AutoSize = true;
            this.UNInstLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UNInstLabel.Location = new System.Drawing.Point(18, 100);
            this.UNInstLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UNInstLabel.Name = "UNInstLabel";
            this.UNInstLabel.Size = new System.Drawing.Size(321, 25);
            this.UNInstLabel.TabIndex = 49;
            this.UNInstLabel.Text = "Please enter your Username below:";
            // 
            // InstLabel
            // 
            this.InstLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InstLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstLabel.Location = new System.Drawing.Point(50, 14);
            this.InstLabel.Name = "InstLabel";
            this.InstLabel.Size = new System.Drawing.Size(346, 67);
            this.InstLabel.TabIndex = 56;
            this.InstLabel.Text = "Password Reminder";
            this.InstLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 218);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(408, 41);
            this.label2.TabIndex = 57;
            this.label2.Text = "Please answer your security question below:";
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 420);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InstLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CheckAnsBtn);
            this.Controls.Add(this.AnsTextBox);
            this.Controls.Add(this.QnsLabel);
            this.Controls.Add(this.SubmitUNBtn);
            this.Controls.Add(this.UNTextBox);
            this.Controls.Add(this.UNInstLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form8";
            this.Text = "Password Reminder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form8_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CheckAnsBtn;
        private System.Windows.Forms.TextBox AnsTextBox;
        private System.Windows.Forms.Label QnsLabel;
        private System.Windows.Forms.Button SubmitUNBtn;
        private System.Windows.Forms.TextBox UNTextBox;
        private System.Windows.Forms.Label UNInstLabel;
        private System.Windows.Forms.Label InstLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}