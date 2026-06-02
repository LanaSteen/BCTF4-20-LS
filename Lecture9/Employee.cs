using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture9
{
	internal class Employee : Human
	{
		public Employee()
		{
		}

		public Employee(byte age, string lastName, string name, decimal salary) : base(age, lastName, name)
		{
		}

		public decimal Salary { get; set; }
	}
}
