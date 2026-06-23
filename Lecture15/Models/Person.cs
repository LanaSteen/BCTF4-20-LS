using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Lecture15.Models
{
	internal class Person
	{

		protected Person(string name, string lastName, int age)
		{ 
			Name = name;
			LastName = lastName;
			Age = age;
		  
		} 

		public string Name { get; set; }
		public string LastName { get; set; }

	

		private int _age;

		public int Age
		{
			get { return _age; }
			set 
			{
			  if(value < 16 || value > 120)
				{
					throw new ArgumentException("Age must be between 16 and 120.");  ///  ქასთომ ექსეფშენები
				}


			  _age = value;
			
			}
		}







		//Email
		//Phone
		//GPA
		//Faculty
	}
}
