using Microsoft.Win32;
using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;

int count = int.Parse(Console.ReadLine());

Dictionary<string, Dictionary<string, List<string>>> continentsDict = new();

for (int i = 1; i <= count; i++)
{
	string input = Console.ReadLine();
	string continent = input.Split(" ")[0];
	string country = input.Split(" ")[1];
	string city = input.Split(" ")[2];

	if (!continentsDict.ContainsKey(continent))
	{
		continentsDict.Add(continent, new Dictionary<string, List<string>>());
	}

	if (!continentsDict[continent].ContainsKey(country))
	{
		continentsDict[continent].Add(country, new List<string>());
	}

	if (!continentsDict[continent][country].Contains(city))
	{
		continentsDict[continent][country].Add(city);
	}
}

foreach (var currContinent in continentsDict)
{
	Console.WriteLine($"{currContinent.Key}:");

	foreach (var currentCountry in currContinent.Value)
	{
		Console.WriteLine($"  {currentCountry.Key} -> {string.Join(", ", currentCountry.Value)}");
	}
}