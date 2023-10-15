namespace CarSalesman
{
	public class Program
	{
		static void Main(string[] args)
		{
			List<Engine> engines = new();
			List<Car> cars = new();

			int engineCount = int.Parse(Console.ReadLine());

			for (int i = 0; i < engineCount; i++)
			{
				string[] engineProps = Console.ReadLine()
					.Split(" ", StringSplitOptions.RemoveEmptyEntries);
				if (engineProps.Length == 2)
				{
					string model = engineProps[0];
					string power = engineProps[1];
					Engine newEngine = new Engine(model, power);
					engines.Add(newEngine);
				}

				else if (engineProps.Length == 3)
				{
					string model = engineProps[0];
					string power = engineProps[1];
					string thirdParam = engineProps[2];
					if (int.TryParse(thirdParam, out int displacement))
					{
						Engine newEngine = new Engine(model, power, displacement);
						engines.Add(newEngine);
					}

					else
					{
						string efficiency = engineProps[2];
						Engine newEngine = new Engine(model, power, efficiency);
						engines.Add(newEngine);
					}
				}
				else if (engineProps.Length == 4)
				{
					string model = engineProps[0];
					string power = engineProps[1];
					int displacement = int.Parse(engineProps[2]);
					string efficiency = engineProps[3];
					Engine newEngine = new Engine(model, power, displacement, efficiency);
					engines.Add(newEngine);
				}
			}

			int carCount = int.Parse(Console.ReadLine());

			for (int i = 0; i < carCount; i++)
			{
				string[] carProps = Console.ReadLine()
					.Split(" ", StringSplitOptions.RemoveEmptyEntries);
				if (carProps.Length == 2)
				{
					string model = carProps[0];
					string engineModel = carProps[1];
					if (engines.Exists(e => e.EngineModel == engineModel))
					{
						Engine findEngine = engines.Where(e => e.EngineModel == engineModel).First();
						Car newCar = new Car(model, findEngine);
						cars.Add(newCar);
					}
				}

				else if (carProps.Length == 3)
				{
					string model = carProps[0];
					string engineModel = carProps[1];
					string thirdParam = carProps[2];
					if (engines.Any(e => e.EngineModel == engineModel))
					{
						Engine findedEngine = engines.Where(e => e.EngineModel == engineModel).First();
						if (int.TryParse(thirdParam, out int weight))
						{
							var newCar = new Car(model, findedEngine, weight);
							cars.Add(newCar);
						}

						else
						{
							string color = carProps[2];
							var newCar = new Car(model, findedEngine, color);
							cars.Add(newCar);
						}
					}
				}

				else if (carProps.Length == 4)
				{
					string model = carProps[0];
					string engineModel = carProps[1];
					int weight = int.Parse(carProps[2]);
					string color = carProps[3];
					if (engines.Any(e => e.EngineModel == engineModel))
					{
						Engine findedEngine = engines.Where(e => e.EngineModel == engineModel).First();
						var newCar = new Car(model, findedEngine, weight, color);
						cars.Add(newCar);
					}
				}
			}

			foreach (var car in cars)
			{
				Console.WriteLine(car.ToString());
			}
		}
	}
}