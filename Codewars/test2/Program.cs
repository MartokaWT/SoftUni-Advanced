using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
	private static void Main(string[] args)
	{
		int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

		for (int i = 0; i < numbers.Length; i++)
		{
			numbers[i] *= numbers[i];
		}

		int result = 0;

		foreach (int number in numbers)
		{
			result += number;
		}
	}
}