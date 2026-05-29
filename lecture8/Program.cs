using System.Globalization;

namespace lecture8
{
	internal class Program
	{
		static void Main(string[] args)
		{



			//-500 -5

			//შექმენით int არაი და იპოვეთ მაქსიმალური და მინიმალური რიცხვები მასში.

			//	დააადგინეთ ეს რიცხვები არის პოზიტიური თუ ნეგატიური an toli 
			//   ლოკალური ფუნქციებით ვმუშაობთ 


			//min   max 




			//int[] numbers = [20, 60, -400, 50, 150, -60];




			//FindMinMAx(numbers);



			////void FindMinMAx(int[] nums, out int min, out int max)

			//void FindMinMAx(int[] nums)
			//{
			//    int min = nums[0];
			//    int max = nums[0];

			//	foreach (var item in nums)
			//	{
			//		if(item < min)
			//		{
			//			min = item;
			//		}
			//		else if(item > max)
			//		{
			//			max = item;
			//		}

			//	}

			//	Console.WriteLine($"maximum is {max} and it is {CheakNumber(max)}");

			//	Console.WriteLine($"minimum is {min} and it is {CheakNumber(min)}");
			//}





			//string CheakNumber(int num)
			//{
			//	if (num > 0)
			//	{
			//		return "positive";
			//	}
			//	else if (num < 0)
			//	{
			//		return "negative";
			//	}
			//	else
			//	{
			//		return "zero";

			//	}

			//}

			//Random r = new Random();


			//Product product1 = new() {

			//	Name = "Iphone 14 Pro Max",

			//};
			//product1.Id = 50;

			//var product2 = new Product();


			//product1.Id = 1;
			//product1.Name = "Iphone 14 Pro Max";
			//product1.Name = "Iphone 17 Pro Max";

			//product1.Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptas, voluptate.";
			//product1.Price = 5000m;
			//product1.Quantity = 10;
			//product1.Category = "Smartphones";
			//product1.Rating = 4.5f;
			//product1.IsAvelable = true;


			//product1.DisplayInfo();


			//product1.AddStock(5);

			////product1.Sale(0.5m);

			//product1.DisplayInfo();


			//Console.WriteLine(product1.Sale(0.5m));


			//float f = 3.14f;
			//decimal x = 1000m;  // money
			//double d = 5.2;




			//string path = "C:\\Users\\l4nst\\Desktop\\doit2026\\BCTF4-20-LS\\lecture8\\data.txt";


			string path2 = @"../../../data.txt";


			//File.ReadAllLines(path2);

			//Giorgi,Beridze,25,g.beridze @email.com,599123456

			string[] lines = File.ReadAllLines(path2);

			User[] users = new User[lines.Length];   


			for (int i = 0; i < lines.Length; i++)
			{
				//Console.WriteLine(lines[i]);   

				string[] parts = lines[i].Split(',');


				Console.WriteLine(parts[0]);

				users[i] = new User();


				users[i].Name = parts[0];
				users[i].LastName = parts[1];
				users[i].Age = byte.Parse(parts[2]);
				users[i].Email = parts[3];
				users[i].PhoneNumber = parts[4];
			}



			foreach (User user in users) {

				Console.WriteLine(user.Name + " " + user.LastName);
			
			
			}
		}
	}
}
