int n = int.Parse(Console.ReadLine());

SortedSet<string> periodicElements = new();

for (int i = 0; i < n; i++)
{
	string[] elements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

	periodicElements.UnionWith(elements);
}

Console.WriteLine(string.Join(" ", periodicElements));