using Lecture16.Helpers;
using Lecture16.Services;
using System.Linq.Expressions;

namespace Lecture16
{
	internal class Program
	{
		static void Main(string[] args)
		{

			#region hw


			//List<string> names = new List<string>();

			//Dictionary<string, int> studentsScores = new Dictionary<string, int>();

			//int choose=-1;


			//using (Logger logger = new Logger())

			//{
			//	try
			//	{
			//		while (true)
			//		{
			//			Console.WriteLine("1. Add student");
			//			Console.WriteLine("2. find student");
			//			Console.WriteLine("3. update score");
			//			Console.WriteLine("4. show all students");
			//			Console.WriteLine("0. Exit");

			//			choose = int.Parse(Console.ReadLine());



			//			switch (choose)
			//			{
			//				case 1:
			//					Console.Write("Enter student name: ");
			//					string name = Console.ReadLine();

			//					Console.WriteLine();

			//					Console.Write("Enter student score: ");
			//					int score = int.Parse(Console.ReadLine());

			//					if (score < 0 || score > 100)
			//					{
			//						throw new Exception("Score must be between 0 and 100");
			//					}
			//					if (String.IsNullOrWhiteSpace(name))
			//					{
			//						throw new Exception("Name cannot be empty");
			//					}


			//					if (names.Contains(name))
			//					{
			//						Console.WriteLine("Name already exists");
			//						throw new Exception("Name already exists");
			//					}
			//					else
			//					{
			//						names.Add(name);
			//						studentsScores.Add(name, score);
			//						logger.Log($"{name} got score: {score}");
			//					}

			//					break;
			//				case 2:
			//					Console.WriteLine("Enter student name: ");
			//					name = Console.ReadLine();


			//					if (names.Contains(name))
			//					{
			//						Console.WriteLine($"{name} has score: {studentsScores[name]}");
			//					}
			//					else
			//					{
			//						Console.WriteLine("Name not found");
			//					}
			//					break;
			//				case 3:
			//					Console.WriteLine("Enter student name: ");
			//					name = Console.ReadLine();


			//					if (names.Contains(name))
			//					{
			//						Console.WriteLine("Enter student score: ");

			//						studentsScores[name] = int.Parse(Console.ReadLine());


			//						Console.WriteLine($"{name}'s  score changed: {studentsScores[name]}");
			//						logger.Log($"{name}'s  score changed: {studentsScores[name]}");
			//					}
			//					else
			//					{
			//						Console.WriteLine("Name not found");
			//					}
			//					break;
			//				case 4:

			//					if (names.Count == 0)
			//					{
			//						Console.WriteLine("list is empty");
			//						break;
			//					}
			//					foreach (var item in studentsScores)
			//					{
			//						Console.WriteLine(item.Key + " has score: " + item.Value);
			//					}
			//					break;
			//				case 0:
			//					Console.WriteLine("Apprication closed");
			//					return;
			//				default:
			//					Console.WriteLine("invalid input");
			//					logger.Log("invalid input");
			//					break;
			//			}

			//		}

			//	}
			//	catch (Exception ex)
			//	{
			//		Console.WriteLine(ex.Message);
			//		logger.Log(ex.Message);
			//	}

			//}

			#endregion



			string[] strArr = ["abc5", "de99f", "ghi"];

			List<int> ints = new List<int>() { 20, 60, 30, 70 };


			//Console.WriteLine(Algorithms.FindElemtn(strArr, "abc"));

			//Console.WriteLine(Algorithms.FindElemtn(ints, 30));   // 50 metia


			//Console.WriteLine(Algorithms.FindFirstElementByLogic(ints, IsGreaterThan50));

			//Console.WriteLine(Algorithms.FindFirstElementByLogic(ints, IsGreaterThan65));


			//Console.WriteLine(Algorithms.FindFirstElementByLogic(ints, delegate (int socre)
			//{
			//	return socre > 65;
			//}));



			//Console.WriteLine(Algorithms.FindFirstElementByLogic(strArr, delegate (string name) { return name.Length >= 5; }));
			//Console.WriteLine(Algorithms.FindFirstElementByLogic(strArr,  name => name.Length >= 5));

			Console.WriteLine(Algorithms.FindFirstElementByLogic(ints,  socre => socre > 65  ));
			Console.WriteLine(Algorithms.FindFirstElementByLogic(ints, IsGreaterThan65));
			Console.WriteLine(Algorithms.FindFirstElementByLogic(ints, IsGreaterThan50));
			//65  Callback

		}


		//LambdaExpression  arrow funcction  ანონომმური 



		public static bool IsGreaterThan50(int socre)  => socre > 50;


		public static bool IsGreaterThan65(int socre) 
		{
		   return socre > 65;
		} 
		
	}
}
