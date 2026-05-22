namespace lecture5
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Console.WriteLine("enter number");
			//bool validNum = byte.TryParse(Console.ReadLine(), out byte num);

			//while (!validNum)
			//{
			//	Console.WriteLine("enter again");
			//	validNum = byte.TryParse(Console.ReadLine(), out num);
			//}

			//*    
			// * *
			// * * * 


			//for (int i = 1; i <= num; i++)
			//{
			//	for (int j = 1; j <= num-i; j++)
			//	{
			//		Console.Write(" ");
			//	}
			//	for (int k = 1; k <= i; k++)
			//	{
			//		Console.Write("* ");
			//	}
			//	Console.WriteLine();
			//}


			//0
			//დაწერეთ პროგრამა რომელიც კონსოლიდან წაკითხულ რიცხვამდე დააჯამებს ყველა
			//ლუწ რიცხვს და პასუხი გამოიტანეთ კონსოლში
			//Console.WriteLine("enter number");

			//bool validNum = int.TryParse(Console.ReadLine(), out int num);
			//int sum = 0;

			//if (validNum)
			//{
			//	for (int i = 2; i < num; i+=2)
			//	{ 
			//	 //  if(i % 2 == 0)
			//		//{
			//			sum += i;
			//		//}
			//	}
			//}
			//Console.WriteLine(sum);



			//დაწერეთ პროგრამა რომელიც აირჩევს რენდომულ რიცხვს.
			//მომხმარებელმა შემოიყვანოს კონსოლიდან რიცხვი მანამ არ გამოიცნობს არჩეულ რენდომულ რიცხვს.

			//Random r = new Random();

			//int randomNum = r.Next(1,50);
			//Console.WriteLine("random num " + randomNum);
			//Console.WriteLine("Enter number");
			//bool validNum = int.TryParse(Console.ReadLine(), out int userNum);

			//while(!validNum || randomNum!= userNum)
			//{
			//	Console.WriteLine("Enter again");
			//	validNum = int.TryParse(Console.ReadLine(), out userNum);
			//}
			//Console.WriteLine("You win");



			#region cw ATM

			//decimal balance = 1000;

			//byte choosenum = 0;

			//while (true) 

			//{
			//	Console.WriteLine("Your opperation 1  2  3  4 ");

			//	bool validChoose = byte.TryParse(Console.ReadLine(), out choosenum);

			//	if (!validChoose || choosenum > 4 || choosenum < 1 ) 
			//	{
			//		Console.WriteLine("Try again 1 2 3 4");
			//		continue;

			//	}

			//	switch (choosenum) 
			//	{ 
			//		case 1:
			//			Console.WriteLine(balance);
			//			break;

			//		case 4:
			//			Console.WriteLine("Good Bye");
			//			break;   // return
			//		case 2:
			//			while (true)
			//			{
			//				Console.WriteLine("enter amount of deposit");
			//				bool validamount = decimal.TryParse(Console.ReadLine(), out decimal amount);
			//				if(!validamount ||  amount <= 0)
			//				{
			//					Console.WriteLine("Deposit must be number or bigger then 0");
			//					continue;
			//				}

			//				balance += amount;
			//				break;
			//			}
			//			break;
			//		case 3:

			//			if (balance == 0) break;

			//			while (true)
			//			{
			//				Console.WriteLine("enter amount of takeout");
			//				bool validamount = decimal.TryParse(Console.ReadLine(), out decimal amount);
			//				if (!validamount || amount <= 0 || amount >balance)
			//				{
			//					Console.WriteLine("takeout must be number or bigger then 0");
			//					continue;
			//				}

			//				balance -= amount;
			//				break;
			//			}
			//			break;
			//	}


			//}

			#endregion




			//კოლექცია 

			//int student1Point = 10;
			//int student2Point = 20;
			//int student3Point = 20;

			//student1Point += 1;
			//student2Point += 1;

			//{ }

			int[] points = [20,25,10,60, 100, 250, 50];  // 7

			points[0] = 600;
			points[6] = 150;
			//points[7] = 200;  
			//points[8] = 200;                    //0  1   2 ...
			Console.WriteLine(points.Length);

			//Console.WriteLine(points[0]);  /// პირველი ელემენტი
			//Console.WriteLine(points[1]);  /// მეორე ელემენტი
			//Console.WriteLine(points[2]);
			//Console.WriteLine(points[3]);
			//Console.WriteLine(points[points.Length-1]);
			/// ბოლო ელემენტი 

			for (int i = 0; i <= points.Length - 1; i++)
			{
				points[i] += 1;
				Console.WriteLine(points[i]);
			}


			//foreach (int point in points)
			//{
			//	Console.WriteLine(point);
			//}


			int x = 5;
			int y = x;

			x = 10;
			Console.WriteLine(x);  // 10
			Console.WriteLine(y);  // 5




			int[] arr = [20, 30, 60];
			int[] arr2 = arr;

			arr2[0] = 100;


			Console.WriteLine(arr[0]);   // 100

			Console.WriteLine(arr2[0]);  // 100

			Console.WriteLine(arr.Length);

			//არაი რეფერენს ტიპია 


			string[] texts = ["fdf", "fdfd"];
			Console.WriteLine(texts[0][0]);

		}
	}
}
