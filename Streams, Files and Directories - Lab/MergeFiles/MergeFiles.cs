namespace MergeFiles
{
	using System;
	using System.Collections.Generic;
	using System.IO;
	using System.Reflection.PortableExecutable;

	public class MergeFiles
	{
		static void Main()
		{
			var firstInputFilePath = @"..\..\..\Files\input1.txt";
			var secondInputFilePath = @"..\..\..\Files\input2.txt";
			var outputFilePath = @"..\..\..\Files\output.txt";

			MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
		}

		public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
		{
			SortedSet<string> set = new();
			string currentLine1;
			string currentLine2;

			using (StreamReader input1 = new(firstInputFilePath))
			{
				while (input1.EndOfStream == false)
				{
					currentLine1 = input1.ReadLine();
					set.Add(currentLine1);
				}
			}

			using (StreamReader input2 = new(secondInputFilePath))
			{
				while (input2.EndOfStream == false)
				{
					currentLine2 = input2.ReadLine();
					set.Add(currentLine2);
				}
			}

			using (StreamWriter writer = new StreamWriter(outputFilePath))
			{
				foreach (var item in set)
				{
					writer.WriteLine($"{item}");
				}
			}
		}
	}
}