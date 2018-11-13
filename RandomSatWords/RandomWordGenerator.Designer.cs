﻿namespace RandomWord
{
	partial class RandomWordGenerator
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RandomWordGenerator));
			this.ResultBox = new System.Windows.Forms.RichTextBox();
			this.FromWordTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.ToWordTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.NumberOfWordsTextBox = new System.Windows.Forms.TextBox();
			this.GenerateButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// ResultBox
			// 
			this.ResultBox.AcceptsTab = true;
			this.ResultBox.EnableAutoDragDrop = true;
			this.ResultBox.Location = new System.Drawing.Point(41, 101);
			this.ResultBox.Name = "ResultBox";
			this.ResultBox.ReadOnly = true;
			this.ResultBox.Size = new System.Drawing.Size(797, 312);
			this.ResultBox.TabIndex = 0;
			this.ResultBox.Text = "";
			// 
			// FromWordTextBox
			// 
			this.FromWordTextBox.Location = new System.Drawing.Point(106, 45);
			this.FromWordTextBox.Name = "FromWordTextBox";
			this.FromWordTextBox.Size = new System.Drawing.Size(100, 20);
			this.FromWordTextBox.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(41, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "From Word";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(266, 52);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(49, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "To Word";
			// 
			// ToWordTextBox
			// 
			this.ToWordTextBox.Location = new System.Drawing.Point(331, 48);
			this.ToWordTextBox.Name = "ToWordTextBox";
			this.ToWordTextBox.Size = new System.Drawing.Size(100, 20);
			this.ToWordTextBox.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(490, 48);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(87, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Number of words";
			// 
			// NumberOfWordsTextBox
			// 
			this.NumberOfWordsTextBox.Location = new System.Drawing.Point(583, 45);
			this.NumberOfWordsTextBox.Name = "NumberOfWordsTextBox";
			this.NumberOfWordsTextBox.Size = new System.Drawing.Size(100, 20);
			this.NumberOfWordsTextBox.TabIndex = 6;
			// 
			// GenerateButton
			// 
			this.GenerateButton.Location = new System.Drawing.Point(750, 48);
			this.GenerateButton.Name = "GenerateButton";
			this.GenerateButton.Size = new System.Drawing.Size(75, 23);
			this.GenerateButton.TabIndex = 7;
			this.GenerateButton.Text = "Generate";
			this.GenerateButton.UseVisualStyleBackColor = true;
			this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
			// 
			// RandomWordGenerator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(880, 449);
			this.Controls.Add(this.GenerateButton);
			this.Controls.Add(this.NumberOfWordsTextBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.ToWordTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.FromWordTextBox);
			this.Controls.Add(this.ResultBox);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "RandomWordGenerator";
			this.Text = "Random Word Generator";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RichTextBox ResultBox;
		private System.Windows.Forms.TextBox FromWordTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox ToWordTextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox NumberOfWordsTextBox;
		private System.Windows.Forms.Button GenerateButton;
	}
}

