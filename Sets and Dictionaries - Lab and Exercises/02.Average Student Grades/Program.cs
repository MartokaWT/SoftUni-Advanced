int count = int.Parse(Console.ReadLine());

Dictionary<string, List<decimal>> studentsGrade = new();

for (int i = 0 ; i < count; i++)
{
	string input = Console.ReadLine();
	string name = input.Split()[0];
	decimal grade = decimal.Parse(input.Split()[1]);

	if (!studentsGrade.ContainsKey(name))
	{
		studentsGrade.Add(name, new List<decimal>());
	}

	studentsGrade[name].Add(grade);
}

foreach (var entry in studentsGrade)
{
	string name = entry.Key;
	List<decimal> grades = entry.Value;
	decimal average = grades.Average();

    Console.WriteLine($"{name} -> {String.Join(" ", grades.Select(grade => $"{grade:f2}"))} (avg: {average:f2})");
}