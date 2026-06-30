using Lecture17.Helper;

namespace Lecture17
{
	internal class Program
	{
		static void Main(string[] args)
		{
			

			List<int> ints = new List<int>() {50,15,60,30 };
			//  15 50 30 60 

			//> 40

			//Console.WriteLine(Algorithms.FindElement(ints, 50));  // 50

			//Console.WriteLine(Algorithms.CustomFirstOrDefault(ints, delegate (int z) { return z > 40; }  )	); // 50




			List<int> evens = Algorithms.CustomWhere(ints, x => x % 2 == 0).ToList();

			// ლუწებიდან 

			evens.CustomLastOrDefault(x => x > 40);

			int greaterthen40 = Algorithms.CustomFirstOrDefault(evens, x => x > 40);



			var odds = from n in ints					   where n % 2 != 0 
					   select n;


			var greaterThen40 = ints.Where(x => x > 40).OrderBy(x=>x);
			foreach (var item in greaterThen40)
			{
				Console.WriteLine(item);
			}

		}
	}
}
