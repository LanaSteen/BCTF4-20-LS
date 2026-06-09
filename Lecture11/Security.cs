using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture11
{
	internal class Security : Worker
	{
		public Security(string name, string lastName, decimal salary) : base(name, lastName, salary)
		{
			this.Position = "Security";
		}
		public override void Print()
		{
			Console.WriteLine("worker is security");
		}
	
	}
}
