List<double> numbers = Console.ReadLine()
	.Split(" ", StringSplitOptions.RemoveEmptyEntries)
	.Select(double.Parse)
	.ToList();

Dictionary<double, int> numbersCount = new();

foreach (double number in numbers)
{
	if (!numbersCount.ContainsKey(number))
	{
		numbersCount.Add(number, 1);
	}
	else
	{
		numbersCount[number]++;
	}
}

foreach (var number in numbersCount)
{
    Console.WriteLine($"{number.Key} - {number.Value} times");
}