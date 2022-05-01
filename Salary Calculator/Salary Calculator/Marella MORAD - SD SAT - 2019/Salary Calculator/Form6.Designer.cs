namespace Marella_MORAD___SD_SAT___2019
{
    partial class Form6
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
            this.Intlabel = new System.Windows.Forms.Label();
            this.ManTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ManRB = new System.Windows.Forms.RadioButton();
            this.AutoRB = new System.Windows.Forms.RadioButton();
            this.ManInstLabel = new System.Windows.Forms.Label();
            this.AutoInstLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.InstLabel = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.HeadLabel = new System.Windows.Forms.Label();
            this.SkipBtn = new System.Windows.Forms.Button();
            this.SkipBackBtn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // Intlabel
            // 
            this.Intlabel.AutoSize = true;
            this.Intlabel.ForeColor = System.Drawing.Color.Red;
            this.Intlabel.Location = new System.Drawing.Point(279, 437);
            this.Intlabel.Name = "Intlabel";
            this.Intlabel.Size = new System.Drawing.Size(174, 20);
            this.Intlabel.TabIndex = 35;
            this.Intlabel.Text = "*Time is in 24hrs format";
            // 
            // ManTimePicker
            // 
            this.ManTimePicker.CustomFormat = "HH:mm";
            this.ManTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ManTimePicker.Location = new System.Drawing.Point(283, 406);
            this.ManTimePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ManTimePicker.Name = "ManTimePicker";
            this.ManTimePicker.ShowUpDown = true;
            this.ManTimePicker.Size = new System.Drawing.Size(78, 26);
            this.ManTimePicker.TabIndex = 0;
            this.toolTip1.SetToolTip(this.ManTimePicker, "Use the up and down arrows to change the time.\r\nOr you can simply write the numbe" +
        "r down using your keyboard\r\n");
            this.ManTimePicker.Value = new System.DateTime(2019, 7, 2, 0, 0, 0, 0);
            // 
            // ManRB
            // 
            this.ManRB.AutoSize = true;
            this.ManRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManRB.Location = new System.Drawing.Point(318, 344);
            this.ManRB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ManRB.Name = "ManRB";
            this.ManRB.Size = new System.Drawing.Size(116, 33);
            this.ManRB.TabIndex = 2;
            this.ManRB.TabStop = true;
            this.ManRB.Text = "Manual";
            this.toolTip1.SetToolTip(this.ManRB, "Click to enter your time manually");
            this.ManRB.UseVisualStyleBackColor = true;
            // 
            // AutoRB
            // 
            this.AutoRB.AutoSize = true;
            this.AutoRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoRB.Location = new System.Drawing.Point(85, 344);
            this.AutoRB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AutoRB.Name = "AutoRB";
            this.AutoRB.Size = new System.Drawing.Size(86, 33);
            this.AutoRB.TabIndex = 1;
            this.AutoRB.TabStop = true;
            this.AutoRB.Text = "Auto";
            this.toolTip1.SetToolTip(this.AutoRB, "Click to enter your time automatically");
            this.AutoRB.UseVisualStyleBackColor = true;
            // 
            // ManInstLabel
            // 
            this.ManInstLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManInstLabel.Location = new System.Drawing.Point(279, 217);
            this.ManInstLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ManInstLabel.Name = "ManInstLabel";
            this.ManInstLabel.Size = new System.Drawing.Size(190, 134);
            this.ManInstLabel.TabIndex = 30;
            this.ManInstLabel.Text = "If your FINISH time is NOT now, please ENTER it below";
            // 
            // AutoInstLabel
            // 
            this.AutoInstLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoInstLabel.Location = new System.Drawing.Point(50, 217);
            this.AutoInstLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AutoInstLabel.Name = "AutoInstLabel";
            this.AutoInstLabel.Size = new System.Drawing.Size(180, 134);
            this.AutoInstLabel.TabIndex = 29;
            this.AutoInstLabel.Text = "If your FINISH time is now, please choose AUTO";
            // 
            // DateLabel
            // 
            this.DateLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(91, 152);
            this.DateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(341, 37);
            this.DateLabel.TabIndex = 10;
            this.DateLabel.Text = "DATE";
            this.DateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.DateLabel, "Today\'s date");
            // 
            // InstLabel
            // 
            this.InstLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstLabel.Location = new System.Drawing.Point(87, 120);
            this.InstLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InstLabel.Name = "InstLabel";
            this.InstLabel.Size = new System.Drawing.Size(345, 43);
            this.InstLabel.TabIndex = 27;
            this.InstLabel.Text = "Please record the finishing time for";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.Location = new System.Drawing.Point(159, 491);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(201, 54);
            this.SaveBtn.TabIndex = 3;
            this.SaveBtn.Text = "SAVE";
            this.toolTip1.SetToolTip(this.SaveBtn, "Click to Save");
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // HeadLabel
            // 
            this.HeadLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HeadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadLabel.Location = new System.Drawing.Point(95, 28);
            this.HeadLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HeadLabel.Name = "HeadLabel";
            this.HeadLabel.Size = new System.Drawing.Size(328, 70);
            this.HeadLabel.TabIndex = 38;
            this.HeadLabel.Text = "Finish Time";
            this.HeadLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SkipBtn
            // 
            this.SkipBtn.Location = new System.Drawing.Point(398, 564);
            this.SkipBtn.Name = "SkipBtn";
            this.SkipBtn.Size = new System.Drawing.Size(108, 43);
            this.SkipBtn.TabIndex = 39;
            this.SkipBtn.Text = "Forward -->";
            this.toolTip1.SetToolTip(this.SkipBtn, "Click to go to the Calculator page");
            this.SkipBtn.UseVisualStyleBackColor = true;
            this.SkipBtn.Click += new System.EventHandler(this.SkipBtn_Click);
            // 
            // SkipBackBtn
            // 
            this.SkipBackBtn.Location = new System.Drawing.Point(12, 564);
            this.SkipBackBtn.Name = "SkipBackBtn";
            this.SkipBackBtn.Size = new System.Drawing.Size(91, 43);
            this.SkipBackBtn.TabIndex = 40;
            this.SkipBackBtn.Text = "<-- Back";
            this.toolTip1.SetToolTip(this.SkipBackBtn, "Click to go to the Start time page");
            this.SkipBackBtn.UseVisualStyleBackColor = true;
            this.SkipBackBtn.Click += new System.EventHandler(this.SkipBackBtn_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 627);
            this.Controls.Add(this.SkipBackBtn);
            this.Controls.Add(this.SkipBtn);
            this.Controls.Add(this.HeadLabel);
            this.Controls.Add(this.Intlabel);
            this.Controls.Add(this.ManTimePicker);
            this.Controls.Add(this.ManRB);
            this.Controls.Add(this.AutoRB);
            this.Controls.Add(this.ManInstLabel);
            this.Controls.Add(this.AutoInstLabel);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.InstLabel);
            this.Controls.Add(this.SaveBtn);
            this.Name = "Form6";
            this.Text = "Finish time";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form6_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Intlabel;
        private System.Windows.Forms.DateTimePicker ManTimePicker;
        private System.Windows.Forms.RadioButton ManRB;
        private System.Windows.Forms.RadioButton AutoRB;
        private System.Windows.Forms.Label ManInstLabel;
        private System.Windows.Forms.Label AutoInstLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label InstLabel;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label HeadLabel;
        private System.Windows.Forms.Button SkipBtn;
        private System.Windows.Forms.Button SkipBackBtn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}