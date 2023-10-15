using System.Runtime.CompilerServices;

Dictionary<string, Dictionary<string, double>> productsDict = new();

string command = Console.ReadLine();

while (command != "Revision")
{
	string shop = command.Split(", ")[0];
	string product = command.Split(", ")[1];
	double price = double.Parse(command.Split(", ")[2]);

	if (!productsDict.ContainsKey(shop))
	{
		productsDict.Add(shop, new Dictionary<string, double>());
	}

	productsDict[shop].Add(product, price);

	command = Console.ReadLine();
}

foreach (var shopName in productsDict.OrderBy(s => s.Key))
{
	Console.WriteLine($"{shopName.Key}->");
	foreach (var product in shopName.Value)
	{
		Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
	}
}