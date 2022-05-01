namespace Exercise_4___XML_Files
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
            this.SaveBtn = new System.Windows.Forms.Button();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.LocationTextBox = new System.Windows.Forms.TextBox();
            this.HeadingLabel = new System.Windows.Forms.Label();
            this.InstructionsLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.LocationHeadingLabel = new System.Windows.Forms.Label();
            this.PriceHeadingLabel = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchNameTB = new System.Windows.Forms.Label();
            this.LocationLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.PriceHeadingLabel2 = new System.Windows.Forms.Label();
            this.LocationHeadingLabel2 = new System.Windows.Forms.Label();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(87, 243);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(166, 51);
            this.SaveBtn.TabIndex = 4;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(164, 114);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(107, 20);
            this.NameTextBox.TabIndex = 1;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(164, 197);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(108, 20);
            this.PriceTextBox.TabIndex = 3;
            // 
            // LocationTextBox
            // 
            this.LocationTextBox.Location = new System.Drawing.Point(164, 157);
            this.LocationTextBox.Name = "LocationTextBox";
            this.LocationTextBox.Size = new System.Drawing.Size(108, 20);
            this.LocationTextBox.TabIndex = 2;
            // 
            // HeadingLabel
            // 
            this.HeadingLabel.AutoSize = true;
            this.HeadingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadingLabel.Location = new System.Drawing.Point(146, 28);
            this.HeadingLabel.Name = "HeadingLabel";
            this.HeadingLabel.Size = new System.Drawing.Size(85, 25);
            this.HeadingLabel.TabIndex = 4;
            this.HeadingLabel.Text = "Library";
            // 
            // InstructionsLabel
            // 
            this.InstructionsLabel.AutoSize = true;
            this.InstructionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructionsLabel.Location = new System.Drawing.Point(18, 85);
            this.InstructionsLabel.Name = "InstructionsLabel";
            this.InstructionsLabel.Size = new System.Drawing.Size(254, 15);
            this.InstructionsLabel.TabIndex = 5;
            this.InstructionsLabel.Text = "Please enter your book\'s details below";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(68, 117);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 6;
            this.NameLabel.Text = "Name";
            // 
            // LocationHeadingLabel
            // 
            this.LocationHeadingLabel.AutoSize = true;
            this.LocationHeadingLabel.Location = new System.Drawing.Point(68, 160);
            this.LocationHeadingLabel.Name = "LocationHeadingLabel";
            this.LocationHeadingLabel.Size = new System.Drawing.Size(48, 13);
            this.LocationHeadingLabel.TabIndex = 7;
            this.LocationHeadingLabel.Text = "Location";
            // 
            // PriceHeadingLabel
            // 
            this.PriceHeadingLabel.AutoSize = true;
            this.PriceHeadingLabel.Location = new System.Drawing.Point(68, 200);
            this.PriceHeadingLabel.Name = "PriceHeadingLabel";
            this.PriceHeadingLabel.Size = new System.Drawing.Size(31, 13);
            this.PriceHeadingLabel.TabIndex = 8;
            this.PriceHeadingLabel.Text = "Price";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(106, 353);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(126, 20);
            this.SearchTextBox.TabIndex = 5;
            // 
            // SearchNameTB
            // 
            this.SearchNameTB.AutoSize = true;
            this.SearchNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchNameTB.Location = new System.Drawing.Point(18, 323);
            this.SearchNameTB.Name = "SearchNameTB";
            this.SearchNameTB.Size = new System.Drawing.Size(346, 13);
            this.SearchNameTB.TabIndex = 10;
            this.SearchNameTB.Text = "Please enter the name of the book you want to search for :)";
            // 
            // LocationLabel
            // 
            this.LocationLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LocationLabel.Location = new System.Drawing.Point(157, 391);
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(114, 41);
            this.LocationLabel.TabIndex = 11;
            // 
            // PriceLabel
            // 
            this.PriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PriceLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PriceLabel.Location = new System.Drawing.Point(157, 447);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(114, 24);
            this.PriceLabel.TabIndex = 12;
            // 
            // PriceHeadingLabel2
            // 
            this.PriceHeadingLabel2.AutoSize = true;
            this.PriceHeadingLabel2.Location = new System.Drawing.Point(68, 448);
            this.PriceHeadingLabel2.Name = "PriceHeadingLabel2";
            this.PriceHeadingLabel2.Size = new System.Drawing.Size(31, 13);
            this.PriceHeadingLabel2.TabIndex = 14;
            this.PriceHeadingLabel2.Text = "Price";
            // 
            // LocationHeadingLabel2
            // 
            this.LocationHeadingLabel2.AutoSize = true;
            this.LocationHeadingLabel2.Location = new System.Drawing.Point(68, 403);
            this.LocationHeadingLabel2.Name = "LocationHeadingLabel2";
            this.LocationHeadingLabel2.Size = new System.Drawing.Size(48, 13);
            this.LocationHeadingLabel2.TabIndex = 13;
            this.LocationHeadingLabel2.Text = "Location";
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(87, 489);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(166, 51);
            this.SearchBtn.TabIndex = 6;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 580);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.PriceHeadingLabel2);
            this.Controls.Add(this.LocationHeadingLabel2);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.LocationLabel);
            this.Controls.Add(this.SearchNameTB);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.PriceHeadingLabel);
            this.Controls.Add(this.LocationHeadingLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.InstructionsLabel);
            this.Controls.Add(this.HeadingLabel);
            this.Controls.Add(this.LocationTextBox);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.SaveBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.TextBox LocationTextBox;
        private System.Windows.Forms.Label HeadingLabel;
        private System.Windows.Forms.Label InstructionsLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label LocationHeadingLabel;
        private System.Windows.Forms.Label PriceHeadingLabel;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label SearchNameTB;
        private System.Windows.Forms.Label LocationLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label PriceHeadingLabel2;
        private System.Windows.Forms.Label LocationHeadingLabel2;
        private System.Windows.Forms.Button SearchBtn;
    }
}

