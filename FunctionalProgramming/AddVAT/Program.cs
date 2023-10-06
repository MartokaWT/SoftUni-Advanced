var netPrices = Console.ReadLine()
				.Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
				.Select(double.Parse);

Console.WriteLine(string.Join(Environment.NewLine, netPrices
	.Select(p => $"{p * 1.20:F2}")));