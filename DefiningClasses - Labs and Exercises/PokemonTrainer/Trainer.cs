﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTrainer
{
	public class Trainer
	{
		public Trainer()
		{
			NumberOfBadges = 0;
		}

		public string Name { get; set; }
		public int NumberOfBadges { get; set; }

		public List<Pokemon> collectionPokemon = new List<Pokemon>();
	}
}