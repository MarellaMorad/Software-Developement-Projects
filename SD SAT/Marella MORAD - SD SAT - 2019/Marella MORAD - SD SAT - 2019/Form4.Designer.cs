namespace Marella_MORAD___SD_SAT___2019
{
    partial class Form4
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
            this.CalcBtn = new System.Windows.Forms.Button();
            this.IntLabel2 = new System.Windows.Forms.Label();
            this.InstLabel = new System.Windows.Forms.Label();
            this.FinishBtn = new System.Windows.Forms.Button();
            this.StartBtn = new System.Windows.Forms.Button();
            this.HeadLabel = new System.Windows.Forms.Label();
            this.HelpBtn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // CalcBtn
            // 
            this.CalcBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalcBtn.Location = new System.Drawing.Point(189, 319);
            this.CalcBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CalcBtn.Name = "CalcBtn";
            this.CalcBtn.Size = new System.Drawing.Size(159, 46);
            this.CalcBtn.TabIndex = 3;
            this.CalcBtn.Text = "CALCULATE";
            this.toolTip1.SetToolTip(this.CalcBtn, "Click to go to the Calculator page");
            this.CalcBtn.UseVisualStyleBackColor = true;
            this.CalcBtn.Click += new System.EventHandler(this.CalcBtn_Click);
            // 
            // IntLabel2
            // 
            this.IntLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntLabel2.Location = new System.Drawing.Point(23, 256);
            this.IntLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IntLabel2.Name = "IntLabel2";
            this.IntLabel2.Size = new System.Drawing.Size(518, 58);
            this.IntLabel2.TabIndex = 12;
            this.IntLabel2.Text = "*If you have already entered your START and FINISH time, you can go straight and " +
    "CALCULATE the pay!";
            // 
            // InstLabel
            // 
            this.InstLabel.AutoSize = true;
            this.InstLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstLabel.Location = new System.Drawing.Point(23, 114);
            this.InstLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InstLabel.Name = "InstLabel";
            this.InstLabel.Size = new System.Drawing.Size(518, 30);
            this.InstLabel.TabIndex = 11;
            this.InstLabel.Text = "Would you like to enter a start or finish time?";
            // 
            // FinishBtn
            // 
            this.FinishBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinishBtn.Location = new System.Drawing.Point(301, 174);
            this.FinishBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FinishBtn.Name = "FinishBtn";
            this.FinishBtn.Size = new System.Drawing.Size(234, 54);
            this.FinishBtn.TabIndex = 2;
            this.FinishBtn.Text = "FINISH";
            this.toolTip1.SetToolTip(this.FinishBtn, "Click to go to the Finish time page where you can enter your Finish time");
            this.FinishBtn.UseVisualStyleBackColor = true;
            this.FinishBtn.Click += new System.EventHandler(this.FinishBtn_Click);
            // 
            // StartBtn
            // 
            this.StartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartBtn.Location = new System.Drawing.Point(31, 174);
            this.StartBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(201, 54);
            this.StartBtn.TabIndex = 0;
            this.StartBtn.Text = "START";
            this.toolTip1.SetToolTip(this.StartBtn, "Click to go to the Start time page where you can record your Start time");
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // HeadLabel
            // 
            this.HeadLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HeadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadLabel.Location = new System.Drawing.Point(83, 19);
            this.HeadLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HeadLabel.Name = "HeadLabel";
            this.HeadLabel.Size = new System.Drawing.Size(403, 71);
            this.HeadLabel.TabIndex = 19;
            this.HeadLabel.Text = "Salary Calculator Selection";
            this.HeadLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HelpBtn
            // 
            this.HelpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpBtn.ForeColor = System.Drawing.Color.Blue;
            this.HelpBtn.Location = new System.Drawing.Point(432, 354);
            this.HelpBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HelpBtn.Name = "HelpBtn";
            this.HelpBtn.Size = new System.Drawing.Size(123, 37);
            this.HelpBtn.TabIndex = 32;
            this.HelpBtn.Text = "Need Help?";
            this.toolTip1.SetToolTip(this.HelpBtn, "Click if you need help");
            this.HelpBtn.UseVisualStyleBackColor = true;
            this.HelpBtn.Click += new System.EventHandler(this.HelpBtn_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 405);
            this.Controls.Add(this.HelpBtn);
            this.Controls.Add(this.HeadLabel);
            this.Controls.Add(this.CalcBtn);
            this.Controls.Add(this.IntLabel2);
            this.Controls.Add(this.InstLabel);
            this.Controls.Add(this.FinishBtn);
            this.Controls.Add(this.StartBtn);
            this.Name = "Form4";
            this.Text = "Start/Finish selection";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form4_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalcBtn;
        private System.Windows.Forms.Label IntLabel2;
        private System.Windows.Forms.Label InstLabel;
        private System.Windows.Forms.Button FinishBtn;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Label HeadLabel;
        private System.Windows.Forms.Button HelpBtn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}