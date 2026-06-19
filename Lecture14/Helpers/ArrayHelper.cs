using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture14.Helpers
{
	internal class ArrayHelper
	{

		public static T[] Add<T>(ref T[] inventorylist, T newinventory)
		{
			int index = inventorylist.Length;

			Array.Resize(ref inventorylist, index + 1);

			inventorylist[index] = newinventory;

			return inventorylist;
		}
	}
}
