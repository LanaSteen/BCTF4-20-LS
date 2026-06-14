namespace Lecture12
{
	internal class Program
	{
		static void Main(string[] args)
		{

			#region hw
			//			შექმენით IOutput2 ინტერფეისი.ის უნდა შეიცავდეს ორ მეთოდს:
			//void ShowEven() -აჩვენებს ლუწ მნიშვნელობებს მონაცემთა კონტეინერიდან;
			//			void ShowOdd() -აჩვენებს კენტ მნიშვნელობებს მონაცემთა კონტეინერიდან;
			//			კლასმა “Array”-მ, იმპლემენტირება უნდა გაუკეთოს IOutput2 ინტერფეისს.
			//ShowEven მეთოდი ნებისმიერი მასივიდან ლუწ მნიშვნელობებს აჩვენებს.
			//ShowOdd მეთოდი ნებისმერი მასივიდან კენტ მნიშვნელობებს აჩვენებს.
			//დაწერეთ კოდი მიღებული ფუნქციონალის ტესტირებისათვის.


			//ArrayClass ac = new ArrayClass([50,17,50,60, 60,30,15, 70]) ;

			//ac.ShowEven();
			//ac.ShowOdd();



			//Console.WriteLine(ac.CountDistinct());
			//Console.WriteLine(ac.EqualToValue(50));

			//			შექმენით ICalc2 ინტერფეისი.ის უნდა შეიცავდეს ორ მეთოდს:
			//int CountDistinct() -აბრუნებს კონტეინერში არსებული უნიკალური მნიშვნელობების რაოდენობას.
			//int EqualToValue(int valueToCompare) -აბრუნებს მნიშვნელობების რაოდენეობას, რომელიც ტოლია valueToCompare-ისა.
			//კლასმა “Array”-მ, იმპლემენტირება უნდა გაუკეთოს ICalc2 ინტერფეისს.
			//CountDistinct მეთოდი აბრუნებს მასივში არსებული უნიკალური მნიშვნელობების რაოდენობას.
			//EqualToValue მეთოდი აბრუნებს მასივში არსებული მნიშვნელობების რაოდენობებს, რომელიც ტოლია ‘valueToCompare’-ისა.
			//დაწერეთ კოდი მიღებული ფუნქციონალის ტესტირებისათვის.

			#endregion


			//+ - * /  == != < >   ++ --
			Console.WriteLine("hello" + " " + "rame");



			Money money = new Money();
			money.Val = 50;
			money.Currency = "EUR";

			Money money2 = new Money();
			money2.Val = 40;
			money2.Currency = "EUR";

			Console.WriteLine(money + money2);
			Console.WriteLine(money - money2);

			Console.WriteLine(money == money2);
			Console.WriteLine(money != money2);
			Console.WriteLine(money > money2);



		}
	}
}
