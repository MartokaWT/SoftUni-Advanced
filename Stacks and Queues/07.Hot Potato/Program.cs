string[] names = Console.ReadLine()
	.Split()
	.ToArray();

int tosses = int.Parse(Console.ReadLine());

Queue<string> kids = new Queue<string>(names);

while (kids.Count > 1)
{
	for (int i = 1; i < tosses; i++)
	{
		kids.Enqueue(kids.Dequeue());
	}
	Console.WriteLine($"Removed {kids.Dequeue()}");
}
Console.WriteLine($"Last is {kids.Dequeue()}");