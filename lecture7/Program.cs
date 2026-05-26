namespace lecture7
{

	//O O P   
	internal class Program
	{
		static void Main(string[] args)
		{

			#region hw

			//			1.შექმენით jagged array სადაც: თითოეულ სტუდენტს აქვს სხვადასხვა რაოდენობის ქულა.
			//			იპოვეთ თითოეულის საშუალო ქულა.

			//[,]
			//int[][] points = 
			//	[
			//	[85, 90, 78],
			//	[92, 88, 95, 60],
			//	[76, 82, 89]
			//	];
			//int index = 1;
			//foreach (var student in points)
			//{
			//	double sumRow = 0;

			//	foreach (var point in student)
			//	{

			//		sumRow += point;

			//	}
			//	Console.WriteLine("Student " + index  + " average: " + sumRow / student.Length);
			//	index++;
			//}

			//2.შექმენით რენდომული 4 ნიშნა პასკოდების არაი(10 წევრი).მომხმარებელს
			//შემოაყვანინეთ კოდი და თუ რომელიმეს დაემთხვა არაიში დაუბეჭდეთ “Correct” თუ
			//არა და “Wrong”.
			//
			//string[] codes = new string[10];

			//Random r = new Random();

			//for (int i = 0; i < codes.Length; i++)
			//{
			//	codes[i] = r.Next(1000, 9999).ToString();
			//}


			//Console.WriteLine("Enter code: ");
			//string input = Console.ReadLine();

			//bool isCorrect = false;

			//foreach (var code in codes)
			//{
			//	if (code == input)
			//	{
			//		isCorrect = true;
			//		break;

			//	}
			//}

			//Console.WriteLine(isCorrect ? "Correct" : "Wrong");


			//3.შექმენით int-ების(მათ შორის ნეგატიური რიცხვებიც) მასივი.
			//იპოვეთ მინიმალური და მაქსიმალური რიცხვები(არ გამოიყენოთ არაის მეთოდები).
			//
			//int[] numbers = [20, 60, -400, 50, 150, -60];
			//int min = numbers[0];
			//int max = numbers[0];


			//foreach (int num in numbers)
			//{
			//	if (num < min )
			//	{
			//		min = num;
			//	}
			//	if (num > max)
			//	{
			//		max = num;
			//	}

			//}


			//Console.WriteLine($"minimum is {min} and maximum {max}");



			//int x = 5;  // 10
			//int y = 10;  // 5

			//int temp = x;  // 5
			//x = y;  // 10

			//y = temp;  //5

			//x = y; // 10

			//y = x;  // 10




			//int[] numbers = [20, 60, -400, 50, 150, -60];

			//foreach (var item in numbers)
			//{
			//	for (int i = 0; i < numbers.Length - 1; i++)
			//	{
			//		if (numbers[i] > numbers[i + 1])
			//		{
			//			int temp = numbers[i];
			//			numbers[i] = numbers[i + 1];
			//			numbers[i + 1] = temp;

			//		}
			//	}
			//}

			//Console.WriteLine(numbers[0] +  numbers[numbers.Length-1]);


			//4.შექმენით სტრინგების მასივი და კონსოლში დაბეჭდეთ ყველა ელემენტის ყველა
			//სიმბოლო(არ გამოიყენოთ არაის მეთოდები).
			//
			//string[] texts = ["Hello World", "Greetings", "Goodbye"];

			//foreach (string text in texts)
			//{
			//	foreach (var symbol in text)
			//	{
			//		Console.WriteLine(symbol);
			//	}
			//}


			//for (int i = 0; i < texts.Length; i++)
			//{
			//	for (int j = 0; j < texts[i].Length; j++)
			//	{
			//		Console.WriteLine(texts[i][j]);
			//	}
			//}




			//5.შექმენით იმეილების მასივი და დაადგინეთ ყველა ელემენტი თუ შეიცავს @ სიმბოლოს.
			//(არ გამოიყენოთ არაის და სტრინგის ჩაშენებული მეთოდები).

			//string[] emails = ["dsdsd@dsds", "ddd@dsd"];
			//int count = 0;

			//for (int i = 0; i < emails.Length; i++)
			//{
			//	//bool contains = false;
			//	for (int j = 0; j < emails[i].Length; j++)
			//	{
			//		if (emails[i][j] =='@')
			//		{
			//			//contains = true;
			//			count++;
			//		}
			//	}
			//}

			//Console.WriteLine(count == emails.Length ? "all valid" : "not valis emails some of them");


			#endregion


			#region localFunctions

			//void   return
			// პარამეტრიანი და უპარამეტრებო


			//string x  = Console.WriteLine("ddfh");
			//string y =   Console.ReadLine();


			//void Test() 
			//{
			//	for (int i = 0; i < 10; i++)
			//	{
			//		Console.WriteLine("Hi");
			//	}

			//}

			//Test();


			//void SayHello(string greeting) 
			//{
			//	Console.WriteLine(greeting);
			//}

			//SayHello("hi");
			//SayHello("bonjorno");

			#endregion
			
			
			//Random r = new Random();
			//r.Next();

			//Test();

			//Console.WriteLine();


			//int x = Test2();


			//int sum = Sum(5,10);


			//Person persona = new Person();
			//persona.Name = "John";
			//persona.Age = 50;



			User user1 = new User("dsds","fdfd@dsdsds");
			Console.WriteLine(user1.UserName);
			Console.WriteLine(user1.Email);
			user1.DisplayInfo();
		}

		#region methods

		public static void Test()
		{
			Console.WriteLine("hello");
		}


		public static int Test2()
		{
			return 100;
		}


		public static int Sum(int x, int y)
		{
			return x + y;
		}
		#endregion
	}




	public class Person()     // კონსტრუქტორი //  
	{

		//ctor
		//public Person()
		//{

		//}
		public string Name;  // feald
		public int Age;

	}




}
