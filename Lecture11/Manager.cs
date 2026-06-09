using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture11
{
	internal class Manager : Worker, IRegulator, IDriver
	{
		public Manager(string name, string lastName, decimal salary) : base(name, lastName, salary)
		{
			this.Position = "Manager";
		}

		public string RegulationTopic { get ; set; }

		public void Drive2()
		{
			Console.WriteLine("I can drive compnay car");
		}

		public override void Print()
		{
			Console.WriteLine("worker is manager");
		}

		public void Regulate()
		{
			Console.WriteLine("I regulate hr");
		}
	}
}

//რა არის ტიპი 

