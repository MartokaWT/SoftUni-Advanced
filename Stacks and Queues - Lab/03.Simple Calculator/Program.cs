string input = Console.ReadLine();

string[] tokens = input.Split(' ');
Stack<int> stack = new Stack<int>();
int result = 0;
bool addition = true;

foreach (string token in tokens)
{
	if (IsNumber(token))
	{
		int number = int.Parse(token);
		if (addition)
		{
			result += number;
		}
		else
		{
			result -= number;
		}
	}
	else if (token == "+")
	{
		addition = true;
	}
	else if (token == "-")
	{
		addition = false;
	}
}

Console.WriteLine(result);

static bool IsNumber(string token)
{
	int number;
	return int.TryParse(token, out number);
}