Console.WriteLine(string.Join(", ", Console.ReadLine()
				.Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.Where(n => n % 2 == 0)
				.OrderBy(n => n)));