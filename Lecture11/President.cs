using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture11
{
	internal class President : Worker, IRegulator
	{
		public President(string name, string lastName, decimal salary) : base(name, lastName, salary)
		{
			this.Position = "President";
		}

		public string RegulationTopic { get; set ; }

		public override void Print()
		{
			Console.WriteLine("wrker is Presidernt");
		}

		public void Regulate()
		{
			Console.WriteLine("I regulate policy");
		}
	}
}
