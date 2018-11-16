using System.Collections.Generic;
using System.Text;

namespace RandomSatWords
{
	public partial class RandomWordGenerator
	{
		private void ShowWords(List<string> words)
		{
			words.Sort();
			var stringBuilder = new StringBuilder();

			foreach (var word in words)
			{
				stringBuilder.Append(word);
				stringBuilder.Append(new string('\n', 5));
			}

			ResultBox.Text = stringBuilder.ToString();
		}
	}
}