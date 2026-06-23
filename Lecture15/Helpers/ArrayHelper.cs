using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture15.Helpers
{
	internal class ArrayHelper
	{
		public static void Add<T>(ref T[] arraylist, T newitem)
		{
			int index = arraylist.Length;

			Array.Resize(ref arraylist, index + 1);

			arraylist[index] = newitem;

			//return arraylist;
		}
	}
}
