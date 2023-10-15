Queue<string> queue = new Queue<string>();
string input = null;

while ((input = Console.ReadLine()) != "End")
{
	if (input == "Paid")
	{
		while (queue.Any())
		{
			Console.WriteLine(queue.Dequeue());
		}
	}
	else
	{
		queue.Enqueue(input);
	}
}

Console.WriteLine($"{queue.Count} people remaining.");