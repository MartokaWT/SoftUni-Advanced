﻿using System.Collections.Generic;

string input = Console.ReadLine();

Stack<char>  stack  = new Stack<char>();

foreach (char item in input)
{
	stack.Push(item);
}

while (stack.Count > 0)
{
	Console.Write(stack.Pop());
}