using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture9
{
	internal class Teacher : Employee
	{
		//public string Name { get; set; }
		//public string LastName { get; set; }
		//public byte Age { get; set; }

		//public decimal Salary { get; set; }

		public string Subject { get; set; }

		public Lesson[] Lessons { get; set; }  // 100 


		public decimal GetBonus() 
		{
			return Lessons.Length * 100;
		}

	}
}
