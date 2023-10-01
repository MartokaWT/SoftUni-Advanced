HashSet<int> numSet1 = new();
HashSet<int> numSet2 = new();

int[] size = Console.ReadLine()
	.Split(" ", StringSplitOptions.RemoveEmptyEntries)
	.Select(int.Parse)
	.ToArray();

for (int i = 0; i < size[0]; i++)
{
	numSet1.Add(int.Parse(Console.ReadLine()));
}
for (int j = 0; j < size[1]; j++)
{
	numSet2.Add(int.Parse(Console.ReadLine()));
}

numSet1.IntersectWith(numSet2);

Console.WriteLine(string.Join(" ", numSet1));