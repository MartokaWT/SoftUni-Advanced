using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

internal class Program
{
	private static void Main(string[] args)
	{
		Stack<int> fuelStack = new(Console.ReadLine().Split().Select(int.Parse));
		Queue<int> consumptionQueue = new(Console.ReadLine().Split().Select(int.Parse));
		Queue<int> neededFuelQueue = new(Console.ReadLine().Split().Select(int.Parse));

		int currentAltitude = 1;

		while (fuelStack.Count > 0 && neededFuelQueue.Count > 0)
		{
			int currentFuel = fuelStack.Pop();
			int consumptionIndex = consumptionQueue.Dequeue();
			int fuelNeeded = neededFuelQueue.Dequeue();

			currentFuel -= consumptionIndex;

			if (currentFuel >= fuelNeeded)
			{
				Console.WriteLine($"John has reached: Altitude {currentAltitude}");
				currentAltitude++;
			}
			else
			{
				if (currentAltitude > 1)
				{
					Console.WriteLine($"John did not reach: Altitude {currentAltitude}");
					Console.WriteLine("John failed to reach the top.");
					Console.WriteLine($"Reached altitudes: {string.Join(", ", Enumerable.Range(1, currentAltitude - 1).Select(a => $"Altitude {a}"))}");
				}
				else
				{
					Console.WriteLine("John failed to reach the top.");
					Console.WriteLine("John didn't reach any altitude.");
				}

				return;
			}
		}

		if (currentAltitude > 4)
		{
			Console.WriteLine("John has reached all the altitudes and managed to reach the top!");
		}
	}
}