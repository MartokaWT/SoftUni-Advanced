int n = int.Parse(Console.ReadLine());

HashSet<string> names = new();

for (int i = 0; i < n; i++)
{
	string input = Console.ReadLine();
	names.Add(input);
}

foreach (string name in names)
{
    Console.WriteLine(name);
}