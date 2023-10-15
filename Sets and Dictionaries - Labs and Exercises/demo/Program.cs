using System;
using System.Collections.Generic;

HashSet<int> first = new() { 1, 2, 3, 4, 5, };
HashSet<int> second = new() { 3, 4, 5, 6, 7, };

first.UnionWith(second);
second.UnionWith(first);

first.IntersectWith(second);
second.IntersectWith(first);

first.ExceptWith(second);
second.ExceptWith(first);

second.SymmetricExceptWith(first);
first.SymmetricExceptWith(second);

Console.WriteLine(string.Join(" ", first));
Console.WriteLine(string.Join(" ", second));