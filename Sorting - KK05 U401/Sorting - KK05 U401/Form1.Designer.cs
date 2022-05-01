namespace Sorting___KK05_U401
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
			this.HeadingLabel = new System.Windows.Forms.Label();
			this.SelectHeadLabel = new System.Windows.Forms.Label();
			this.QuickHeadLabel = new System.Windows.Forms.Label();
			this.SelectionListBox = new System.Windows.Forms.ListBox();
			this.QuickListBox = new System.Windows.Forms.ListBox();
			this.SelectionBtn = new System.Windows.Forms.Button();
			this.QuickBtn = new System.Windows.Forms.Button();
			this.IndexTextBox = new System.Windows.Forms.TextBox();
			this.InstLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// HeadingLabel
			// 
			this.HeadingLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.HeadingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.HeadingLabel.Location = new System.Drawing.Point(129, 9);
			this.HeadingLabel.Name = "HeadingLabel";
			this.HeadingLabel.Size = new System.Drawing.Size(198, 45);
			this.HeadingLabel.TabIndex = 0;
			this.HeadingLabel.Text = "Sorting Program";
			this.HeadingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// SelectHeadLabel
			// 
			this.SelectHeadLabel.AutoSize = true;
			this.SelectHeadLabel.Location = new System.Drawing.Point(31, 129);
			this.SelectHeadLabel.Name = "SelectHeadLabel";
			this.SelectHeadLabel.Size = new System.Drawing.Size(106, 20);
			this.SelectHeadLabel.TabIndex = 1;
			this.SelectHeadLabel.Text = "Selection sort";
			// 
			// QuickHeadLabel
			// 
			this.QuickHeadLabel.AutoSize = true;
			this.QuickHeadLabel.Location = new System.Drawing.Point(252, 129);
			this.QuickHeadLabel.Name = "QuickHeadLabel";
			this.QuickHeadLabel.Size = new System.Drawing.Size(80, 20);
			this.QuickHeadLabel.TabIndex = 2;
			this.QuickHeadLabel.Text = "Quick sort";
			// 
			// SelectionListBox
			// 
			this.SelectionListBox.FormattingEnabled = true;
			this.SelectionListBox.ItemHeight = 20;
			this.SelectionListBox.Location = new System.Drawing.Point(37, 152);
			this.SelectionListBox.Name = "SelectionListBox";
			this.SelectionListBox.Size = new System.Drawing.Size(167, 184);
			this.SelectionListBox.TabIndex = 3;
			// 
			// QuickListBox
			// 
			this.QuickListBox.FormattingEnabled = true;
			this.QuickListBox.ItemHeight = 20;
			this.QuickListBox.Location = new System.Drawing.Point(256, 152);
			this.QuickListBox.Name = "QuickListBox";
			this.QuickListBox.Size = new System.Drawing.Size(167, 184);
			this.QuickListBox.TabIndex = 4;
			// 
			// SelectionBtn
			// 
			this.SelectionBtn.Location = new System.Drawing.Point(60, 362);
			this.SelectionBtn.Name = "SelectionBtn";
			this.SelectionBtn.Size = new System.Drawing.Size(122, 55);
			this.SelectionBtn.TabIndex = 5;
			this.SelectionBtn.Text = "Selection Sort";
			this.SelectionBtn.UseVisualStyleBackColor = true;
			this.SelectionBtn.Click += new System.EventHandler(this.SelectionBtn_Click);
			// 
			// QuickBtn
			// 
			this.QuickBtn.Location = new System.Drawing.Point(281, 362);
			this.QuickBtn.Name = "QuickBtn";
			this.QuickBtn.Size = new System.Drawing.Size(122, 55);
			this.QuickBtn.TabIndex = 6;
			this.QuickBtn.Text = "Quick Sort";
			this.QuickBtn.UseVisualStyleBackColor = true;
			this.QuickBtn.Click += new System.EventHandler(this.QuickBtn_Click);
			// 
			// IndexTextBox
			// 
			this.IndexTextBox.Location = new System.Drawing.Point(155, 92);
			this.IndexTextBox.Name = "IndexTextBox";
			this.IndexTextBox.Size = new System.Drawing.Size(137, 26);
			this.IndexTextBox.TabIndex = 7;
			// 
			// InstLabel
			// 
			this.InstLabel.AutoSize = true;
			this.InstLabel.Location = new System.Drawing.Point(41, 69);
			this.InstLabel.Name = "InstLabel";
			this.InstLabel.Size = new System.Drawing.Size(373, 20);
			this.InstLabel.TabIndex = 8;
			this.InstLabel.Text = "How many indexes would you like the array to have?";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(454, 439);
			this.Controls.Add(this.InstLabel);
			this.Controls.Add(this.IndexTextBox);
			this.Controls.Add(this.QuickBtn);
			this.Controls.Add(this.SelectionBtn);
			this.Controls.Add(this.QuickListBox);
			this.Controls.Add(this.SelectionListBox);
			this.Controls.Add(this.QuickHeadLabel);
			this.Controls.Add(this.SelectHeadLabel);
			this.Controls.Add(this.HeadingLabel);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label HeadingLabel;
		private System.Windows.Forms.Label SelectHeadLabel;
		private System.Windows.Forms.Label QuickHeadLabel;
		private System.Windows.Forms.ListBox SelectionListBox;
		private System.Windows.Forms.ListBox QuickListBox;
		private System.Windows.Forms.Button SelectionBtn;
		private System.Windows.Forms.Button QuickBtn;
		private System.Windows.Forms.TextBox IndexTextBox;
		private System.Windows.Forms.Label InstLabel;
	}
}

