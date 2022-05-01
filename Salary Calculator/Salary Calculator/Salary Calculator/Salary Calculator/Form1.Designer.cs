namespace Marella_MORAD___SD_SAT___2019
{
    partial class Membership
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
            this.ExistBtn = new System.Windows.Forms.Button();
            this.InstLabel = new System.Windows.Forms.Label();
            this.NewBtn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.HeadLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ExistBtn
            // 
            this.ExistBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExistBtn.Location = new System.Drawing.Point(341, 175);
            this.ExistBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ExistBtn.Name = "ExistBtn";
            this.ExistBtn.Size = new System.Drawing.Size(234, 54);
            this.ExistBtn.TabIndex = 1;
            this.ExistBtn.Text = "Existing member";
            this.toolTip1.SetToolTip(this.ExistBtn, "Click to go to the Login page");
            this.ExistBtn.UseVisualStyleBackColor = true;
            this.ExistBtn.Click += new System.EventHandler(this.ExistBtn_Click);
            // 
            // InstLabel
            // 
            this.InstLabel.AutoSize = true;
            this.InstLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstLabel.Location = new System.Drawing.Point(12, 108);
            this.InstLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InstLabel.Name = "InstLabel";
            this.InstLabel.Size = new System.Drawing.Size(617, 30);
            this.InstLabel.TabIndex = 5;
            this.InstLabel.Text = "Are you a New or an Existing member to the system?";
            // 
            // NewBtn
            // 
            this.NewBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewBtn.Location = new System.Drawing.Point(71, 175);
            this.NewBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NewBtn.Name = "NewBtn";
            this.NewBtn.Size = new System.Drawing.Size(201, 54);
            this.NewBtn.TabIndex = 0;
            this.NewBtn.Text = "New member";
            this.toolTip1.SetToolTip(this.NewBtn, "Click to go to the Signup page");
            this.NewBtn.UseVisualStyleBackColor = true;
            this.NewBtn.Click += new System.EventHandler(this.NewBtn_Click);
            // 
            // HeadLabel
            // 
            this.HeadLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HeadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadLabel.Location = new System.Drawing.Point(180, 23);
            this.HeadLabel.Name = "HeadLabel";
            this.HeadLabel.Size = new System.Drawing.Size(278, 67);
            this.HeadLabel.TabIndex = 57;
            this.HeadLabel.Text = "Membership";
            this.HeadLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Membership
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 258);
            this.Controls.Add(this.HeadLabel);
            this.Controls.Add(this.ExistBtn);
            this.Controls.Add(this.InstLabel);
            this.Controls.Add(this.NewBtn);
            this.Name = "Membership";
            this.Text = "Membership";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExistBtn;
        private System.Windows.Forms.Label InstLabel;
        private System.Windows.Forms.Button NewBtn;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label HeadLabel;
    }
}

