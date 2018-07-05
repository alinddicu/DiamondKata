namespace DiamondKata
{
	using System;
	using System.Linq;
	using System.Collections.Generic;

	public class DiamondKata
	{
		private static readonly char[] CapitalLetters = Enumerable.Range(65, 26).Select(i => (char)i).ToArray();

		public List<string> Print(char mainLetter)
		{
			var asciiIndex = CapitalLetters.FirstOrDefault(cl => cl == mainLetter);
			if (asciiIndex < 65 || asciiIndex > 90)
			{
				throw new Exception($"'{mainLetter}' is not a capital letter");
			}

			var mainLetterIndex = GetIndex(mainLetter);
			if (mainLetterIndex == 0)
			{
				return new List<string> { CapitalLetters[0].ToString() };
			}

			var result = new List<string> { BuildLine(mainLetter) };
			for (var i = 0; i < mainLetterIndex - 1; i++)
			{
				var currentLetter = CapitalLetters[i + 1];
				result.Add(BuildLine(mainLetter, currentLetter));
			}

			result.Add(BuildLine(mainLetter, mainLetter));

			for (var i = mainLetterIndex - 1; i > 0; i--)
			{
				var currentLetter = CapitalLetters[i];
				result.Add(BuildLine(mainLetter, currentLetter));
			}

			result.Add(BuildLine(mainLetter));

			return result;
		}

		private static string BuildLine(char mainLetter, char currentLetter)
		{
			var mainLetterIndex = GetIndex(mainLetter);
			var currentLetterIndex = GetIndex(currentLetter);
			return "".PadLeft(' ', mainLetterIndex - currentLetterIndex)
				+ currentLetter
				+ "".PadRight(' ', (currentLetterIndex - 1) * 2 + 1)
				+ currentLetter
				+ "".PadRight(' ', mainLetterIndex - currentLetterIndex);
		}

		private string BuildLine(char mainLetter)
		{
			var mainLetterIndex = GetIndex(mainLetter);
			return CapitalLetters[0].ToString().PadLeft(' ', mainLetterIndex).PadRight(' ', mainLetterIndex);
		}

		private static int GetIndex(char letter)
		{
			return CapitalLetters
				.Select((c, i) => new { c, i })
				.Single(o => o.c == letter).i;
		}
	}
}
