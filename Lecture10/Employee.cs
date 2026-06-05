using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Lecture10
{


	enum Country 
	{ US, Canada, Mexico, Georgia };


	enum Gender { Male, Female, Other};

	enum Contacts { Phone, Email, Fax };


	public struct Address   // value
	{
		public string City { get; set; }
		public string Street { get; set; }
		public int X { get; set; }
	    public int Y { get; set; }
	}

	public record Person(string Name);   //  reference

	public record struct Person2(string Name); // value  x y

	//init 

	//public record Person(string Name);


	internal class Employee  // reference
	{

		private string _name;
		private string _lastName;
		private DateTime _dateOfBirth;
		private string _contactValue;

		public Employee(string name, string lastName, DateTime dateOfBirth, Country country, Gender gender, Contacts contacts, string contactValue)
		{
			Name = name;
			LastName = lastName;
			DateOfBirth = dateOfBirth;
			Country = country;
			Gender = gender;
			Contacts = contacts;
			ContactValue = contactValue;
		}

		public string Name { get { return _name;} set
			{
				if (string.IsNullOrEmpty(value))
				{
					Console.WriteLine("Name cannot be empty");
					return;
				}
				_name = value;
			} 
		}
		public string LastName { get {return _lastName; } set
			{
				if (string.IsNullOrEmpty(value))
				{
					Console.WriteLine("LastName cannot be empty");
					return;
				}
				_lastName = value;
			}
		}
		public DateTime DateOfBirth { get { return _dateOfBirth; } set
			{ 
				if (value > DateTime.Now)
				{
					Console.WriteLine("Date of birth cannot be in the future");
					return;
				}
				_dateOfBirth = value;
			}
		}


		public Country Country { get; set; }
		public Gender Gender { get; set; }
		public Contacts Contacts { get; set; }

		public string ContactValue { get 
			{
				return _contactValue;
			} 
			
			set 
			{
				if(Contacts == Contacts.Phone && value.Length < 10)
				{
					Console.WriteLine("Phone number should have at least 10 digits");
					return;
				}
				if (Contacts == Contacts.Email && !value.Contains("@"))
				{
					Console.WriteLine("Email must contain @");
					return;
				}
				if(Contacts == Contacts.Email && !Regex.IsMatch(value, "^[^@\\s]+@[^@\\s]+\\.[^@\\s]+$" ))
				{
					
					Console.WriteLine("Invalid email format");
				}


				_contactValue = value;



				//Regex.IsMatch();


			} 
		}


		public int GetAge()
		{

			int age = DateTime.Now.Year - DateOfBirth.Year;

			if (DateTime.Now.DayOfYear < DateOfBirth.DayOfYear)
				age--;

			return age;
		}

		public override bool Equals(object? obj)
		{
			return obj is Employee employee &&
				   _name == employee._name &&
				   _lastName == employee._lastName &&
				   _dateOfBirth == employee._dateOfBirth &&
				   Name == employee.Name &&
				   LastName == employee.LastName &&
				   DateOfBirth == employee.DateOfBirth &&
				   Country == employee.Country &&
				   Gender == employee.Gender &&
				   Contacts == employee.Contacts &&
				   ContactValue == employee.ContactValue;
		}



		public override int GetHashCode()
		{
			HashCode hash = new HashCode();
			hash.Add(_name);
			hash.Add(_lastName);
			hash.Add(_dateOfBirth);
			hash.Add(Name);
			hash.Add(LastName);
			hash.Add(DateOfBirth);
			hash.Add(Country);
			hash.Add(Gender);
			hash.Add(Contacts);
			hash.Add(ContactValue);
			return hash.ToHashCode();
		}

		public override string? ToString()
		{
			return $"Name: {Name}, LastName: {LastName}, Age : {GetAge()}, Country:{Country}";
		}
	}






}
