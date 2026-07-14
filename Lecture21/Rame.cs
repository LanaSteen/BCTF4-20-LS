using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture21
{
	internal class Rame
	{

		public string Username;
		public int Age;
		public string FirstName { get; set; }

		public void Print()
		{
			Console.WriteLine($"Username:{Username} Name:{FirstName}");
		}


	}
}
