using System.Reflection.Metadata;

int[] numbers = Console.ReadLine()
	.Split(" ", StringSplitOptions.RemoveEmptyEntries)
	.Select(int.Parse)
	.ToArray();

int[] sorted = numbers.OrderByDescending(n => n).ToArray();

if (sorted.Length >= 3)
{
	Console.WriteLine(string.Join(" ", sorted.Take(3)));
}
else
{
    Console.WriteLine(string.Join(" ", sorted));
}