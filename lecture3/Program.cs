using System.Text;

namespace lecture3
{
	internal class Program
	{
		static void Main(string[] args)
		{

			#region hw
			//			დავალება 1
			//დაწერეთ C# Sharp პროგრამა, რომლითაც მომხმარებელი შეიყვანს ამომრჩევლის ასაკს და პროგრამა განსაზღვრავს, აქვს თუ არა მას არჩევნებზე ხმის მიცემის უფლება.
			//შესაყვანი სატესტო მონაცემი: 18
			//მოსალოდნელი შედეგი: გილოცავ! ხმის მიცემის უფლება გაქვთ.
			//–––––––––––––––––––––––
			//შესაყვანი სატესტო მონაცემი: 15
			//მოსალოდნელი შედეგი: სამწუხაროდ ხმის მიცემის უფლება ჯერ არ გაქვთ.

			//Console.OutputEncoding = Encoding.UTF8;


			//Console.WriteLine("შეიყვანეთ ამომრჩევლის ასაკს: ");

			//byte age; 

			//bool validAge = byte.TryParse(Console.ReadLine(), out age);


			//Console.WriteLine(validAge && age >=18 

			//	? "გილოცავ! ხმის მიცემის უფლება გაქვთ" 

			//	: "სამწუხაროდ ხმის მიცემის უფლება ჯერ არ გაქვთ");






			//დავალება 2
			//დაწერეთ C# პროგრამა, რომელიც დაადგენს სამ რიცხვს შორის უდიდესს.
			//შესაყვანი სატესტო მონაცემი:
			//			შეიყვანეთ პირველი რიცხვი: 25
			//შეიყვანეთ მე-2 რიცხვი: 63
			//შეიყვანეთ მე-3 რიცხვი: 10
			//2 | P a g e
			//მოსალოდნელი შედეგი: მე - 2 რიცხვი მაქსიმალურია წარმოდგენილ რიცხვებს შორის.


			//Console.WriteLine("enter first number");

			//int firstNum;
			//  //false
			//bool firstValid = int.TryParse(Console.ReadLine(), out firstNum);  // 0



			//Console.WriteLine("enter second number");

			//int secondNum;
			//bool secondValid = int.TryParse(Console.ReadLine(), out secondNum);


			//Console.WriteLine("enter third number");

			//int thirdNum;
			//bool thirdValid = int.TryParse(Console.ReadLine(), out thirdNum);




			//int max = firstNum;   // int.MinValue 

			//max = max < secondNum && secondValid  ? secondNum : max;

			//max = max < thirdNum && thirdValid ? thirdNum : max;



			//Console.WriteLine(max);

			//დავალება 3
			//დაწერეთ C# პროგრამა ორი მოცემული მთელი რიცხვის ჯამის გამოსათვლელად. თუ ეს ორი რიცხვი ერთნაირია, მაშინ დააბრუნეთ გასამმაგებული მათი ჯამი.
			//შეყვანის ნიმუში:
			//1, 2
			//3, 2
			//2, 2
			//მოსალოდნელი შედეგი:
			//3
			//5
			//12



			//Console.WriteLine("enter first number");
			//int firstNum;
			//bool validFirst = int.TryParse(Console.ReadLine(), out firstNum);
			//Console.WriteLine("enter second number");
			//int secondNum;
			//bool validSecond= int.TryParse(Console.ReadLine(), out secondNum);


			//string result = validFirst && validSecond 
			//	? (firstNum == secondNum ? $"{(firstNum + secondNum)*3}" 
			//	: $"{firstNum + secondNum}" ) : "numbers are not valid";


			#endregion


			//if else 

			//if (პირობა / true false )
			//{
			//	რა შესრულდეს
			//}


			//nested if   ჩადგმული 


			//if (5 > 2)  // false
			//{
			//	if (5==5)
			//	{
			//		if (3==3)
			//		{

			//		}
			//	}
			//	else
			//	{

			//	}
			//	Console.WriteLine("true");

			//}
			//else if (5>3)
			//{
			//	Console.WriteLine("true 6");
			//}
			//else
			//{
			//	if (2==2)
			//	{
			//		Console.WriteLine("false");
			//	}
			//}



			//string userName = "user123";
			//string password = "pass123";
			//string passCode = "1234";



			//Console.Write("enter username");
			//string userNameInp = Console.ReadLine();

			//Console.Write("enter password");
			//string userPassInp = Console.ReadLine();

			//Console.Write("enter passcode");
			//string userPassCodeInp = Console.ReadLine();

			//&& 
			//& 

			//fale                                 //false
			//if (userName == userNameInp && (password == userPassInp || passCode == userPassCodeInp))
			//{
			//	Console.WriteLine("Welcome");
			//}
			//else
			//{
			//	Console.WriteLine("NOT Welcome");
			//}



			//if (userName != userNameInp)
			//{

			//	Console.WriteLine("NOT Welcome");
			//}
			//else if (password == userPassInp || passCode == userPassCodeInp)
			//{
			//	Console.WriteLine(" Welcome");
			//}
			//else
			//{
			//	Console.WriteLine("Not Welcome");
			//}



			//if(userName == userNameInp)
			//{
			//	if(password == userPassInp || passCode == userPassCodeInp)
			//	{
			//		Console.WriteLine(" Welcome");
			//	}
			//	else
			//	{
			//		Console.WriteLine("Not Welcome");
			//	}
			//}

			//else
			//{
			//	Console.WriteLine("Not Welcome");
			//}


			//userName უნდა ემთხვეოდეს და დამატებით ან პაროლი უნდა ემთხვეოდეს ან პასკოდი

			//Console.WriteLine("");

			//ctrl k d დაფორმატება


			int x = 10;


			//if (x == 5)
			//{
			//	Console.WriteLine("xutia");
			//}
			//else if(x== 6)
			//{
			//	Console.WriteLine("eqvsia");
			//}
			//else
			//{
			//	Console.WriteLine("not 5 6");
			//}


			

			switch (x)
			{
				case 5:
				case 8:
				case 9:
			
					Console.WriteLine("xutia, an rvaa an cxraa");
					break;

				case 10:

					Console.WriteLine("atia");
					goto case 5;

				case 6:
					Console.WriteLine("eqvsia");
					return;  ///   მეთოდს გაწყვიტავს  ამ შემთხვევაში მეინს

				default:
					Console.WriteLine("not 5 6");
					break;
			}




			Console.WriteLine("hello world");


		}
	}
}
