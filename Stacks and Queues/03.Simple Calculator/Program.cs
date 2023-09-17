string input = Console.ReadLine();

string[] tokens = input.Split();

Stack<string> stack = new Stack<string>(tokens);

int result = int.Parse(stack.Pop());

while (stack.Count > 0)
{
	string operation = stack.Pop();
	int number = int.Parse(stack.Pop());

	if (operation == "+")
	{
		result += number;
	}
	else if (operation == "-")
	{
		result -= number;
	}
}

Console.WriteLine(result);