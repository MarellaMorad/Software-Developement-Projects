namespace Marella_MORAD___SD_SAT___2019
{
    partial class Form2
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
            this.SkipBtn = new System.Windows.Forms.Button();
            this.ShowConPass = new System.Windows.Forms.Button();
            this.HideConPass = new System.Windows.Forms.Button();
            this.HidePass = new System.Windows.Forms.Button();
            this.ShowPass = new System.Windows.Forms.Button();
            this.InstLabel = new System.Windows.Forms.Label();
            this.ConPassTextBox = new System.Windows.Forms.TextBox();
            this.PassTextBox = new System.Windows.Forms.TextBox();
            this.UNTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PassLabel = new System.Windows.Forms.Label();
            this.UNLabel = new System.Windows.Forms.Label();
            this.HeadLabel = new System.Windows.Forms.Label();
            this.SignUpBtn = new System.Windows.Forms.Button();
            this.SQLabel = new System.Windows.Forms.Label();
            this.SQcomboBox = new System.Windows.Forms.ComboBox();
            this.QnsTextBox = new System.Windows.Forms.TextBox();
            this.AnsTextBox = new System.Windows.Forms.TextBox();
            this.AnsLabel = new System.Windows.Forms.Label();
            this.QnsLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.InfoBtn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // SkipBtn
            // 
            this.SkipBtn.Location = new System.Drawing.Point(374, 385);
            this.SkipBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SkipBtn.Name = "SkipBtn";
            this.SkipBtn.Size = new System.Drawing.Size(74, 28);
            this.SkipBtn.TabIndex = 6;
            this.SkipBtn.Text = "Forward -->";
            this.toolTip1.SetToolTip(this.SkipBtn, "Click to go to the Login page");
            this.SkipBtn.UseVisualStyleBackColor = true;
            this.SkipBtn.Click += new System.EventHandler(this.SkipBtn_Click);
            // 
            // ShowConPass
            // 
            this.ShowConPass.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.ShowConPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowConPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowConPass.ForeColor = System.Drawing.Color.Blue;
            this.ShowConPass.Location = new System.Drawing.Point(381, 144);
            this.ShowConPass.Name = "ShowConPass";
            this.ShowConPass.Size = new System.Drawing.Size(51, 29);
            this.ShowConPass.TabIndex = 28;
            this.ShowConPass.Text = "Show";
            this.toolTip1.SetToolTip(this.ShowConPass, "Converts your password back to normal charcters");
            this.ShowConPass.UseVisualStyleBackColor = true;
            this.ShowConPass.Click += new System.EventHandler(this.ShowConPass_Click);
            // 
            // HideConPass
            // 
            this.HideConPass.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.HideConPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HideConPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HideConPass.ForeColor = System.Drawing.Color.Blue;
            this.HideConPass.Location = new System.Drawing.Point(381, 142);
            this.HideConPass.Name = "HideConPass";
            this.HideConPass.Size = new System.Drawing.Size(51, 24);
            this.HideConPass.TabIndex = 27;
            this.HideConPass.Text = "Hide";
            this.toolTip1.SetToolTip(this.HideConPass, "Convert your password into dots");
            this.HideConPass.UseVisualStyleBackColor = true;
            this.HideConPass.Click += new System.EventHandler(this.HideConPass_Click);
            // 
            // HidePass
            // 
            this.HidePass.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.HidePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HidePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HidePass.ForeColor = System.Drawing.Color.Blue;
            this.HidePass.Location = new System.Drawing.Point(397, 109);
            this.HidePass.Name = "HidePass";
            this.HidePass.Size = new System.Drawing.Size(51, 29);
            this.HidePass.TabIndex = 26;
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
            this.ShowPass.Location = new System.Drawing.Point(397, 108);
            this.ShowPass.Name = "ShowPass";
            this.ShowPass.Size = new System.Drawing.Size(51, 29);
            this.ShowPass.TabIndex = 25;
            this.ShowPass.Text = "Show";
            this.toolTip1.SetToolTip(this.ShowPass, "Converts your password back to normal charcters");
            this.ShowPass.UseVisualStyleBackColor = true;
            this.ShowPass.Click += new System.EventHandler(this.ShowPass_Click);
            // 
            // InstLabel
            // 
            this.InstLabel.ForeColor = System.Drawing.Color.Red;
            this.InstLabel.Location = new System.Drawing.Point(27, 189);
            this.InstLabel.Name = "InstLabel";
            this.InstLabel.Size = new System.Drawing.Size(391, 35);
            this.InstLabel.TabIndex = 24;
            this.InstLabel.Text = "*Please note that any characters are accepted to be used except for spaces\r\nbe ca" +
    "reful it’s a case sensitive app! [i.e. UPPERCASE or lowercase letters matter]";
            // 
            // ConPassTextBox
            // 
            this.ConPassTextBox.Location = new System.Drawing.Point(187, 149);
            this.ConPassTextBox.Name = "ConPassTextBox";
            this.ConPassTextBox.Size = new System.Drawing.Size(188, 20);
            this.ConPassTextBox.TabIndex = 2;
            this.toolTip1.SetToolTip(this.ConPassTextBox, "Enter your confirmation Password here");
            this.ConPassTextBox.UseSystemPasswordChar = true;
            // 
            // PassTextBox
            // 
            this.PassTextBox.Location = new System.Drawing.Point(187, 112);
            this.PassTextBox.Name = "PassTextBox";
            this.PassTextBox.Size = new System.Drawing.Size(188, 20);
            this.PassTextBox.TabIndex = 1;
            this.toolTip1.SetToolTip(this.PassTextBox, "Enter your Password here");
            this.PassTextBox.UseSystemPasswordChar = true;
            // 
            // UNTextBox
            // 
            this.UNTextBox.Location = new System.Drawing.Point(187, 79);
            this.UNTextBox.Name = "UNTextBox";
            this.UNTextBox.Size = new System.Drawing.Size(188, 20);
            this.UNTextBox.TabIndex = 0;
            this.toolTip1.SetToolTip(this.UNTextBox, "Enter your Username here");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 18);
            this.label2.TabIndex = 23;
            this.label2.Text = "Confirm Password:";
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassLabel.Location = new System.Drawing.Point(94, 112);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(88, 18);
            this.PassLabel.TabIndex = 21;
            this.PassLabel.Text = "Password:";
            // 
            // UNLabel
            // 
            this.UNLabel.AutoSize = true;
            this.UNLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UNLabel.Location = new System.Drawing.Point(91, 77);
            this.UNLabel.Name = "UNLabel";
            this.UNLabel.Size = new System.Drawing.Size(90, 18);
            this.UNLabel.TabIndex = 20;
            this.UNLabel.Text = "Username:";
            // 
            // HeadLabel
            // 
            this.HeadLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HeadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadLabel.Location = new System.Drawing.Point(113, 16);
            this.HeadLabel.Name = "HeadLabel";
            this.HeadLabel.Size = new System.Drawing.Size(234, 47);
            this.HeadLabel.TabIndex = 18;
            this.HeadLabel.Text = "SignUp Page";
            this.HeadLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SignUpBtn
            // 
            this.SignUpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpBtn.Location = new System.Drawing.Point(157, 345);
            this.SignUpBtn.Name = "SignUpBtn";
            this.SignUpBtn.Size = new System.Drawing.Size(147, 47);
            this.SignUpBtn.TabIndex = 5;
            this.SignUpBtn.Text = "SignUp";
            this.toolTip1.SetToolTip(this.SignUpBtn, "Click to Save your details and go to the selection page");
            this.SignUpBtn.UseVisualStyleBackColor = true;
            this.SignUpBtn.Click += new System.EventHandler(this.SignUpBtn_Click);
            // 
            // SQLabel
            // 
            this.SQLabel.AutoSize = true;
            this.SQLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SQLabel.Location = new System.Drawing.Point(30, 224);
            this.SQLabel.Name = "SQLabel";
            this.SQLabel.Size = new System.Drawing.Size(143, 18);
            this.SQLabel.TabIndex = 32;
            this.SQLabel.Text = "Security question:";
            // 
            // SQcomboBox
            // 
            this.SQcomboBox.FormattingEnabled = true;
            this.SQcomboBox.Location = new System.Drawing.Point(76, 251);
            this.SQcomboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SQcomboBox.Name = "SQcomboBox";
            this.SQcomboBox.Size = new System.Drawing.Size(298, 21);
            this.SQcomboBox.TabIndex = 3;
            this.SQcomboBox.Text = "Please choose a question...";
            this.toolTip1.SetToolTip(this.SQcomboBox, "There is a list of security question that you can choose from.\r\nYou can write you" +
        "r own of you don\'t like any of them.");
            this.SQcomboBox.SelectedIndexChanged += new System.EventHandler(this.SQcomboBox_SelectedIndexChanged);
            // 
            // QnsTextBox
            // 
            this.QnsTextBox.Location = new System.Drawing.Point(184, 276);
            this.QnsTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.QnsTextBox.Name = "QnsTextBox";
            this.QnsTextBox.Size = new System.Drawing.Size(188, 20);
            this.QnsTextBox.TabIndex = 4;
            this.toolTip1.SetToolTip(this.QnsTextBox, "Enter your question here");
            this.QnsTextBox.TextChanged += new System.EventHandler(this.QnsTextBox_TextChanged);
            // 
            // AnsTextBox
            // 
            this.AnsTextBox.Location = new System.Drawing.Point(184, 297);
            this.AnsTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AnsTextBox.Name = "AnsTextBox";
            this.AnsTextBox.Size = new System.Drawing.Size(187, 20);
            this.AnsTextBox.TabIndex = 5;
            this.toolTip1.SetToolTip(this.AnsTextBox, "Enter your anser here");
            // 
            // AnsLabel
            // 
            this.AnsLabel.AutoSize = true;
            this.AnsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnsLabel.Location = new System.Drawing.Point(108, 296);
            this.AnsLabel.Name = "AnsLabel";
            this.AnsLabel.Size = new System.Drawing.Size(68, 18);
            this.AnsLabel.TabIndex = 36;
            this.AnsLabel.Text = "Answer:";
            // 
            // QnsLabel
            // 
            this.QnsLabel.AutoSize = true;
            this.QnsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QnsLabel.Location = new System.Drawing.Point(97, 275);
            this.QnsLabel.Name = "QnsLabel";
            this.QnsLabel.Size = new System.Drawing.Size(81, 18);
            this.QnsLabel.TabIndex = 37;
            this.QnsLabel.Text = "Question:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(181, 319);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "*be careful! It\'s a case sensitive app";
            // 
            // InfoBtn
            // 
            this.InfoBtn.Location = new System.Drawing.Point(381, 112);
            this.InfoBtn.Name = "InfoBtn";
            this.InfoBtn.Size = new System.Drawing.Size(19, 21);
            this.InfoBtn.TabIndex = 39;
            this.InfoBtn.Text = "?";
            this.toolTip1.SetToolTip(this.InfoBtn, "Click if you need help?");
            this.InfoBtn.UseVisualStyleBackColor = true;
            this.InfoBtn.Click += new System.EventHandler(this.InfoBtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 423);
            this.Controls.Add(this.InfoBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.QnsLabel);
            this.Controls.Add(this.AnsLabel);
            this.Controls.Add(this.AnsTextBox);
            this.Controls.Add(this.QnsTextBox);
            this.Controls.Add(this.SQcomboBox);
            this.Controls.Add(this.SQLabel);
            this.Controls.Add(this.SkipBtn);
            this.Controls.Add(this.ShowConPass);
            this.Controls.Add(this.HideConPass);
            this.Controls.Add(this.HidePass);
            this.Controls.Add(this.ShowPass);
            this.Controls.Add(this.InstLabel);
            this.Controls.Add(this.ConPassTextBox);
            this.Controls.Add(this.PassTextBox);
            this.Controls.Add(this.UNTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PassLabel);
            this.Controls.Add(this.UNLabel);
            this.Controls.Add(this.HeadLabel);
            this.Controls.Add(this.SignUpBtn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form2";
            this.Text = "SignUp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SkipBtn;
        private System.Windows.Forms.Button ShowConPass;
        private System.Windows.Forms.Button HideConPass;
        private System.Windows.Forms.Button HidePass;
        private System.Windows.Forms.Button ShowPass;
        private System.Windows.Forms.Label InstLabel;
        private System.Windows.Forms.TextBox ConPassTextBox;
        private System.Windows.Forms.TextBox PassTextBox;
        private System.Windows.Forms.TextBox UNTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label PassLabel;
        private System.Windows.Forms.Label UNLabel;
        private System.Windows.Forms.Label HeadLabel;
        private System.Windows.Forms.Button SignUpBtn;
        private System.Windows.Forms.Label SQLabel;
        private System.Windows.Forms.ComboBox SQcomboBox;
        private System.Windows.Forms.TextBox QnsTextBox;
        private System.Windows.Forms.TextBox AnsTextBox;
        private System.Windows.Forms.Label AnsLabel;
        private System.Windows.Forms.Label QnsLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button InfoBtn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}