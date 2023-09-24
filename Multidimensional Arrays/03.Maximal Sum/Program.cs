﻿using System.Text;

int[] size = Console.ReadLine()
				.Split()
				.Select(int.Parse)
				.ToArray();
var matrix = new int[size[0], size[1]];

for (int i = 0; i < size[0]; i++)
{
	var colEl = Console.ReadLine()
		.Split(" ", StringSplitOptions.RemoveEmptyEntries)
		.Select(int.Parse)
		.ToArray();
	for (int j = 0; j < size[1]; j++)
	{
		matrix[i, j] = colEl[j];
	}
}

int startRow = 0;
int startCol = 0;
int largest = 0;
for (var i = 0; i < matrix.GetLength(0) - 2; i++)
{
	for (var j = 0; j < matrix.GetLength(1) - 2; j++)
	{
		var sum = 0;
		for (var x = i; x < i + 3; x++)
		{
			for (var y = j; y < j + 3; y++)
			{
				sum += matrix[x, y];
			}
		}
		if (sum > largest)
		{
			largest = sum;
			startRow = i;
			startCol = j;
		}
	}
}

var sb = new StringBuilder();
sb.AppendLine($"Sum = {largest}");
for (int i = startRow; i < startRow + 3; i++)
{
	for (int y = startCol; y < startCol + 3; y++)
	{
		sb.Append(matrix[i, y] + " ");
	}
	sb.AppendLine();
}
Console.WriteLine(sb.ToString().Trim());