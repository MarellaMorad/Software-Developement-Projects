﻿namespace KK04___XML_Practice
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
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.AgeTextBox = new System.Windows.Forms.TextBox();
			this.NameTextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(61, 184);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(245, 58);
			this.button1.TabIndex = 0;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(71, 275);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(51, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "label1";
			// 
			// AgeTextBox
			// 
			this.AgeTextBox.Location = new System.Drawing.Point(122, 117);
			this.AgeTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.AgeTextBox.Name = "AgeTextBox";
			this.AgeTextBox.Size = new System.Drawing.Size(169, 26);
			this.AgeTextBox.TabIndex = 4;
			// 
			// NameTextBox
			// 
			this.NameTextBox.Location = new System.Drawing.Point(122, 60);
			this.NameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.NameTextBox.Name = "NameTextBox";
			this.NameTextBox.Size = new System.Drawing.Size(169, 26);
			this.NameTextBox.TabIndex = 3;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(402, 375);
			this.Controls.Add(this.AgeTextBox);
			this.Controls.Add(this.NameTextBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox AgeTextBox;
		private System.Windows.Forms.TextBox NameTextBox;
	}
}

