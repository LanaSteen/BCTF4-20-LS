namespace Lecture11
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");

			#region hw
			//დავალება 1 შექმენით საბაზისო “Musical instrument”
			//კლასი და მისი წარმოებული(Derived)
			//კლასები: “Violin”, “Ukulele”, “Trombone”, “Cello”.
			//კონსტრუქტორის გამოყენებით განსაზღვრეთ თითოეული
			//მუსიკალური ინსტრუმენტის სახელწოდება და მისი(ტექსტურად
			//უნდა გამოვიდეს კონსოლში); თითოელი კლასისთვის გამოიყენეთ
			//შემდეგი მეთოდები:
			//Sound - გამოსცემს მუსიკალური ინსტრუმენტის
			//ხმას(ტექსტურად უნდა გამოვიდეს კონსოლში);
			//Show - აჩვენებს მუსიკალური ინსტურმენტის სახელწოდებას;
			//Desc - აჩვენებს მუსიკალური ინსტრუმენტის აღწერილობას;
			//History - აჩვენებს მუსკილაური ინსტრუმენტის შექმნის ისტორიას;



			//Violin violin = new Violin("Stradivarius", MusicalInstrumentType.String);
			//Ukulele ukulele = new Ukulele("Kala", MusicalInstrumentType.String);


			//Console.WriteLine(violin.ToString());
			//violin.Sound();




			//შექმენით საბაზისო აბსტრაქტული კლასი -Worker,
			//რომელსაც ექნება მეთოდი Print().შექმენით ოთხი
			//წარმოებული(Derived) კლასი: President, Security, Manager,
			//Engineer.გამოიყენეთ Print() მეთოდი, რათა
			//გამოიტანოთ ინფორმაცია,
			//რომელიც შეესაბამება თითოეული ტიპის მუშაკს.








			//Worker[] workers = new Worker[4];
			//workers[0] = new President("President Name", "President  Last Name", 50000);
			//workers[1] = new Security("Security Name", "Security  Last Name", 70000);
			//workers[2] = new Manager("Manager Name", "Manager  Last Name", 20000);
			//workers[3] = new Engineer("Engineer Name", "Engineer  Last Name", 80000);

			//foreach (Worker worker in workers) 
			//{
			//	Console.WriteLine(worker.ToString());
			//	worker.Print();
			//}

			#endregion


		     

		}
	}
}





//ზოგადი - აბსტრაქტული
