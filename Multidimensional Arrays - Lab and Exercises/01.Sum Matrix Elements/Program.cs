int[] sizes = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

int rows = sizes[0];
int cols = sizes[1];

int[,] matrix = new int[rows, cols];

for (int row = 0; row < rows; row++)
{
	int[] rowValues = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

	for (int col = 0; col < cols; col++)
	{
		matrix[row, col] = rowValues[col];
	}

}

Console.WriteLine(rows);
Console.WriteLine(cols);
int sum = 0;
foreach (int i in matrix)
{
	sum += i;
}
Console.WriteLine(sum);