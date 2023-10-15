using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedRacing
{
	public class Car
	{
		private string model;
		private double fuelAmmount;
		private double fuelConsumptioPerKilometer;
		private double travelledDistance;

		public Car(string model,
			double fuelAmmount,
			double fuelConsumptionPerKilometer)
		{
			Model = model;
			FuelAmmount = fuelAmmount;
			FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
			TravelledDistance = travelledDistance;
		}

        public string Model { get; set; }
		public double FuelAmmount { get; set; }
		public double FuelConsumptionPerKilometer { get; set; }
		public double TravelledDistance { get; set; }

		public void CanTravelDistance(string model, double kmAmmount)
		{
			double neededLitres = kmAmmount * this.FuelConsumptionPerKilometer;

			if (FuelAmmount >= neededLitres)
			{
				FuelAmmount -= neededLitres;
				TravelledDistance += kmAmmount;
			}
			else
			{
				Console.WriteLine("Insufficient fuel for the drive");
			}
		}
	}
}