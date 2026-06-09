using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture11
{
	internal abstract class MusicalInstrument
	{
		protected MusicalInstrument(string name, MusicalInstrumentType type)
		{
			Name = name;
			Type = type;
			CreatedAt = DateTime.Now;
		}

		public string Name { get; set; }

	    public MusicalInstrumentType Type { get; set; }

		public DateTime CreatedAt { get; init; } 

		public abstract void Sound();
		//{
		//	Console.WriteLine("The musical instrument makes a sound.");
		//}

		public void Desc()
		{
			Console.WriteLine($"The musical instrument has type {Type} ");
		}

		public void Show()
		{
			Console.WriteLine("The musical instrument is a {0}.", Name);
		}

		public void History()
		{
			Console.WriteLine($"The musical instrument was created on {CreatedAt.ToShortDateString()}.");
		}

		public override string? ToString()
		{
			return $"{Name} {Type} {CreatedAt}";
		}
	}


	enum MusicalInstrumentType
	{
		String,
		Keybord,
		Brass
	}
}
