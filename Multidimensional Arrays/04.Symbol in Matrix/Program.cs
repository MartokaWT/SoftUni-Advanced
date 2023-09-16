int n = int.Parse(Console.ReadLine());

char[,] matrix = new char[n, n];

for (int row = 0; row < n; row++)
{
	char[] rowValues = Console.ReadLine().ToCharArray();

	for (int col = 0; col < n; col++)
	{
		matrix[row, col] = rowValues[col];
	}
}

char asciiChar = char.Parse(Console.ReadLine());

if (matrix.Cast<char>().Contains(asciiChar))
{
	for (int row = 0; row < matrix.GetLength(0); row++)
	{
		for (int col = 0; col < matrix.GetLength(1); col++)
		{
			if (matrix[row, col] == asciiChar)
			{
				Console.WriteLine($"({row}, {col})");
				return;
			}
		}
	}
}
else
{
	Console.WriteLine($"{asciiChar} does not occur in the matrix");
}