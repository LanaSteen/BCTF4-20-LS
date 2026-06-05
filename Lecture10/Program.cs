using System.Runtime.InteropServices;

namespace Lecture10
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region hw

			//Address addr = new Address();
			//addr.City = "Tbilisi";
			//addr.Street = "Tbilis";
			//var x = addr;
			//addr.City = "Batumi";





			//var p = new Person("John");
			//var p2 = new Person("John");
			//p.Equals(p2);

			////p.Name = "dsdsd";




			//Employee[] employees = new Employee[3];

			//employees[0] = new Employee("John", "Doe", new DateTime(1994, 1, 1), Country.Georgia, Gender.Male, Contacts.Phone, "599595959");
			//employees[1] = new Employee("John", "Doe", new DateTime(1994, 1, 1), Country.Georgia, Gender.Male, Contacts.Phone, "599595959");
			//employees[2] = new Employee("Anna", "Smith", new DateTime(1996, 1, 1), Country.Mexico, Gender.Other, Contacts.Email, "dsdsd@gmail.com");

			//FilterByCountry(employees, Country.Georgia);

			////employees[0] == employees[1]; //false
			//employees[0].Equals(employees[1]); // true

			//employees[0] = employees[2];
			#endregion hw

		

			Player player = new Player();

			//Sprite sp = new Sprite(); // error 



			//Sprite  პერსონაჟი 

			//Player 
			//Enemy 
			//Food 

		
		
		
		}





		public static void FilterByCountry(Employee[] employees, Country country)
		{

			foreach (var item in employees)
			{
				if(item.Country == country)
				{
					Console.WriteLine(item.ToString());
				}
			}

		}

	}
}



//ზოგადი       კონკრეტუოლი 
