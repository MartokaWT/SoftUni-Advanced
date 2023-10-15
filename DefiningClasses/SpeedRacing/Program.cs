namespace SpeedRacing
{
	public class Program
	{
		static void Main(string[] args)
		{
			List<Car> cars = new();

			int count = int.Parse(Console.ReadLine());

			for (int i = 0; i < count; i++)
			{
				string[] carInfo = Console.ReadLine()
					.Split(" ", StringSplitOptions.RemoveEmptyEntries)
					.ToArray();

				string Model = carInfo[0];
				double FuelAmmount = double.Parse(carInfo[1]);
				double FuelConsumption = double.Parse(carInfo[2]);

				Car currentCar = new Car(Model, FuelAmmount, FuelConsumption);

				cars.Add(currentCar);
			}

			string command;

			while ((command = Console.ReadLine()) != "End")
			{
				string[] carInfo = command.Split(" ", StringSplitOptions.RemoveEmptyEntries)
					.ToArray();

				string model = carInfo[1];
				double kmAmmount = double.Parse(carInfo[2]);

				Car drivenCar = cars.Where(m => m.Model == model)
					.ToList()
					.First();

				drivenCar.CanTravelDistance(model, kmAmmount);
			}

			foreach (var item in cars)
			{
				Console.WriteLine($"{item.Model} {item.FuelAmmount:F2} {item.TravelledDistance}");
			}
		}
	}
}