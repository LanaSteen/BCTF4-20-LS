using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture11
{
	internal class Ukulele  : MusicalInstrument
	{
		public Ukulele(string name, MusicalInstrumentType type) : base(name, type)
		{
		}
		public override void Sound()
		{
			Console.WriteLine("The ukulele produces a bright and cheerful sound.");
		}
	

	}
}
