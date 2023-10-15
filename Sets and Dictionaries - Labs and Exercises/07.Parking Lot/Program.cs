HashSet<string> cars = new();

string input;

while ((input = Console.ReadLine()) != "END")
{
	string command = input.Split(", ")[0];
	string licensePlate = input.Split()[1];
	if (command == "IN")
	{
		cars.Add(licensePlate);
	}

	if (command == "OUT")
	{
		cars.Remove(licensePlate);
	}
}

foreach  (string car in cars)
{
	Console.WriteLine(car);
}

if (cars.Count == 0)
{
    Console.WriteLine("Parking Lot is Empty");
}