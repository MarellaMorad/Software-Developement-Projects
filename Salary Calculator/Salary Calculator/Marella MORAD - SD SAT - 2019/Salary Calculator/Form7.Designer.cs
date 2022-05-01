namespace Marella_MORAD___SD_SAT___2019
{
    partial class Form7
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
            this.InstLabel = new System.Windows.Forms.Label();
            this.DABtn = new System.Windows.Forms.Button();
            this.DisplayBtn = new System.Windows.Forms.Button();
            this.PayLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.WAListBox = new System.Windows.Forms.ListBox();
            this.MonthRB = new System.Windows.Forms.RadioButton();
            this.WeekRB = new System.Windows.Forms.RadioButton();
            this.DayRB = new System.Windows.Forms.RadioButton();
            this.PayInstLabel = new System.Windows.Forms.Label();
            this.PayTextBox = new System.Windows.Forms.TextBox();
            this.HrsInstLabel = new System.Windows.Forms.Label();
            this.HeadLabel = new System.Windows.Forms.Label();
            this.CalcBtn = new System.Windows.Forms.Button();
            this.Intlabel = new System.Windows.Forms.Label();
            this.PRLabel = new System.Windows.Forms.Label();
            this.PRListBox = new System.Windows.Forms.ListBox();
            this.SkipBackBtn = new System.Windows.Forms.Button();
            this.PayDisplay = new System.Windows.Forms.Label();
            this.ChangeBtn = new System.Windows.Forms.Button();
            this.PayAmountDisplay = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.NoChangeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InstLabel
            // 
            this.InstLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstLabel.ForeColor = System.Drawing.Color.Blue;
            this.InstLabel.Location = new System.Drawing.Point(4, 101);
            this.InstLabel.Name = "InstLabel";
            this.InstLabel.Size = new System.Drawing.Size(558, 116);
            this.InstLabel.TabIndex = 39;
            this.InstLabel.Text = "Today\'s SALARY has already been calculated\r\nIf you wish to Display the results, p" +
    "lease follow the instructions below\r\n";
            this.InstLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DABtn
            // 
            this.DABtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DABtn.Location = new System.Drawing.Point(202, 326);
            this.DABtn.Name = "DABtn";
            this.DABtn.Size = new System.Drawing.Size(158, 38);
            this.DABtn.TabIndex = 6;
            this.DABtn.Text = "Display Analysis";
            this.toolTip1.SetToolTip(this.DABtn, "Click to diplay your working analysis");
            this.DABtn.UseVisualStyleBackColor = true;
            this.DABtn.Click += new System.EventHandler(this.DABtn_Click);
            // 
            // DisplayBtn
            // 
            this.DisplayBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayBtn.Location = new System.Drawing.Point(459, 263);
            this.DisplayBtn.Name = "DisplayBtn";
            this.DisplayBtn.Size = new System.Drawing.Size(88, 38);
            this.DisplayBtn.TabIndex = 5;
            this.DisplayBtn.Text = "Display";
            this.toolTip1.SetToolTip(this.DisplayBtn, "Click to display your salary");
            this.DisplayBtn.UseVisualStyleBackColor = true;
            this.DisplayBtn.Click += new System.EventHandler(this.DisplayBtn_Click);
            // 
            // PayLabel
            // 
            this.PayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayLabel.Location = new System.Drawing.Point(207, 252);
            this.PayLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PayLabel.Name = "PayLabel";
            this.PayLabel.Size = new System.Drawing.Size(214, 71);
            this.PayLabel.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 381);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 22);
            this.label1.TabIndex = 33;
            this.label1.Text = "Weekly Achievement:";
            // 
            // WAListBox
            // 
            this.WAListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WAListBox.FormattingEnabled = true;
            this.WAListBox.ItemHeight = 16;
            this.WAListBox.Location = new System.Drawing.Point(23, 406);
            this.WAListBox.Name = "WAListBox";
            this.WAListBox.Size = new System.Drawing.Size(366, 100);
            this.WAListBox.TabIndex = 32;
            // 
            // MonthRB
            // 
            this.MonthRB.AutoSize = true;
            this.MonthRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthRB.Location = new System.Drawing.Point(55, 309);
            this.MonthRB.Name = "MonthRB";
            this.MonthRB.Size = new System.Drawing.Size(68, 22);
            this.MonthRB.TabIndex = 4;
            this.MonthRB.TabStop = true;
            this.MonthRB.Text = "Month";
            this.toolTip1.SetToolTip(this.MonthRB, "Choose to display your salary for this month");
            this.MonthRB.UseVisualStyleBackColor = true;
            // 
            // WeekRB
            // 
            this.WeekRB.AutoSize = true;
            this.WeekRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeekRB.Location = new System.Drawing.Point(55, 280);
            this.WeekRB.Name = "WeekRB";
            this.WeekRB.Size = new System.Drawing.Size(65, 22);
            this.WeekRB.TabIndex = 3;
            this.WeekRB.TabStop = true;
            this.WeekRB.Text = "Week";
            this.toolTip1.SetToolTip(this.WeekRB, "Choose to display your salary for this week");
            this.WeekRB.UseVisualStyleBackColor = true;
            // 
            // DayRB
            // 
            this.DayRB.AutoSize = true;
            this.DayRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DayRB.Location = new System.Drawing.Point(55, 252);
            this.DayRB.Name = "DayRB";
            this.DayRB.Size = new System.Drawing.Size(52, 22);
            this.DayRB.TabIndex = 2;
            this.DayRB.TabStop = true;
            this.DayRB.Text = "Day";
            this.toolTip1.SetToolTip(this.DayRB, "Choose to display your Salary per day");
            this.DayRB.UseVisualStyleBackColor = true;
            // 
            // PayInstLabel
            // 
            this.PayInstLabel.AutoSize = true;
            this.PayInstLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayInstLabel.Location = new System.Drawing.Point(23, 222);
            this.PayInstLabel.Name = "PayInstLabel";
            this.PayInstLabel.Size = new System.Drawing.Size(426, 18);
            this.PayInstLabel.TabIndex = 28;
            this.PayInstLabel.Text = "Please select a format in which you want to Display your Salary:\r\n";
            // 
            // PayTextBox
            // 
            this.PayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayTextBox.Location = new System.Drawing.Point(295, 101);
            this.PayTextBox.Name = "PayTextBox";
            this.PayTextBox.Size = new System.Drawing.Size(151, 24);
            this.PayTextBox.TabIndex = 0;
            this.toolTip1.SetToolTip(this.PayTextBox, "Enter your pay per hour");
            // 
            // HrsInstLabel
            // 
            this.HrsInstLabel.AutoSize = true;
            this.HrsInstLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HrsInstLabel.Location = new System.Drawing.Point(19, 103);
            this.HrsInstLabel.Name = "HrsInstLabel";
            this.HrsInstLabel.Size = new System.Drawing.Size(267, 18);
            this.HrsInstLabel.TabIndex = 27;
            this.HrsInstLabel.Text = "Please enter the pay per hour in dollars:";
            // 
            // HeadLabel
            // 
            this.HeadLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HeadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadLabel.Location = new System.Drawing.Point(135, 6);
            this.HeadLabel.Name = "HeadLabel";
            this.HeadLabel.Size = new System.Drawing.Size(304, 46);
            this.HeadLabel.TabIndex = 26;
            this.HeadLabel.Text = "Job Salary Calculator";
            this.HeadLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CalcBtn
            // 
            this.CalcBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalcBtn.Location = new System.Drawing.Point(211, 144);
            this.CalcBtn.Name = "CalcBtn";
            this.CalcBtn.Size = new System.Drawing.Size(149, 53);
            this.CalcBtn.TabIndex = 1;
            this.CalcBtn.Text = "Calculate";
            this.toolTip1.SetToolTip(this.CalcBtn, "Click to Calculate your salary");
            this.CalcBtn.UseVisualStyleBackColor = true;
            this.CalcBtn.Click += new System.EventHandler(this.CalcBtn_Click);
            // 
            // Intlabel
            // 
            this.Intlabel.AutoSize = true;
            this.Intlabel.ForeColor = System.Drawing.Color.Red;
            this.Intlabel.Location = new System.Drawing.Point(394, 406);
            this.Intlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Intlabel.Name = "Intlabel";
            this.Intlabel.Size = new System.Drawing.Size(99, 13);
            this.Intlabel.TabIndex = 43;
            this.Intlabel.Text = "*Lowest --> Highest";
            // 
            // PRLabel
            // 
            this.PRLabel.AutoSize = true;
            this.PRLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PRLabel.Location = new System.Drawing.Point(394, 385);
            this.PRLabel.Name = "PRLabel";
            this.PRLabel.Size = new System.Drawing.Size(168, 18);
            this.PRLabel.TabIndex = 42;
            this.PRLabel.Text = "Pay Ranking - per week:";
            // 
            // PRListBox
            // 
            this.PRListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PRListBox.FormattingEnabled = true;
            this.PRListBox.ItemHeight = 16;
            this.PRListBox.Location = new System.Drawing.Point(397, 422);
            this.PRListBox.Name = "PRListBox";
            this.PRListBox.Size = new System.Drawing.Size(165, 84);
            this.PRListBox.TabIndex = 41;
            // 
            // SkipBackBtn
            // 
            this.SkipBackBtn.Location = new System.Drawing.Point(8, 511);
            this.SkipBackBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SkipBackBtn.Name = "SkipBackBtn";
            this.SkipBackBtn.Size = new System.Drawing.Size(63, 28);
            this.SkipBackBtn.TabIndex = 44;
            this.SkipBackBtn.Text = "<-- Back";
            this.toolTip1.SetToolTip(this.SkipBackBtn, "Click to go back to Finish time page");
            this.SkipBackBtn.UseVisualStyleBackColor = true;
            this.SkipBackBtn.Click += new System.EventHandler(this.SkipBackBtn_Click);
            // 
            // PayDisplay
            // 
            this.PayDisplay.AutoSize = true;
            this.PayDisplay.BackColor = System.Drawing.Color.Transparent;
            this.PayDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayDisplay.Location = new System.Drawing.Point(29, 101);
            this.PayDisplay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PayDisplay.Name = "PayDisplay";
            this.PayDisplay.Size = new System.Drawing.Size(248, 36);
            this.PayDisplay.TabIndex = 45;
            this.PayDisplay.Text = "\"Your recorded pay per hour is          \r\nwould like to change it?";
            // 
            // ChangeBtn
            // 
            this.ChangeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeBtn.Location = new System.Drawing.Point(329, 101);
            this.ChangeBtn.Name = "ChangeBtn";
            this.ChangeBtn.Size = new System.Drawing.Size(80, 38);
            this.ChangeBtn.TabIndex = 0;
            this.ChangeBtn.Text = "Yes";
            this.toolTip1.SetToolTip(this.ChangeBtn, "Click to change your pay per hour");
            this.ChangeBtn.UseVisualStyleBackColor = true;
            this.ChangeBtn.Click += new System.EventHandler(this.ChangeBtn_Click);
            // 
            // PayAmountDisplay
            // 
            this.PayAmountDisplay.AutoSize = true;
            this.PayAmountDisplay.BackColor = System.Drawing.Color.Transparent;
            this.PayAmountDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayAmountDisplay.Location = new System.Drawing.Point(234, 101);
            this.PayAmountDisplay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PayAmountDisplay.Name = "PayAmountDisplay";
            this.PayAmountDisplay.Size = new System.Drawing.Size(43, 18);
            this.PayAmountDisplay.TabIndex = 46;
            this.PayAmountDisplay.Text = "label";
            // 
            // DateLabel
            // 
            this.DateLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(319, 66);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(130, 25);
            this.DateLabel.TabIndex = 47;
            this.DateLabel.Text = "DATE";
            this.DateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.DateLabel, "Today\'s date");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(114, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 18);
            this.label2.TabIndex = 48;
            this.label2.Text = "The data displayed are for:\r\n";
            // 
            // NoChangeBtn
            // 
            this.NoChangeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoChangeBtn.Location = new System.Drawing.Point(427, 101);
            this.NoChangeBtn.Name = "NoChangeBtn";
            this.NoChangeBtn.Size = new System.Drawing.Size(80, 38);
            this.NoChangeBtn.TabIndex = 49;
            this.NoChangeBtn.Text = "No";
            this.toolTip1.SetToolTip(this.NoChangeBtn, "Click to use the reocrded pay per hour");
            this.NoChangeBtn.UseVisualStyleBackColor = true;
            this.NoChangeBtn.Click += new System.EventHandler(this.NoChangeBtn_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(574, 543);
            this.Controls.Add(this.InstLabel);
            this.Controls.Add(this.CalcBtn);
            this.Controls.Add(this.NoChangeBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.PayAmountDisplay);
            this.Controls.Add(this.ChangeBtn);
            this.Controls.Add(this.PayDisplay);
            this.Controls.Add(this.SkipBackBtn);
            this.Controls.Add(this.Intlabel);
            this.Controls.Add(this.PRLabel);
            this.Controls.Add(this.PRListBox);
            this.Controls.Add(this.DABtn);
            this.Controls.Add(this.DisplayBtn);
            this.Controls.Add(this.PayLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WAListBox);
            this.Controls.Add(this.MonthRB);
            this.Controls.Add(this.WeekRB);
            this.Controls.Add(this.DayRB);
            this.Controls.Add(this.PayInstLabel);
            this.Controls.Add(this.PayTextBox);
            this.Controls.Add(this.HrsInstLabel);
            this.Controls.Add(this.HeadLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form7";
            this.Text = "Job Salary Calculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form7_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InstLabel;
        private System.Windows.Forms.Button DABtn;
        private System.Windows.Forms.Button DisplayBtn;
        private System.Windows.Forms.Label PayLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox WAListBox;
        private System.Windows.Forms.RadioButton MonthRB;
        private System.Windows.Forms.RadioButton WeekRB;
        private System.Windows.Forms.RadioButton DayRB;
        private System.Windows.Forms.Label PayInstLabel;
        private System.Windows.Forms.TextBox PayTextBox;
        private System.Windows.Forms.Label HrsInstLabel;
        private System.Windows.Forms.Label HeadLabel;
        private System.Windows.Forms.Button CalcBtn;
        private System.Windows.Forms.Label Intlabel;
        private System.Windows.Forms.Label PRLabel;
        private System.Windows.Forms.ListBox PRListBox;
        private System.Windows.Forms.Button SkipBackBtn;
        private System.Windows.Forms.Label PayDisplay;
        private System.Windows.Forms.Button ChangeBtn;
        private System.Windows.Forms.Label PayAmountDisplay;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button NoChangeBtn;
    }
}