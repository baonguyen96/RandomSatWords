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


		private void HelpButton_Click(object sender, EventArgs e)
		{
			var info = $"Enter either a triple of (start word, end word, range) or " +
			           $"(from page, to page, range) to get back result.\r\n" +
			           $"Precedence: words over page.\r\n" +
			           $"Word range must be a number of words between the start and end words.";
			MessageBox.Show(info, "Information", MessageBoxButtons.OK);
		}


	}
}