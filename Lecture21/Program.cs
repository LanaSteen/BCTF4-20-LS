using FluentValidation;
using Spectre.Console;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Lecture21
{
	[Author("L.Steen", Verion = 1.0)]
	[Author("J.Doe", Verion = 1.1)]
	public class Product
	{
		[JsonPropertyName("ProductName")]
		public string Name { get; set; }

		[JsonIgnore]
		public decimal Price { get; set; }
	}


	#region customAttribute
	[AttributeUsage(AttributeTargets.Class , AllowMultiple = true)]
	public class AuthorAttribute : Attribute
	{
		public string Name { get; set; }
		public double Verion { get; set; }

		public AuthorAttribute(string name)
		{
			
		    Name = name;
			
		}

	}
	#endregion


	//{"Name" : "rame saxeli", "Price" : 50505 }

	//"rame saxeli", 50505

	//<Name>rame saxeli</Name>
	//<Price>50505</Price>



	public class User
	{
		[Required]
		[MinLength(3 , ErrorMessage = "too short"), MaxLength(10, ErrorMessage ="too long")]
		public string Username { get; set; }

		[Range(0, 120, ErrorMessage = "age must be between 0 and 120")]
		public int Age { get; set; }
	}


	#region FluentValidation

	public class User1
	{
		public string Name { get; set; }
		public int Age	{ get; set; }

		public User1(string name, int age)
		{


			Name = name;
			Age = age;


			var validator = new UserValidator();
			var result = validator.Validate(this);
			if (!result.IsValid)
			{
				throw new FluentValidation.ValidationException(result.Errors);
			}
		}



	}
	//fluent validation
	public class UserValidator : AbstractValidator<User1>
	{

		public UserValidator()
		{
			RuleFor(x => x.Name).NotEmpty().WithMessage("name is required");
			RuleFor(x => x.Name).Length(3, 10).WithMessage("name must be between 3 and 10 characters");
			RuleFor(x => x.Age).InclusiveBetween(0, 120).WithMessage("age must be between 0 and 120");
		}
	}

	#endregion

	internal class Program
	{
		static void Main(string[] args)
		{


			User1 user1 = new User1("rame", -50);

			Console.WriteLine(user1.Name +  " " + user1.Age);





			#region validation
			User user = new User() { Username = "JonDoe", Age = 130 };


			var context = new ValidationContext(user);


			var results = new List<System.ComponentModel.DataAnnotations.ValidationResult>();


			var isValid = Validator.TryValidateObject(user, context, results, true);

			if (!isValid)
			{
				foreach (var item in results)
				{
					Console.WriteLine(item.ErrorMessage);
					throw new Exception();
				}
			}
			else
			{
				Console.WriteLine(user.Username, " " + user.Age);
			}


			#endregion

			#region attributes

			//Type typeOfProduct = typeof(Product);
			//var attributes = Attribute.GetCustomAttributes(typeOfProduct);
			//foreach (var item in attributes)
			//{
			//	if(item is AuthorAttribute)
			//	{
			//		var itemcasted = (AuthorAttribute)item;
			//		Console.WriteLine(itemcasted.Name + " " + itemcasted.Verion);
			//	}

			//}




			//Product product = new Product() {Name = "rame saxeli", Price = 5050 };

			//Console.WriteLine(JsonSerializer.Serialize(product));











			#endregion





			#region reflection

			//reflection 

			//IL.   JIT   Assamble   


			//Type type = typeof(Rame);

			//Console.WriteLine("properties");
			//PropertyInfo[] properties = type.GetProperties();
			//foreach (var item in properties)
			//{
			//	Console.WriteLine(item);
			//}


			//Console.WriteLine("fields");

			//FieldInfo[] fileds = type.GetFields();
			//foreach (var item in fileds)
			//{
			//	Console.Write(item.Name);
			//	Console.Write("-");
			//	Console.Write(item.DeclaringType);
			//	Console.WriteLine(item.FieldType);
			//	Console.WriteLine();
			//}

			//Console.WriteLine("methods");
			//MethodInfo[] methods = type.GetMethods();
			//foreach (var item in methods)
			//{
			//	Console.WriteLine(item);
			//}


			#endregion


			#region consolestyle

			//Console.ForegroundColor = ConsoleColor.Yellow;
			//Console.BackgroundColor = ConsoleColor.Green;

			//Console.WriteLine("Hello, World!");

			//Console.ResetColor();


			//Console.WriteLine("Hello, World!");



			//var name = AnsiConsole.Ask<string>("What's your [green]name[/]?");
			//AnsiConsole.MarkupLine($"Welcome, [blue]{name}[/]!");



			//		var toppings = AnsiConsole.Prompt(
			//new MultiSelectionPrompt<string>()
			//	.Title("What [green]toppings[/] would you like?")
			//	.NotRequired()
			//	.InstructionsText("[grey](Press [blue]<space>[/] to toggle, [green]<enter>[/] to confirm)[/]")
			//	.AddChoices("Pepperoni", "Mushrooms", "Sausage",
			//				"Onions", "Green Peppers", "Black Olives",
			//				"Extra Cheese", "Bacon", "Pineapple"));

			//		foreach (var item in toppings)
			//		{
			//			Console.WriteLine(item);
			//		}


			//if (toppings.Count == 0)
			//{
			//	AnsiConsole.MarkupLine("A plain cheese pizza - classic choice!");
			//}
			//else
			//{
			//	AnsiConsole.MarkupLine($"Toppings: [yellow]{string.Join(", ", toppings)}[/]");
			//}




			//		var size = AnsiConsole.Prompt(
			//new SelectionPrompt<string>()
			//	.Title("What [green]size pizza[/] would you like?")
			//	.AddChoices("Small", "Medium", "Large", "Extra Large"));

			//		AnsiConsole.MarkupLine($"You selected: [yellow]{size}[/]");


			#endregion

		}
	}
}
