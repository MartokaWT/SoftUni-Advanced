using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawData
{
	public class Cargo
	{
		public Cargo(int weigth, string type)
		{
			Weigth = weigth;
			Type = type;
		}

		public int Weigth { get; set; }
		public string Type { get; set; }
	}
}
