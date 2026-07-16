namespace recursion
{
	internal class Program
	{
		static void Main(string[] args)
		{

			//print();

			Console.WriteLine(Poewerer(5, 3));
			//Factorial(5); // 120
			Console.WriteLine(Factorial(5) );
		}


		static int Poewerer(int num, int pow)
		{

			if(pow == 1)
			{
				return num;
			}
			return num * Poewerer(num, pow - 1);
		}


		//2 3
		//2 * (2 2)
        //  2 * (2 1)


		//5! = 5 * 4 * 3 * 2 * 1 = 120

		static int Factorial(int num)
		{
			if (num == 1)
			{
					return 1;
			}
			return num * Factorial(num-1);
		}




		//static void print()
		//{
		//	Console.WriteLine("Hello World!");
		//	print();
		//}
	}
}
