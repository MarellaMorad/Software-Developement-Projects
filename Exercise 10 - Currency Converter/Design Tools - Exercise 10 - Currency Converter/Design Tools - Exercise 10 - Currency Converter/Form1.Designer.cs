namespace Design_Tools___Exercise_10___Currency_Converter
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
            this.label1 = new System.Windows.Forms.Label();
            this.AUDTxtBox = new System.Windows.Forms.TextBox();
            this.USRadioBtn = new System.Windows.Forms.RadioButton();
            this.UKRadioBtn = new System.Windows.Forms.RadioButton();
            this.EURadioBtn = new System.Windows.Forms.RadioButton();
            this.ConvertBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ConvertDisplayLabel = new System.Windows.Forms.Label();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amount in AUD";
            // 
            // AUDTxtBox
            // 
            this.AUDTxtBox.Location = new System.Drawing.Point(248, 62);
            this.AUDTxtBox.Name = "AUDTxtBox";
            this.AUDTxtBox.Size = new System.Drawing.Size(309, 26);
            this.AUDTxtBox.TabIndex = 1;
            // 
            // USRadioBtn
            // 
            this.USRadioBtn.AutoSize = true;
            this.USRadioBtn.Location = new System.Drawing.Point(77, 146);
            this.USRadioBtn.Name = "USRadioBtn";
            this.USRadioBtn.Size = new System.Drawing.Size(110, 24);
            this.USRadioBtn.TabIndex = 2;
            this.USRadioBtn.TabStop = true;
            this.USRadioBtn.Text = "US Dollars";
            this.USRadioBtn.UseVisualStyleBackColor = true;
            // 
            // UKRadioBtn
            // 
            this.UKRadioBtn.AutoSize = true;
            this.UKRadioBtn.Location = new System.Drawing.Point(267, 146);
            this.UKRadioBtn.Name = "UKRadioBtn";
            this.UKRadioBtn.Size = new System.Drawing.Size(106, 24);
            this.UKRadioBtn.TabIndex = 3;
            this.UKRadioBtn.TabStop = true;
            this.UKRadioBtn.Text = "UK Puond";
            this.UKRadioBtn.UseVisualStyleBackColor = true;
            // 
            // EURadioBtn
            // 
            this.EURadioBtn.AutoSize = true;
            this.EURadioBtn.Location = new System.Drawing.Point(451, 146);
            this.EURadioBtn.Name = "EURadioBtn";
            this.EURadioBtn.Size = new System.Drawing.Size(95, 24);
            this.EURadioBtn.TabIndex = 4;
            this.EURadioBtn.TabStop = true;
            this.EURadioBtn.Text = "EU Euro";
            this.EURadioBtn.UseVisualStyleBackColor = true;
            // 
            // ConvertBtn
            // 
            this.ConvertBtn.Location = new System.Drawing.Point(178, 207);
            this.ConvertBtn.Name = "ConvertBtn";
            this.ConvertBtn.Size = new System.Drawing.Size(252, 60);
            this.ConvertBtn.TabIndex = 5;
            this.ConvertBtn.Text = "Convert";
            this.ConvertBtn.UseVisualStyleBackColor = true;
            this.ConvertBtn.Click += new System.EventHandler(this.ConvertBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Converted Amount";
            // 
            // ConvertDisplayLabel
            // 
            this.ConvertDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConvertDisplayLabel.Location = new System.Drawing.Point(274, 299);
            this.ConvertDisplayLabel.Name = "ConvertDisplayLabel";
            this.ConvertDisplayLabel.Size = new System.Drawing.Size(298, 31);
            this.ConvertDisplayLabel.TabIndex = 7;
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(178, 368);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(252, 52);
            this.ResetBtn.TabIndex = 8;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 452);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.ConvertDisplayLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ConvertBtn);
            this.Controls.Add(this.EURadioBtn);
            this.Controls.Add(this.UKRadioBtn);
            this.Controls.Add(this.USRadioBtn);
            this.Controls.Add(this.AUDTxtBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AUDTxtBox;
        private System.Windows.Forms.RadioButton USRadioBtn;
        private System.Windows.Forms.RadioButton UKRadioBtn;
        private System.Windows.Forms.RadioButton EURadioBtn;
        private System.Windows.Forms.Button ConvertBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ConvertDisplayLabel;
        private System.Windows.Forms.Button ResetBtn;
    }
}

