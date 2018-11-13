using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace RandomWord
{
	public partial class RandomWordGenerator : Form
	{
		public RandomWordGenerator()
		{
			InitializeComponent();
		}

		private void GenerateButton_Click(object sender, EventArgs e)
		{
			ResultBox.Text = "";
            var howManyWords = 0;

            try
            {
                howManyWords = int.Parse(NumberOfWordsTextBox.Text);
            }
            catch
            {
                howManyWords = 0;
            }

			var fromIndex = Array.FindIndex(WordBank.Words,
				t => t.Equals(FromWordTextBox.Text, StringComparison.InvariantCultureIgnoreCase));
			var toIndex = Array.FindIndex(WordBank.Words,
				t => t.Equals(ToWordTextBox.Text, StringComparison.InvariantCultureIgnoreCase));

			if (toIndex < fromIndex)
			{
				var temp = fromIndex;
				fromIndex = toIndex;
				toIndex = temp;
			}

            if (areInputsValid(fromIndex, toIndex, howManyWords))
			{
				var listOfIndex = new List<int>();
				var random = new Random();

				while (listOfIndex.Count < howManyWords)
				{
					var rand = 0;

					do
					{
						rand = random.Next(fromIndex, toIndex);
					} while (listOfIndex.Contains(rand));

					listOfIndex.Add(rand);
				}

				ShowWords(listOfIndex);
			}
		}


        private bool areInputsValid(int fromIndex, int toIndex, int range)
        {
            bool result = false;

            if (fromIndex < 0 || toIndex < fromIndex)
            {
                MessageBox.Show("Cannot find the word(s)", "Error");
            }
            else
            {
                if (range == 0)
                {
                    MessageBox.Show("0 size range", "Error");
                }
                else if (range > (toIndex - fromIndex + 1))
                {
                    MessageBox.Show("Input range is larger than words range", "Error");
                }
                else
                {
                    result = true;
                }
            }

            return result;
        }


		private void ShowWords(List<int> indices)
		{
			indices.Sort();
			var stringBuilder = new StringBuilder();

			foreach (var index in indices)
			{
				stringBuilder.Append(WordBank.Words[index]);
				stringBuilder.Append(new string('\n', 5));
			}

			ResultBox.Text = stringBuilder.ToString();
		}
	}
}
