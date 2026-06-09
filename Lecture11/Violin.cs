using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture11
{
	internal class Violin : MusicalInstrument
	{
		public Violin(string name, MusicalInstrumentType type) : base(name, type)
		{
		}

		public override void Sound()
		{
			Console.WriteLine("The violin produces a melodious sound.");
		}

	}
}
