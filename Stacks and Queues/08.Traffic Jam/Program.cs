int n = int.Parse(Console.ReadLine());
Queue<string> queue = new Queue<string>();
int count = 0;
string command;

while ((command = Console.ReadLine()) != "end")
{
	if (command == "green")
	{
		for (int i = 0; i < n; i++)
		{
			if (queue.Count == 0)
			{
				break;
			}
			Console.WriteLine($"{queue.Dequeue()} passed!");
			count++;
		}
	}
	else
	{
		queue.Enqueue(command);
	}
}
Console.WriteLine($"{count} cars passed the crossroads.");