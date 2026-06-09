using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture11
{
	internal class Engineer : Worker
	{
		public Engineer(string name, string lastName, decimal salary) : base(name, lastName, salary)
		{
			this.Position = "Engineer";
		}
		public override void Print()
		{
			Console.WriteLine("worker is engineer");
		}
	
	}
}
