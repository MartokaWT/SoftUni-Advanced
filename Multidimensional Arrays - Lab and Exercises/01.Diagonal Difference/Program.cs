int n = int.Parse(Console.ReadLine());

int rows = n;
int cols = n;

int[,] matrix = new int[rows, cols];

for (int row = 0; row < rows; row++)
{
	int[] rowValues = Console.ReadLine().Split().Select(int.Parse).ToArray();

	for (int col = 0; col < cols; col++)
	{
		matrix[row, col] = rowValues[col];
	}
}

int primaryDiag = 0;
int secondaryDiag = 0;
int sum = 0;

for (int i = 0; i < matrix.GetLength(0); i++)
{
	primaryDiag += matrix[i, i];
	secondaryDiag += matrix[i, n - 1 - i];
	sum = Math.Abs(primaryDiag - secondaryDiag);
}

Console.WriteLine(sum);