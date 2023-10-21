using System;

class Program
{
	static void Main()
	{
		int n = int.Parse(Console.ReadLine());
		char[][] matrix = new char[n][];
		int fishCaught = 0;
		int sRow = -1;
		int sCol = -1;

		for (int i = 0; i < n; i++)
		{
			char[] row = Console.ReadLine().ToCharArray();
			matrix[i] = row;

			if (Array.IndexOf(row, 'S') != -1)
			{
				sRow = i;
				sCol = Array.IndexOf(row, 'S');
			}
		}

		string command;
		while ((command = Console.ReadLine()) != "collect the nets")
		{
			matrix[sRow][sCol] = '-';

			if (command == "up")
			{
				sRow = (sRow - 1 + n) % n;
			}
			else if (command == "down")
			{
				sRow = (sRow + 1) % n;
			}
			else if (command == "left")
			{
				sCol = (sCol - 1 + n) % n;
			}
			else if (command == "right")
			{
				sCol = (sCol + 1) % n;
			}

			if (matrix[sRow][sCol] >= '1' && matrix[sRow][sCol] <= '9')
			{
				int fishAmount = matrix[sRow][sCol] - '0';
				fishCaught += fishAmount;
				matrix[sRow][sCol] = '-';
			}
			else if (matrix[sRow][sCol] == 'W')
			{
				Console.WriteLine($"You fell into a whirlpool! The ship sank and you lost the fish you caught. Last coordinates of the ship: [{sRow},{sCol}]");
				return;
			}
		}

		if (fishCaught >= 20)
		{
			Console.WriteLine("Success! You managed to reach the quota!");
		}
		else
		{
			int lackOfFish = 20 - fishCaught;
			Console.WriteLine($"You didn't catch enough fish and didn't reach the quota! You need {lackOfFish} tons of fish more.");
		}

		Console.WriteLine($"Amount of fish caught: {fishCaught} tons.");

		matrix[sRow][sCol] = 'S';

		foreach (char[] row in matrix)
		{
			Console.WriteLine(new string(row));
		}
	}
}