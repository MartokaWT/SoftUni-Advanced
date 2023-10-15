using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CarSalesman
{
	public class Car
	{
		public Car(string model, Engine engine)
		{
			CarModel = model;
			Engine = engine;
			Weigth = null;
			Color = "n/a";
		}
		public Car(string model, Engine engine, int weight)
		 : this(model, engine)
		{
			Weigth = weight;
		}

		public Car(string model, Engine engine, string color)
		: this(model, engine)
		{
			Color = color;
		}


		public Car(string model, Engine engine, int weight, string color)
			: this(model, engine)
		{
			Weigth = weight;
			Color = color;
		}

		public string CarModel { get; set; }
		public Engine Engine { get; set; }
		public int? Weigth { get; set; }
		public string Color { get; set; }

		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.AppendLine($"{CarModel}:");
			sb.AppendLine($"  {Engine.EngineModel}:");
			sb.AppendLine($"   Power: {Engine.Power}");
			if (Engine.Displacement == null)
			{
				sb.AppendLine("   Displacement: n/a");
			}

			else
			{
				sb.AppendLine($"   Displacement: {Engine.Displacement}");
			}

			sb.AppendLine($"   Efficiency: {Engine.Efficiency}");
			if (Weigth == null)
			{
				sb.AppendLine("  Weight: n/a");
			}

			else
			{
				sb.AppendLine($"  Weight: {Weigth}");
			}

			sb.AppendLine($"  Color: {Color}");
			return sb.ToString().Trim();
		}
	}
}