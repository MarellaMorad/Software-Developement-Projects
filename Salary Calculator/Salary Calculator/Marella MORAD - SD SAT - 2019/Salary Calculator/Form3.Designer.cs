namespace Marella_MORAD___SD_SAT___2019
{
    partial class Form3
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
            this.SkipBackBtn = new System.Windows.Forms.Button();
            this.HidePass = new System.Windows.Forms.Button();
            this.ShowPass = new System.Windows.Forms.Button();
            this.InstLabel = new System.Windows.Forms.Label();
            this.PassTextBox = new System.Windows.Forms.TextBox();
            this.UNTextBox = new System.Windows.Forms.TextBox();
            this.PassLabel = new System.Windows.Forms.Label();
            this.UNLabel = new System.Windows.Forms.Label();
            this.HeadLabel = new System.Windows.Forms.Label();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.ForgotPassBtn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // SkipBackBtn
            // 
            this.SkipBackBtn.Location = new System.Drawing.Point(13, 231);
            this.SkipBackBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SkipBackBtn.Name = "SkipBackBtn";
            this.SkipBackBtn.Size = new System.Drawing.Size(59, 28);
            this.SkipBackBtn.TabIndex = 4;
            this.SkipBackBtn.Text = "<-- Back\r\n";
            this.toolTip1.SetToolTip(this.SkipBackBtn, "Click to go back to the Signup page");
            this.SkipBackBtn.UseVisualStyleBackColor = true;
            this.SkipBackBtn.Click += new System.EventHandler(this.SkipBackBtn_Click);
            // 
            // HidePass
            // 
            this.HidePass.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.HidePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HidePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HidePass.ForeColor = System.Drawing.Color.Blue;
            this.HidePass.Location = new System.Drawing.Point(345, 109);
            this.HidePass.Name = "HidePass";
            this.HidePass.Size = new System.Drawing.Size(51, 29);
            this.HidePass.TabIndex = 25;
            this.HidePass.Text = "Hide";
            this.toolTip1.SetToolTip(this.HidePass, "Convert your password into dots");
            this.HidePass.UseVisualStyleBackColor = true;
            this.HidePass.Click += new System.EventHandler(this.HidePass_Click);
            // 
            // ShowPass
            // 
            this.ShowPass.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.ShowPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowPass.ForeColor = System.Drawing.Color.Blue;
            this.ShowPass.Location = new System.Drawing.Point(345, 109);
            this.ShowPass.Name = "ShowPass";
            this.ShowPass.Size = new System.Drawing.Size(51, 29);
            this.ShowPass.TabIndex = 24;
            this.ShowPass.Text = "Show";
            this.toolTip1.SetToolTip(this.ShowPass, "Converts your password back to normal charcters");
            this.ShowPass.UseVisualStyleBackColor = true;
            this.ShowPass.Click += new System.EventHandler(this.ShowPass_Click);
            // 
            // InstLabel
            // 
            this.InstLabel.ForeColor = System.Drawing.Color.Red;
            this.InstLabel.Location = new System.Drawing.Point(21, 159);
            this.InstLabel.Name = "InstLabel";
            this.InstLabel.Size = new System.Drawing.Size(390, 38);
            this.InstLabel.TabIndex = 23;
            this.InstLabel.Text = "*Please note that any characters are accepted to be used except for spaces\r\nbe ca" +
    "reful it’s a case sensitive app! [i.e. UPPERCASE or lowercase letters matter]\r\n\r" +
    "\n";
            // 
            // PassTextBox
            // 
            this.PassTextBox.Location = new System.Drawing.Point(153, 114);
            this.PassTextBox.Name = "PassTextBox";
            this.PassTextBox.Size = new System.Drawing.Size(188, 20);
            this.PassTextBox.TabIndex = 1;
            this.toolTip1.SetToolTip(this.PassTextBox, "Enter your Password here");
            this.PassTextBox.UseSystemPasswordChar = true;
            // 
            // UNTextBox
            // 
            this.UNTextBox.Location = new System.Drawing.Point(153, 81);
            this.UNTextBox.Name = "UNTextBox";
            this.UNTextBox.Size = new System.Drawing.Size(188, 20);
            this.UNTextBox.TabIndex = 0;
            this.toolTip1.SetToolTip(this.UNTextBox, "Enter your Username here");
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassLabel.Location = new System.Drawing.Point(60, 114);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(88, 18);
            this.PassLabel.TabIndex = 22;
            this.PassLabel.Text = "Password:";
            // 
            // UNLabel
            // 
            this.UNLabel.AutoSize = true;
            this.UNLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UNLabel.Location = new System.Drawing.Point(57, 81);
            this.UNLabel.Name = "UNLabel";
            this.UNLabel.Size = new System.Drawing.Size(90, 18);
            this.UNLabel.TabIndex = 21;
            this.UNLabel.Text = "Username:";
            // 
            // HeadLabel
            // 
            this.HeadLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HeadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadLabel.Location = new System.Drawing.Point(95, 18);
            this.HeadLabel.Name = "HeadLabel";
            this.HeadLabel.Size = new System.Drawing.Size(234, 47);
            this.HeadLabel.TabIndex = 20;
            this.HeadLabel.Text = "Login Page";
            this.HeadLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginBtn
            // 
            this.LoginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.Location = new System.Drawing.Point(151, 200);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(123, 41);
            this.LoginBtn.TabIndex = 2;
            this.LoginBtn.Text = "Login";
            this.toolTip1.SetToolTip(this.LoginBtn, "Click to go to the selection page");
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // ForgotPassBtn
            // 
            this.ForgotPassBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.ForgotPassBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ForgotPassBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForgotPassBtn.ForeColor = System.Drawing.Color.Blue;
            this.ForgotPassBtn.Location = new System.Drawing.Point(147, 127);
            this.ForgotPassBtn.Name = "ForgotPassBtn";
            this.ForgotPassBtn.Size = new System.Drawing.Size(135, 29);
            this.ForgotPassBtn.TabIndex = 3;
            this.ForgotPassBtn.Text = "Forgot your password?";
            this.toolTip1.SetToolTip(this.ForgotPassBtn, "Click if you have forgotten your Password");
            this.ForgotPassBtn.UseVisualStyleBackColor = true;
            this.ForgotPassBtn.Click += new System.EventHandler(this.ForgotPassBtn_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 266);
            this.Controls.Add(this.SkipBackBtn);
            this.Controls.Add(this.HidePass);
            this.Controls.Add(this.ShowPass);
            this.Controls.Add(this.InstLabel);
            this.Controls.Add(this.PassTextBox);
            this.Controls.Add(this.UNTextBox);
            this.Controls.Add(this.PassLabel);
            this.Controls.Add(this.UNLabel);
            this.Controls.Add(this.HeadLabel);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.ForgotPassBtn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form3";
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SkipBackBtn;
        private System.Windows.Forms.Button HidePass;
        private System.Windows.Forms.Button ShowPass;
        private System.Windows.Forms.Label InstLabel;
        private System.Windows.Forms.TextBox PassTextBox;
        private System.Windows.Forms.TextBox UNTextBox;
        private System.Windows.Forms.Label PassLabel;
        private System.Windows.Forms.Label UNLabel;
        private System.Windows.Forms.Label HeadLabel;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Button ForgotPassBtn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}