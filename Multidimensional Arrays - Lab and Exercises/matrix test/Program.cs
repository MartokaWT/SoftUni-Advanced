using System;
using System.Collections.Generic;
using System.Data;

Console.WriteLine("How many rows?");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("How many cols?");
int cols = int.Parse(Console.ReadLine());

int[,] matrix = new int[rows, cols];

for (int row = 0; row < rows; row++)
{
	int[] rowValues = Console.ReadLine()
		.Split()
		.Select(int.Parse)
		.ToArray();

	for (int col = 0; col < cols; col++)
	{
		matrix[row, col] = rowValues[col];
	}
}

for (int row = 0; row < rows; row++)
{
	for (int col = 0; col < cols; col++)
	{
		Console.Write(matrix[row, col] + " ");
	}

	Console.WriteLine();
}

/////////////////////////////////////////////////

//Console.WriteLine("How many rows?");
//int rows = int.Parse(Console.ReadLine());
//Console.WriteLine("How many cols?");
//int cols = int.Parse(Console.ReadLine());

//int[,] matrix = new int[rows, cols];

//for (int row = 0; row < rows; row++)
//{
//	for (int col = 0; col < cols; col++)
//	{
//		Console.WriteLine($"matrix[{row},{col} = ?]");
//		matrix[row, col] = int.Parse(Console.ReadLine());
//	}
//}

//for (int row = 0; row < rows; row++)
//{
//	for (int col = 0; col < cols; col++)
//	{
//		Console.Write(matrix[row, col] + " ");
//	}

//	Console.WriteLine();
//}

/////////////////////////////////////////////////

//int[,] matrix = new int[3, 3];

//int index = 1;

//for (int row = 0; row < 3; row++)
//{
//	for (int col = 0; col < 3; col++)
//	{
//		matrix[row, col] = index++;
//	}