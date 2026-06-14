using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture12
{
	internal class ArrayClass : IOutput2, ICalc2

	{




		private int[] _numbers;

		public int[] Numbers
		{
			get { return _numbers; }
			set 
			{ 
				if(value.Length > 0 && value != null)
				{
					_numbers = value;
				}
				else
				{
					Console.WriteLine("Invalid array");
					return;
				}
			}
		}


		public ArrayClass(int[] numbers)
		{
			_numbers = numbers;
		}


		public void ShowEven()
		{
			Console.WriteLine("Even numbers: ");
			foreach (var item in _numbers)
			{
				if (item%2 ==0)
				{
					Console.Write(item  + "," );
			
				}
			}

			Console.WriteLine();
		}

		public void ShowOdd()
		{
			Console.WriteLine("Even odd: ");
			foreach (var item in _numbers)
			{
				if (item % 2 != 0)
				{
					Console.Write(item + ",");
				
				}
			}
			Console.WriteLine();
		}

		/*public int CountDistinct()
		{
		     //[50, 17, 60, 30, 15]
			int count = 0;
			for (int i = 0; i < Numbers.Length; i++)
			{
				bool isDistinct = true; //  dublicates

				for(int j = i+1; j < Numbers.Length; j++)
				{
					if (Numbers[i] == Numbers[j])
					{
						isDistinct = false;
						break;
					}
				}

				if (isDistinct)
				{
					count++;
				}

			}

			return count;
		}

*/
		public int CountDistinct()
		{
			//[50, 17, 60, 30, 15]
			int count = 0;
			for (int i = 0; i < Numbers.Length; i++)
			{
				bool isDublicate = false; //  dublicates

				for (int j = i + 1; j < Numbers.Length; j++)
				{
					if (Numbers[i] == Numbers[j])
					{
						isDublicate = true;
						break;
					}
				}

				if (!isDublicate)
				{
					count++;
				}

			}

			return count;
		}

		public int EqualToValue(int valueToCompare)
		{
			int count = 0;
			foreach (var item in _numbers)
			{

				if(item == valueToCompare)
				{
					count++;
				}
			}

			return count;
		}
	}
}
