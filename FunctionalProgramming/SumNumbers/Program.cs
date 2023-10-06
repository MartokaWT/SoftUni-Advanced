var numbers = Console.ReadLine()
				.Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToArray();

Console.WriteLine(numbers.Length);
Console.WriteLine(numbers.Sum());