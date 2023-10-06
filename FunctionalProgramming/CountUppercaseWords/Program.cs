var text = Console.ReadLine()
				.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

Console.WriteLine(string.Join(Environment.NewLine, text
	.Where(w => char.IsUpper(w[0]))));