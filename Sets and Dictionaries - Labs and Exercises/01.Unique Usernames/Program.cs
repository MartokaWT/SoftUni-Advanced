﻿int n = int.Parse(Console.ReadLine());

HashSet<string> names = new();

for (int i = 0; i < n; i++)
{
    names.Add(Console.ReadLine());
}

foreach  (string name in names)
{
    Console.WriteLine(name);
}