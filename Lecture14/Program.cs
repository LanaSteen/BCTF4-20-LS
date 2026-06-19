using Lecture14.Helpers;
using Lecture14.Models;

namespace Lecture14
{
	internal class Program
	{
		static void Main(string[] args)
		{

			#region generic

			//generic - ზოგადი 
			//ზოგადი ტიპის მქონე


			//Box<int> box = new();
			//box.Value = 10;
			//box.Display();



			//var box2 = new Box<string>();
			//box2.Value = "Hello";
			//box2.Display();


			//Pair<int, string> pair = new() { FirstValue = 10, SecondValue = "KG" };

			//Pair<int, string> pair = new();
			//pair.FirstValue = 10;
			//pair.SecondValue = "KG";

			//Test test = new Test();

			//Test.Print<string>("hello");
			//Test.Print<int>(200);
			//Test.Print<bool>(true);


			//Test.Print("hello");
			//Test.Print(200);
			//Test.Print(true);



			//Test<int> test = new();
			//test.Value = 50;
			//test.DsiplayInfo<string>("hello");
			//Test<int>.Print<string>("text");




			#endregion




			//Student student = new Student();
			//student.Grade = new Grade() {Value =  95};
			//student.Comment = new Comment() {Value = "Good Work" };
			//student.PassedExame = new PassedExame() {Value = true };

			////student.Grade.Print();
			////student.Comment.Print();
			////student.PassedExame.Print();


			//student.Print(student.Grade);
			//student.Print(student.Comment);
			//student.Print(student.PassedExame);


			Student student = new Student();
			student.Grade = new Remark<int>() { Type = RemarkType.Grade, Value = 95 };

			student.Comment = new Remark<string>() { Type = RemarkType.Comment, Value = "Exelent work" };

			student.Passed = new Remark<bool>() { Type = RemarkType.Passed, Value = true };

			student.Grade.Print();
			student.Comment.Print();
			student.Passed.Print();





			Player player = new Player();

			Inventory inventory = new Inventory();
			inventory.Name = "Saxeli";
			inventory.Description = "decription";
			Inventory inventory2 = new Inventory();
			inventory2.Name = "Saxeli2";
			inventory2.Description = "decription2";

			player.Inventory = [inventory, inventory2];


			Enemy enemy = new Enemy();

			Weapon weapon = new();
			weapon.Name = "Saxeli";
			weapon.Damage = 50;
			Weapon weapon2 = new();
			weapon2.Name = "Saxeli2";
			weapon2.Damage = 20;


			Weapon weapon3 = new();
			weapon3.Name = "axali";
			weapon3.Damage = 50;

			enemy.Weapon = [weapon, weapon2];



			ArrayHelper.Add<Weapon>(ref enemy.Weapon, weapon3);  // todo ფილდად გადავაკეთე და მუშააობს     Weapon[] Weapon; // { get; set; }


			foreach (var item in enemy.Weapon)
			{
				Console.WriteLine(item.Name);
			}


		}





	

	}














	//saxeli asaki
	//saxeli passsed
	//5        kg



	//public class Test<T2>
	//{

	//	public T2 Value;


	//	public void DsiplayInfo<T1>(T1 param)
	//	{
	//		Console.WriteLine($"Name: {Value}  {param}");
	//	}


	//	public static void Print<T>(T param)
	//	{
	//		Console.WriteLine(param);
	//	}
	//}






	//public class Pair<T1, T2>
	//{
	//	public T1 FirstValue;
	//	public T2 SecondValue;

	//	public void Display()
	//	{
	//		Console.WriteLine($"{FirstValue} {SecondValue}");
	//	}
	//}




	//public class Box<T>
	//{
	//	public T Value;
	//	public void Display()
	//	{
	//		Console.WriteLine(Value);
	//	}
	//}


	//class IntBox
	//{
	//	public int Value;
	//	public void Display()
	//	{
	//		Console.WriteLine(Value);
	//	}
	//}
	//class StringBox
	//{
	//	public string Value;
	//	public void Display()
	//	{
	//		Console.WriteLine(Value);
	//	}
	//}
}
