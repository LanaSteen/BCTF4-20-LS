namespace lecture2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Console.WriteLine("hi!");


			//byte x = 10;

			//int y = x;  // 10  6554645654654654   // implicit cast  არაცხადი


			//int x = 10;  // byte 255

			//byte b = (byte)x;   //   explicit cast  ცხადად   ok

			//255
			//0 1     


			//int num = 257;
			//byte b = (byte)num;    // wrap  


			//Console.WriteLine("enter your age");    
			//string strAge = Console.ReadLine();   //"50"  string

			//int age = int.Parse(strAge);  // 50    
			//byte bage = byte.Parse(strAge);  // 50  

			//Console.WriteLine(strAge);





			//string strPoint = "100";
			//int pont = Convert.ToInt32(strPoint);  //100



			//int.TryParse("dddd", out int x);  // 0 
			//Console.WriteLine(x);


			//int num;

			//num = 50;


			////{  }  scopes			


			//bool parsedOk = int.TryParse("ddd", out int x);  // 0 

			//bool isOk = true;
			//bool isNotOk = false;




			//Console.WriteLine(typeof(int));     
			//Console.WriteLine(sizeof(int));






			//+ - * /              

			//int score = 0;
			//score = score + 1;  // 1 
			//Console.WriteLine(score);  //


			///     ++   --   
			///     

			//int num1 = 5;
			////num1++;  // 6
			////num1--;  // 5

			//Console.WriteLine(--num1);  //4



			//int x = 5; 
			//int y = x++;




			//+=10  -=20 *=2 /=3
			//


			//int x = 10;
			//x = x + 10;
			//x += 10;




			//int x = 10;
			//x *= 10;  // 100



			//% 

			//Console.WriteLine(4%2);  //ნაშთი არის 0
			//Console.WriteLine(1000001 % 2);  //ნაშთი არის 1



			//105    5 
			//300    21 


			//int x = 11;
			//x %= 2;   // 1



			//შედარება
			//> < >=  <=    ==   !=


			//Console.WriteLine(5>2);  //  bool true false
			//Console.WriteLine(5<=8);  // true
			//Console.WriteLine(5==5);   // true
			//Console.WriteLine(5==6);   // false
			//Console.WriteLine(5!=7);  // true
			//Console.WriteLine(5!=5) ;  // false


			//&& და       ||  ან       !  არა

			//Console.WriteLine(5>2 && 6>1 && 4>5);   // false
			//Console.WriteLine(5>1 || 6>8); // true
			//Console.WriteLine(!true);  // false

			//bool userAgreed = true;

			//Console.WriteLine(!userAgreed);





			//ტერნარი ოპერატორი ?:

			//bool userAgreed = true;
			//Console.WriteLine(userAgreed ? "allowed" : "not allowed" );








			//age++  25    251


			//string strAge = Console.ReadLine();

			//Console.WriteLine(strAge + 1);  // 501


			int userAge = 50;
			string userName = "John";
			userName = "Vime sxva";

			Console.WriteLine("hello " + userName + " " + userAge);


			Console.WriteLine($"hello {userName} {userAge} ");  //  სტრინგის ინტერპოლაცია

			//?:     ??





		}
	}
}
