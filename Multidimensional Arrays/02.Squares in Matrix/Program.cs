int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();

int rows = size[0];
int cols = size[1];

char[,] matrix = new char[rows, cols];

for (int row = 0; row <= rows - 1; row++)
{
	char[] symbols = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
	for (int col = 0; col <= cols - 1; col++)
	{
		matrix[row, col] = symbols[col];
	}
}

int count = 0;

for (int row = 0; row < rows - 1; row++)
{
	for (int col = 0; col < cols - 1; col++)
	{
		int element = matrix[row, col];
		bool isEqualToRight = element == matrix[row, col + 1];
		bool isEqualUnder = element == matrix[row + 1, col];
		bool isEqualDiagonally = element == matrix[row + 1, col + 1];

		if (isEqualToRight && isEqualUnder && isEqualDiagonally)
		{
			count++;
		}
	}
}

Console.WriteLine(count);