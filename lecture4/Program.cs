namespace lecture4
{
	internal class Program
	{
		static void Main(string[] args)
		{


			#region homework

			//			დავალება 2:
			//Calculator(switch-ით)
			//მომხმარებელი შეიყვანს:
			//•	რიცხვი 1
			//•	ოპერატორი(+-* /)
			//•	რიცხვი 2
			//კონსოლში გამოიტანე არითმეტიკული ოპერაციის შედეგი. (შემოყვანილი ოპერატორის შესაბამისად)

			//Console.WriteLine("enter first number");
			//int num1;
			//bool validNum1 = int.TryParse(Console.ReadLine(), out num1);  // 0

			//Console.WriteLine("enter opperator");
			//string opperator = Console.ReadLine();


			//Console.WriteLine("enter second number");
			//int num2;
			//bool validNum2 = int.TryParse(Console.ReadLine(), out num2);  // 0

			////%

			//if(validNum1 && validNum2)
			//{
			//	   switch (opperator)
			//	{
			//		case "+":
			//			Console.WriteLine(num1 + num2);
			//			break;
			//		case "-":
			//			Console.WriteLine(num1 - num2);
			//			break;
			//		case "*":
			//			Console.WriteLine(num1 * num2);
			//			break;

			//		case "%":
			//			Console.WriteLine(num1 % num2);  // ნაშთი   5 % 2 = 1
			//			break;
			//		case "/":

			//			if(num2 == 0) 
			//			{ 
			//				Console.WriteLine("division by zero not possible");
			//				break;
			//			}

			//			Console.WriteLine((double)num1 / num2);
			//			break;
			//		default:
			//			Console.WriteLine("invalid input");
			//			break;

			//	}

			//}
			//else 
			//{ 
			//	Console.WriteLine("invalid input");
			//}



			//int x = int.MaxValue;
			//x++;
			//Console.WriteLine(x + " " + int.MinValue);


			//დეციმალი  



			// დავალება 3 :
			//მომხმარებელს შეაყვანინე ასაკი:
			//დაადგინე და კონსოლში გამოიტანე:
			//•	ბავშვი(0–12)
			//•	თინეიჯერი(13–19)
			//•	ზრდასრული(20–64)
			//•	პენსიონერი(65 +)


			//byte age; 
			//bool ageVAlid = byte.TryParse(Console.ReadLine(), out age); // 0     -  255


			//if (ageVAlid)
			//{
			//	if(age <= 12)
			//	{
			//		Console.WriteLine("Child");
			//	}
			//	else if (age <=19)
			//	{
			//		Console.WriteLine("Teenager");
			//	} 
			//	else if (age <=64)
			//	{
			//		Console.WriteLine("Agult");
			//	}
			//	else
			//	{
			//		Console.WriteLine("Pansioner");
			//	}
			//}
			//else
			//{

			//	Console.WriteLine("invalid input");
			//}

			#endregion


			//loop   ციკლი    

			//dry  dont repeat yoursef

			//Console.WriteLine("hello");

			//საიდან                       სადაამდე        რამდენით იმატებს

			//იტერატორის ინიციალიზება      შედარება        ცვლილება
			//i                            c                u



			//for (int i = 0; i < 10; i++)
			//{
			//	Console.WriteLine("hi");
			//}

			//for (int i = 2; i <= 10; i+=2) /// ვეცადოთ შევამციროთ იტერაციები
			//{

			//	Console.WriteLine(i);

			//}


			//for (int i = 10; i >= 0; i--)
			//{
			//	Console.WriteLine(i);
			//}

			//მარტივია რომელიც თავისთავზე და 1 ზე იყოფა   // 2 3 5 
			// 4 6 

			//for (int i = 2; i < 10; i++)
			//{
			//	//Console.WriteLine(i);
			//	int count = 0;

			//	for (int j = 2; j < i; j++)
			//	{
			//		//Console.WriteLine(j);

			//		if(i % j == 0)
			//		{
			//			count++;
			//		}
			//	}

			//	if(count > 0)
			//	{
			//		Console.WriteLine(i + " " + count);
			//	}


			//}


			//for( ; ; )
			//{

			//}
			//Console.WriteLine("Enter age");
			//bool validAge = int.TryParse(Console.ReadLine(), out int age);

			//while (!validAge)
			//{
			//	Console.WriteLine("Try again");
			//	validAge = int.TryParse(Console.ReadLine(), out age);
			//}

			//Console.WriteLine(age);





			//int i = 0;
			//while (i<10)
			//{

			//	i++;

			//	if (i == 2)
			//	{
			//		continue;  // ციკლის ამ ეტაპზე შეჩერება და შემდეგი იტერაციის დაწყება
			//	}
			//	Console.WriteLine(i);

			//	if (i == 5) 
			//	{
			//		break;  // ციკლიდან გამოსვლა
			//	}


			//}




			//int x = 5;
			//while (x > 5)
			//{
			//	Console.WriteLine(x);
			//	x++;
			//}


			//int x = 5;

			//do
			//{
			//	Console.WriteLine(x);
			//	x++;
			//}
			//while (x > 6);








			//foreach (var item in args)
			//{

			//}


			//int sum = 0;

			//for (int i = 0; i < 10; i++)
			//{
			//	sum += i;
			//}


			//Console.WriteLine(sum);



			Random r = new Random();


			Console.WriteLine(r.Next(0,100));






			Console.ReadKey();   // ვაჩერებ კონსოლს

		}
	}
}
