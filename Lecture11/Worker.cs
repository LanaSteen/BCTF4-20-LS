using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture11
{
	internal abstract class Worker
	{



		private string _name;
		private string _lastName;

		protected Worker(string name, string lastName,  decimal salary)
		{
			Name = name;
			LastName = lastName;
			Salary = salary;
		}

		public string Name { get 
			{  
				return _name;
			}
			set
			{
				if (string.IsNullOrWhiteSpace(value))
				{
					Console.WriteLine("Name can't be empty");
					return;
				}else { _name = value; }
			}
		}

		public string LastName
		{
			get
			{
				return _lastName;
			}
			set
			{
				if (string.IsNullOrWhiteSpace(value))
				{
					Console.WriteLine("Last name can't be empty");

					return;
				}
				else { _lastName = value; }
			}
		}

		public string Position { get; set; }

		public decimal Salary { get; set; }


		public override string? ToString()
		{
			return $"{Name} {LastName} {Position} {Salary}";
		}

		public abstract void Print();

	}
}
