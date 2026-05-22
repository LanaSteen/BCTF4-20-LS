using System.Security.Cryptography;
using System.Text;

namespace lecture6
{
	internal class Program
	{
		static void Main(string[] args)
		{


			#region hw

			//Version 1
			//int[] arr = [20,10,50];

			//int[] arr2 = arr;   // [20,10,50]; 


			//if(arr == arr2)  // false

			//arr[0] = 100;

			//Console.WriteLine(arr.Length);

			//Console.WriteLine(arr[arr.Length-1]);


			//int[] arr1 = [1,2,3];

			//int[] arr2 = [4, 5, 6];

			//int[] resultArr = new int[arr1.Length + arr2.Length];  // 6


			//int x = 0;

			//for (int i = 0; i < arr1.Length; i++) {

			//	resultArr[x] = arr1[i];
			//	x++;
			//}
			//for (int i = 0; i < arr2.Length; i++)
			//{
			//	resultArr[x] = arr2[i];
			//	x++;
			//}



			//version2

			//int[] arr1 = [1, 2, 3];

			//int[] arr2 = [4, 5, 6];

			//int[] resultArr = new int[arr1.Length + arr2.Length];  // 6



			//for (int i = 0; i < arr1.Length; i++)
			//{

			//	resultArr[i] = arr1[i]; //   [1, 2, 3, 0 , 0, 0]

			//}
			//for (int i = 0; i < arr2.Length; i++)
			//{
			//	resultArr[i+ arr1.Length] = arr2[i];

			//}




			//version3

			//int[] arr1 = [1, 2, 3];

			//int[] arr2 = [4, 5, 6];

			//int[] resultArr = new int[arr1.Length + arr2.Length];  // 6




			//for (int i = 0; i < resultArr.Length; i++)
			//{

			//	if(arr1.Length > i)
			//	{
			//		resultArr[i] = arr1[i];
			//	}
			//	else
			//	{
			//		resultArr[i] = arr2[i-arr1.Length];
			//	}

			//}





			//int[] numbers = [3, 5, -4, 8, 11, 1, -1, 6];
			//int targetSum = 7;

			//int count = 0;

			//for (int i = 0; i<numbers.Length; i++)
			//{

			//	for(int j = i+1; j < numbers.Length; j++)
			//	{
			//		if(numbers[j] +numbers[i] == targetSum)
			//		{
			//			count++;
			//		}

			//	}
			//}


			//if (count ==0)
			//{
			//	Console.WriteLine("tehre is no couple");
			//}
			//else
			//{

			//	int[,] resultArray = new int[count, 2];
			//	int index = 0;

			//	for (int i = 0; i < numbers.Length; i++)
			//	{

			//		for (int j = i + 1; j < numbers.Length; j++)
			//		{
			//			if (numbers[j] + numbers[i] == targetSum)
			//			{
			//				resultArray[index, 0] = numbers[i];
			//				resultArray[index, 1] = numbers[j];
			//				index++;
			//			}

			//		}
			//	}
			//	//for (int i = 0; i < count; i++)
			//	//{
			//	//	Console.WriteLine(resultArray[i, 0] + " " + resultArray[i, 1]);
			//	//}


			//	for (int i = 0; i < resultArray.GetLength(0); i++)
			//	{
			//		Console.WriteLine(resultArray[i, 0] + " " + resultArray[i, 1]);
			//	}

			//}




			#endregion


			//2D    


			//int[,] arr2D = { 
			//		{ 1, 2 },   // 0
			//		{ 4, 5 },  // 1
			//		{ 7, 8  }
			//	};



			//Console.WriteLine(arr2D[0, 0]);  // 1 row   1
			//Console.WriteLine(arr2D[0, 1]);  // 2



			//Console.WriteLine(arr2D[1, 0]);  // 1 row   4
			//Console.WriteLine(arr2D[1, 1]);  // 5


			////jagged array

			//int[][] jagged = [
			//	[20, 20, 30, 80],
			//	[20,60,30],  // 1
			//	[50,60 ]  //2 

			//	];

			//Console.WriteLine(jagged[0][0]);

			//Console.WriteLine(jagged[1][1]);  // 60
			//Console.WriteLine(jagged[2][1]); // 60


			//int[][] jagged2 = new int[6][];



			//int sum = 0;

			//for (int i = 0; i < jagged.Length; i++)
			//{

			//	int rouwSum = 0;   //	[50,60 ],


			//	for (int j = 0; j < jagged[i].Length; j++)
			//	{

			//		Console.WriteLine(jagged[i][j]);   
			//		sum+= jagged[i][j];

			//		rouwSum += jagged[i][j];

			//	}
			//	Console.WriteLine(rouwSum);
			//}

			//Console.WriteLine(sum);




			//Array 

			//int[] nums = [1, 50, 30, 78, 30, 30];

			//Console.WriteLine(Array.IndexOf(nums, 30));  // 2

			//Console.WriteLine(Array.LastIndexOf(nums, 30));  //


			//for (int i = 0; i < nums.Length; i++) {

			//	if(nums[i] == 30 && i != Array.LastIndexOf(nums, 30) )
			//	{
			//		Console.WriteLine(i);
			//	}
			//  }


			//Console.WriteLine(nums.ToString());   


			//int[] nums = [1, 50, 30, 78, 30, 30];  // 6






			//Array.Resize(ref nums, nums.Length+1);

			//nums[6] = 100;






			//string text = "text";

			//string text2 = "text";


			// == 
			// + 

			//if(text2 == text)  // true



			//string text = "text";


			//Console.WriteLine(text[0]);   // t
			//Console.WriteLine(text[1]); // e

			//for (int i = 0; i < text.Length; i++)
			//{
			//	Console.WriteLine(text[i]);
			//}



			////level    ai ia   step on no pets   ekitike



			//char[] symbols = text.ToCharArray();

			//char[] reversedsymbols = text.ToCharArray().Reverse().ToArray();


			//bool isPalindrome = true;


			//for(int i =0; i<symbols.Length; i++)
			//{
			//	if (symbols[i] != reversedsymbols[i])
			//	{
			//		isPalindrome = false;
			//	}
			//}

			//Console.WriteLine(isPalindrome);



			//[2,3] == [2,3]  





			string text = "    Hello world    ";


			Console.WriteLine(text.Substring(5));

			Console.WriteLine(text.Substring(6,2));



			Console.WriteLine(text.Contains("@"));

			Console.WriteLine(text.IndexOf("H"));  // 0  თუ ვერ მოიძებნა -1 

			Console.WriteLine(text.ToUpper());     // HELLO WOLRD

			Console.WriteLine(text.ToLower());     // HELLO WOLRD


			Console.WriteLine(text.Trim());


			text.Replace("H", "h");


			//"john"

			string name = "john";

			name.Replace(name[0], name[0].ToString().ToUpper()[0]);





			////csv txt        name,lastname,age 
			//                 John,Doe,20
			//	               Jane,Doe,25

			//string text5 = "John, Doe, 20";

			//string[] info = text5.Split(",");

			//Console.WriteLine(info[0]);



			name = "Jane";
		 

			StringBuilder sb = new StringBuilder("saxeli");
			Console.WriteLine(sb);
			

			sb.Replace("s", "x");
			Console.WriteLine(sb);

			string rame = sb.ToString();


			//Random r = new Random();



		















		}
	}
}
