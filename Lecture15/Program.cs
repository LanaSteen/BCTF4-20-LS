using Lecture15.Enums;
using Lecture15.Helpers;
using Lecture15.Models;
using Lecture15.Services;
using System.Text;

namespace Lecture15
{
	internal class Program
	{
		static void Main(string[] args)
		{


			#region collections


			#region list


			//Array   -  fixed size, same type

			//List<int> list = new List<int>();  // List is a dynamic array, can grow and shrink in size, same type

			//list.Add(5);
			//list.Remove(5);

			//list.AddRange(50,100,50);


			//int[] arr = [50, 30, 80, 90];

			//list.AddRange(arr);

			//list.Insert(0, 100);   //  პირველი ინდექსი მმეორე ელემენტი
			//list.RemoveAt(0); // 100

			//Console.WriteLine(list[0]);



			//Console.WriteLine(list.Max());
			//Console.WriteLine(list.Min());
			//Console.WriteLine(list.Average());



			//foreach (var item in list)
			//{
			//	Console.WriteLine(item);
			//}


			////Array Lenght    list Count

			//for (int i = 0; i < list.Count; i++)
			//{
			//	Console.WriteLine(list[i]);
			//}

			//list.Add("dssd"); // error/





			//List<string> listStr = new List<string>();
			//listStr.Add("Hello");
			//listStr.Add("World");

			//listStr[0] = "C#"; 


			////listStr.Insert(0, "C#");
			//listStr.RemoveAt(1);


			//string[] arrStr = ["C#", "World"];

			//arrStr.ToList();

			//listStr = listStr.Concat(arrStr).ToList();


			//       string[] strings = listStr.ToArray();






			//foreach (var item in listStr)
			//{
			//	Console.WriteLine(item);
			//}



			//List<int> list = new List<int>();

			//Console.WriteLine(list.Count);
			//Console.WriteLine(list.Capacity);


			//list.Add(100);

			//Console.WriteLine(list.Count);
			//Console.WriteLine(list.Capacity);

			//list.Add(100);
			//list.Add(100);
			//list.Add(100);
			//list.Add(100);
			//list.Add(100);
			//list.Add(100);
			//list.Add(100);
			//list.Add(100);

			//Console.WriteLine(list.Count);
			//Console.WriteLine(list.Capacity);


			//list.TrimExcess();

			//Console.WriteLine(list.Count);
			//Console.WriteLine(list.Capacity);

			//list.Add(100);
			//Console.WriteLine(list.Count);
			//Console.WriteLine(list.Capacity);


			//Console.WriteLine(list[16]);      /// out of range error

			//for (int i = 0; i < list.Capacity; i++)    /// out of range error
			//{
			//	Console.WriteLine(list[i]);
			//}





			#endregion


			#region dictionary

			//hello  - გამარჯობა
			//key   value pair - key value წყვილი

			//   Manager - 599599599

			//HeplDesk - 56565656


			//Dictionary<string, string> dictionary = new Dictionary<string, string>();


			//dictionary["Manager"] = "599599599";
			//dictionary["HelpDesk"] = "56565656";


			//if(dictionary.ContainsKey("Manager"))
			//{
			//	Console.WriteLine(dictionary["Manager"]);
			//}


			//foreach (var item in dictionary)
			//{
			//	//Console.WriteLine(item);
			//	Console.Write(item.Key);
			//	Console.Write("- ");
			//	Console.Write(item.Value);
			//	Console.WriteLine();
			//}

			#endregion


			#region queue and stack


			//Queue<string> queue = new Queue<string>();   // FIFO - First In First Out

			//queue.Enqueue("Hello");
			//queue.Enqueue("World");
			//queue.Enqueue("World2");
			//queue.Enqueue("World3");


			//Console.WriteLine(queue.Peek()); /// გვაწვდის მაგრამ არ შლის 


			//queue.Dequeue();  // პირველი ელემენტი გვაძლევს  შლის და
			//Console.WriteLine(queue.Peek());

			//foreach (var item in queue)
			//{
			//	Console.WriteLine(item);
			//}



			//Stack<int> stack = new Stack<int>();   // LIFO - Last In First Out

			//stack.Push(100);
			//stack.Push(200);
			//stack.Push(300);

			//Console.WriteLine(stack.Pop());  // 300
			//Console.WriteLine(stack.Pop());  // 200
			//Console.WriteLine(stack.Pop());  // 100

			#endregion


			#endregion



			Student student = new Student("John", "Doe", 20, "john.doe@example.com", "599595959", 4.5, Faculty.IT);


			StudentManagerService stServ = new StudentManagerService();
			

			ArrayHelper.Add(ref stServ.students, student);



			//foreach (var item in stServ.students)
			//{
			//	Console.WriteLine(item);
			//}



			Console.InputEncoding = Encoding.UTF8;
			Console.OutputEncoding =Encoding.UTF8;




			string chooser = "1";
			while (chooser != "8")
			{
				Console.WriteLine("\n--- menu ---");
				Console.WriteLine("1.ყველა სტუდენტის ჩვენება");
				Console.WriteLine(" 2.საუკეთესო სტუდენტის პოვნა");
				Console.WriteLine("3.GPA - ის საშუალოს გამოთვლა");
				Console.WriteLine(" 4.სტუდენტის ძებნა გვარით");
				Console.WriteLine("5.სტუდენტების დალაგება GPA-ის მიხედვით");
				Console.WriteLine("6.ახალი სტუდენტის დამატება");
				Console.WriteLine("7.სტუდენტის წაშლა");
				Console.WriteLine("8.პროგრამიდან გასვლა");
				chooser = Console.ReadLine();


				switch (chooser)
				{
					case "1":
						stServ.PrintAllStudents();
						Console.WriteLine("PrintAllStudents method");
						break;
					case "2":
						//stServ.FindBeststudent();
						Console.WriteLine("PrintAllStudents method ");
						break;
					case "3":
						//stServ.GetAverageGPA();
						Console.WriteLine("PrintAllStudents method ");
						break;


					case "8":
						Console.WriteLine("applicaton finished ");
						return;


					default: Console.WriteLine("invalid choose"); 
						break;


				}


			}





		}
}
}
