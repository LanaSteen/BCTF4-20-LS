using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture9
{
	//sealed
	internal class Human 
	{
		public Human()
		{
		}

		public Human(byte age, string lastName, string name)
		{
			Age = age;
			LastName = lastName;
			Name = name;
		}

		public byte Age { get; set; }
		public string LastName { get; set; }
		public string Name { get; set; }



		public void PrintInfo() => Console.WriteLine($"{Age} {LastName} {Name}");

	}
}


//BASE

