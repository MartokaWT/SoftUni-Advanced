namespace WordCount
{
	using System;
	using System.Collections.Generic;
	using System.IO;
	using System.Linq;
	public class WordCount
	{
		static void Main()
		{
			string wordPath = @"..\..\..\Files\words.txt";
			string textPath = @"..\..\..\Files\text.txt";
			string outputPath = @"..\..\..\Files\output.txt";

			CalculateWordCounts(wordPath, textPath, outputPath);
		}

		public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
		{
			Dictionary<string, int> wordsDict = new Dictionary<string, int>();
			string[] words = File.ReadAllText(wordsFilePath).Split();

			using (StreamReader reader = new StreamReader(textFilePath))
			{
				string currentLine = reader.ReadLine();

				while (currentLine != null)
				{
					string[] wordsInCurrentLine = currentLine.ToLower()
					.Split(new[] { ' ', '.', ',', '-', '?', '!', ':', ';' }, StringSplitOptions.RemoveEmptyEntries);

					foreach (string word in words)
					{
						foreach (string currentWord in wordsInCurrentLine)
						{
							if (word == currentWord)
							{
								if (wordsDict.ContainsKey(currentWord) == false)
								{
									wordsDict.Add(currentWord, 0);
								}
								wordsDict[currentWord]++;
							}
						}
					}
					currentLine = reader.ReadLine();
				}
			}
			using (StreamWriter writer = new StreamWriter(outputFilePath))
			{
				foreach (var item in wordsDict.OrderByDescending(x => x.Value))
				{
					writer.WriteLine($"{item.Key} - {item.Value}");
				}
			}
		}
	}
}