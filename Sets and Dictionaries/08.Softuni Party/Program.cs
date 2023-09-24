HashSet<string> guests = new HashSet<string>();

while (true)
{
	string command = Console.ReadLine();
	if (command == "PARTY")
	{
		break;
	}
	guests.Add(command);
}

while (true)
{
	string input = Console.ReadLine();
	if (input == "END")
	{
		break;
	}
	if (guests.Contains(input))
	{
		guests.Remove(input);
	}
}

Console.WriteLine(guests.Count);

foreach (var firstChar in guests)
{
	char[] charArray = firstChar.ToCharArray();
	if (char.IsDigit(charArray[0]))
	{
		Console.WriteLine(firstChar);
	}
}
foreach (var firstChar in guests)
{
	char[] charArray = firstChar.ToCharArray();
	if (char.IsLetter(charArray[0]))
	{
		Console.WriteLine(firstChar);
	}
}