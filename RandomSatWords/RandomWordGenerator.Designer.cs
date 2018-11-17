namespace RandomSatWords
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
			this.GenerateButton = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.FromPageInput = new System.Windows.Forms.NumericUpDown();
			this.ToPageInput = new System.Windows.Forms.NumericUpDown();
			this.RangeInput = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.FromPageInput)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ToPageInput)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.RangeInput)).BeginInit();
			this.SuspendLayout();
			// 
			// ResultBox
			// 
			this.ResultBox.AcceptsTab = true;
			this.ResultBox.EnableAutoDragDrop = true;
			this.ResultBox.Location = new System.Drawing.Point(62, 201);
			this.ResultBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ResultBox.Name = "ResultBox";
			this.ResultBox.ReadOnly = true;
			this.ResultBox.Size = new System.Drawing.Size(1194, 436);
			this.ResultBox.TabIndex = 0;
			this.ResultBox.Text = "";
			// 
			// FromWordTextBox
			// 
			this.FromWordTextBox.Location = new System.Drawing.Point(199, 51);
			this.FromWordTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.FromWordTextBox.Name = "FromWordTextBox";
			this.FromWordTextBox.Size = new System.Drawing.Size(148, 26);
			this.FromWordTextBox.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(103, 51);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "From Word";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(550, 56);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "To Word";
			// 
			// ToWordTextBox
			// 
			this.ToWordTextBox.Location = new System.Drawing.Point(627, 56);
			this.ToWordTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ToWordTextBox.Name = "ToWordTextBox";
			this.ToWordTextBox.Size = new System.Drawing.Size(148, 26);
			this.ToWordTextBox.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(931, 59);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(129, 20);
			this.label3.TabIndex = 5;
			this.label3.Text = "Number of words";
			// 
			// GenerateButton
			// 
			this.GenerateButton.Location = new System.Drawing.Point(1080, 119);
			this.GenerateButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GenerateButton.Name = "GenerateButton";
			this.GenerateButton.Size = new System.Drawing.Size(136, 35);
			this.GenerateButton.TabIndex = 7;
			this.GenerateButton.Text = "Generate";
			this.GenerateButton.UseVisualStyleBackColor = true;
			this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(103, 126);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(87, 20);
			this.label4.TabIndex = 9;
			this.label4.Text = "From Page";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(551, 128);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(68, 20);
			this.label5.TabIndex = 11;
			this.label5.Text = "To Page";
			// 
			// FromPageInput
			// 
			this.FromPageInput.Location = new System.Drawing.Point(197, 127);
			this.FromPageInput.Name = "FromPageInput";
			this.FromPageInput.Size = new System.Drawing.Size(150, 26);
			this.FromPageInput.TabIndex = 12;
			this.FromPageInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// ToPageInput
			// 
			this.ToPageInput.Location = new System.Drawing.Point(627, 127);
			this.ToPageInput.Name = "ToPageInput";
			this.ToPageInput.Size = new System.Drawing.Size(148, 26);
			this.ToPageInput.TabIndex = 13;
			this.ToPageInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// RangeInput
			// 
			this.RangeInput.Location = new System.Drawing.Point(1068, 59);
			this.RangeInput.Name = "RangeInput";
			this.RangeInput.Size = new System.Drawing.Size(148, 26);
			this.RangeInput.TabIndex = 14;
			this.RangeInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// RandomWordGenerator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1320, 691);
			this.Controls.Add(this.RangeInput);
			this.Controls.Add(this.ToPageInput);
			this.Controls.Add(this.FromPageInput);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.GenerateButton);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.ToWordTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.FromWordTextBox);
			this.Controls.Add(this.ResultBox);
			this.HelpButton = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.HelpButtonClicked += HelpButton_Click;
			this.Name = "RandomWordGenerator";
			this.Text = "Random Word Generator";
			((System.ComponentModel.ISupportInitialize)(this.FromPageInput)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ToPageInput)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.RangeInput)).EndInit();
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
		private System.Windows.Forms.Button GenerateButton;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.NumericUpDown FromPageInput;
		private System.Windows.Forms.NumericUpDown ToPageInput;
		private System.Windows.Forms.NumericUpDown RangeInput;
	}
}

