using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RandomSatWords
{
	public partial class RandomWordGenerator : Form
	{
		public RandomWordGenerator()
		{
			InitializeComponent();
		}

		private void GenerateButton_Click(object sender, EventArgs e)
		{
			try
			{
				var fromWord = FromWordTextBox.Text;
				var toWord = ToWordTextBox.Text;
				var fromPage = (int) FromPageInput.Value;
				var toPage = (int) ToPageInput.Value;
				var howManyWords = (int) RangeInput.Value;
				IEnumerable<string> words;

				if (!string.IsNullOrWhiteSpace(fromWord) && !string.IsNullOrWhiteSpace(toWord))
				{
					words = WordBank.GetWords(fromWord, toWord, howManyWords);
				}
				else
				{
					words = WordBank.GetWords(fromPage, toPage, howManyWords);
				}

				ShowWords(words.ToList());
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}
	}
}