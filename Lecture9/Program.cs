namespace Lecture9
{
	internal class Program
	{
		static void Main(string[] args)
		{




			#region hw
			//string path = @"../../../CarsData.txt";


			//string[] strings = File.ReadAllLines(path);    //Toyota,Corolla,2022,25000,White


			//Car[] cars = new Car[strings.Length];

			//for (int i = 0; i < strings.Length; i++)
			//{
			//	string[] data = strings[i].Split(','); //  ["Toyota","Corolla,2022,25000,White]

			//	cars[i] = new Car();
			//	cars[i].Brand = data[0];
			//	cars[i].Model = data[1];
			//	cars[i].Year = int.Parse(data[2]);
			//	cars[i].Price = decimal.Parse(data[3]);
			//	cars[i].Color = (Color)Enum.Parse(typeof(Color), data[4]);

			//}



			//Car[] cars = Car.ReadCarsFromFile(path);

			//cars[0].PrintInfo();

			//Car.PrintAllCarsInfo(cars);





			#endregion





			Teacher t = new Teacher();
			t.Name = "Test";
			t.LastName = "Test5";
			t.Age = 20;
			Console.WriteLine(t.Name);


			Lesson les = new Lesson();
			Lesson les2 = new Lesson();



			t.Lessons = [les, les2];


			Console.WriteLine("bonus " + t.GetBonus());


			t.PrintInfo();


			Student student = new Student();
			student.LastName = "Test2";

			Console.WriteLine(student.LastName);



			Manager manager = new Manager();
			manager.Salary = 5000m;
			Console.WriteLine(manager.Salary);

		}
	}
}
