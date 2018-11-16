using System;
using System.Collections.Generic;
using System.Linq;

namespace RandomSatWords
{
	internal class WordBank
	{
		private class Page
		{
			public readonly int PageNumber;
			public readonly string[] Words;
			private static int _currentPageCount = 1;

			public Page(params string[] words)
			{
				PageNumber = _currentPageCount++;
				Words = words;
			}
		}

		private static readonly Page[] Pages =
		{
			new Page
			(
				"Abate", "Abstract", "Abysmal", "Accordingly", "Acquisition", "Adapt", "Adept", "Adequate", "Advent",
				"Adversarial", "Advocate", "Aesthetic"
			),
			new Page
			(
				"Afford", "Agitate", "Allow", "Allude", "Altercation", "Ambiguous", "Ambitious", "Ambivalence",
				"Analogous", "Annihilate", "Anomaly", "Anticipate", "Antipathy", "Apex", "Apprehension", "Articulate",
				"Artificial", "Assertion"
			),
			new Page
			(
				"Austere", "Authenticity", "Avenue", "Avid", "Basic", "Bear", "Benevolent", "Bias", "Bittersweet",
				"Bolster", "Boost", "Brawl"
			),
			new Page
			(
				"Brevity", "Candid", "Candor", "Capitalize", "Capture", "Civic", "Clinical", "Clout", "Coarse",
				"Coincide", "Commission", "Comparable", "Competent", "Complacent", "Complement"
			),
			new Page
			(
				"Concede", "Conceive", "Condone", "Conducive", "Conduct", "Confide", "Confine", "Consensus",
				"Constitute", "Contemplate", "Contend", "Contradict", "Controversial", "Conventional", "Convey",
				"Conviction", "Corroborate", "Counteract"
			),
			new Page
			(
				"Counterargument", "Counterproductive", "Culmination", "Cultivate", "Decree", "Deference", "Deficient",
				"Demonstrate", "Demur", "Deplete", "Desolate", "Devise", "Dilemma", "Diligence", "Diminish", "Dire",
				"Discord"
			),
			new Page
			(
				"Disdain", "Dismay", "Disparage", "Dispatch", "Diversification", "Doctrine", "Dominion", "Dreary",
				"Dubious", "Eccentric", "Egregious", "Eloquent", "Eminent", "Emit", "Emphatic"
			),
			new Page
			(
				"Empirical", "Endow", "Endure", "Entail", "Entrenched", "Enumerate", "Envy", "Erratic", "Establish",
				"Evoke", "Exacerbate", "Excel", "Exert", "Exhilarating", "Expend", "Exploit"
			),
			new Page
			(
				"Facilitate", "Feasibility", "Ferocity", "Fiscal", "Flourish", "Fluctuate", "Foment", "Foreseeable",
				"Frankly", "Freewheeling", "Fundamental", "Galvanizing", "Geriatric", "Hostile", "Hypothetical",
				"Ignominious", "Impart", "Impartiality", "Imposing", "Imposition", "Imprudent"
			),
			new Page
			(
				"Incite", "Indifference", "Indiscriminately", "Indulge", "Infer", "Innovative", "Insatiable",
				"Inversion", "Invoke", "Irreconcilable", "Lament", "Locomotion", "Lucrative", "Malicious", "Malleable",
				"Materialistic", "Melodramatic", "Modest"
			),
			new Page
			(
				"Modify", "Momentous", "Novel", "Nuance", "Null", "Objectivity", "Obsolete", "Omnipotent", "Onset",
				"Opine", "Ornate", "Oust", "Paramount", "Peculiar", "Perish", "Persecute", "Petulant", "Pinnacle"
			),
			new Page
			(
				"Pitiable", "Plausible", "Postulate", "Potent", "Pragmatic", "Precedent", "Predecessor", "Prescribe",
				"Principle", "Prohibit", "Prompt", "Promulgate", "Prosecute", "Provocative"
			),
			new Page
			(
				"Qualitative", "Quantitative", "Quirk", "Ramify", "Rash", "Raw", "Readily", "Reconsideration", "Reform",
				"Refute", "Reinforce", "Reluctantly", "Renounce", "Reproach", "Repudiate", "Retention"
			),
			new Page
			(
				"Satiated", "Savvy", "Scandalous", "Scorn", "Scrupulous", "Scrutinize", "Secrete", "Sentiment", "Sheer",
				"Simple", "Sinister", "Solidarity", "Sparingly", "Spawn", "Spur", "Squalid"
			),
			new Page
			(
				"Stark", "Static", "Subordinate", "Subsequently", "Substantial", "Substantiate", "Subtle", "Sufficient",
				"Surly", "Surmount", "Susceptible", "Tactful", "Taut", "Teeming", "Temperament", "Tentative",
				"Transparent"
			),
			new Page
			(
				"Treacherous", "Tremendous", "Ubiquitous", "Unadorned",
				"Undermine", "Underscore", "Undulate", "Unilateral", "Unjust", "Unmitigated", "Unprecedented", "Unveil",
				"Urge", "Validate", "Viability", "Vital", "Vow", "Warrant", "Yield"
			)
		};


		public static IEnumerable<string> GetWords(string fromWord, string toWord, int range)
		{
			var allWords = new List<string>();

			foreach (var page in Pages)
			{
				allWords.AddRange(page.Words);
			}

			var fromIndex = Array.FindIndex(allWords.ToArray(),
				t => t.Equals(fromWord, StringComparison.InvariantCultureIgnoreCase));
			var toIndex = Array.FindIndex(allWords.ToArray(),
				t => t.Equals(toWord, StringComparison.InvariantCultureIgnoreCase));

			if (toIndex < fromIndex)
			{
				var temp = fromIndex;
				fromIndex = toIndex;
				toIndex = temp;
			}

			ValidateInputs(fromIndex, toIndex, range);

			return GetRandomWords(allWords, fromIndex, toIndex, range);
		}


		public static IEnumerable<string> GetWords(int fromPage, int toPage, int range)
		{
			var fromWord = Pages.Where(p => p.PageNumber == fromPage)
			                    .Select(p => p.Words.FirstOrDefault())
			                    .FirstOrDefault();
			var toWord = Pages.Where(p => p.PageNumber == toPage).Select(p => p.Words.LastOrDefault()).FirstOrDefault();

			return GetWords(fromWord, toWord, range);
		}


		private static IEnumerable<string> GetRandomWords(IReadOnlyList<string> allWords, int fromIndex, int toIndex,
			int range)
		{
			var randomWords = new List<string>();
			var random = new Random();

			while (randomWords.Count < range)
			{
				var word = "";

				do
				{
					var rand = random.Next(fromIndex, toIndex);
					word = allWords[rand];
				} while (randomWords.Contains(word));

				randomWords.Add(word);
			}

			return randomWords;
		}


		private static void ValidateInputs(int fromIndex, int toIndex, int range)
		{
			if (fromIndex < 0 || toIndex < fromIndex)
			{
				throw new Exception("Cannot find the word(s)");
			}

			if (range <= 0)
			{
				throw new Exception("Invalid word range");
			}

			if (range > (toIndex - fromIndex + 1))
			{
				throw new Exception("Input range is larger than words range");
			}
		}
	}
}