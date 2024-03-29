﻿int[] input = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
Queue<int> queue = new Queue<int>(input);
int count = queue.Sum();
int sum = 0;
while (sum != count)
{
	sum += queue.Peek();
	if (queue.Peek() % 2 == 1)
	{
		queue.Dequeue();
	}
	else
	{
		queue.Enqueue(queue.Dequeue());
	}

}
Console.WriteLine(string.Join(", ", queue));