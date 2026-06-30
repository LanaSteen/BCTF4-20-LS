using System;
using System.Collections.Generic;
using System.Text;



//delegate


// Func  -  <T1, T2>  -  ბოლო დასაბრუნებელი ტიპი  <T1,bool>
// Action  -  void
// Predicate <T1, bool>  - დასაბრუნებელი ტიპი აარის bool



namespace Lecture16.Helpers
{
	internal class Algorithms
	{


		//იპოვის გადაცემულ ელემენტს კოლექციაში


		//public static T FindElemtn<T>(T[] arr, T item)
		//{
		//	for (int i = 0; i < arr.Length; i++)
		//	{
		//		if (arr[i].Equals(item))
		//		{
		//			 return arr[i];
		//		}
		//	}

		//	[
		//	return default;
		//}


		//public static T FindElemtn<T>(List<T> list, T item)
		//{
		//	for (int i = 0; i < list.Count; i++)
		//	{
		//		if (list[i].Equals(item))
		//		{
		//			return list[i];
		//		}
		//	}

		//	return default;
		//}


		//public static T1 FindElemtn<T, T1>(Dictionary<T,T1> dict, T1 item)
		//{

		//	foreach (var item1 in dict.Keys)
		//	{
		//		if (dict[item1].Equals(item))
		//		{
		//			return dict[item1];
		//		}
		//	}

		//	return default;
		//}


		//public static T FindElemtn<T>(IEnumerable<T> collection, T item)
		//{

		//	foreach (var item1 in collection)
		//	{
		//		if (item1.Equals(item))
		//		{
		//			return item1;
		//		}
		//	}

		//	return default;
		//}




		//იპოვის გადაცემულ ლოგიკაზე დაყრდნოით ელემენტს კოლექციაში

		//>50

		public static T FindFirstElementByLogic<T>(IEnumerable<T> collection, Predicate<T> predicate)
		{
			foreach (var item in collection)
			{
				if (predicate(item)) // true
				{
					return item;
				}
			}
			return default;
		}

		//public static T FindLastElementByLogic<T>(IEnumerable<T> collection, Func<T, bool> func)
		//{

		//	T last = default;

		//	foreach (var item in collection)
		//	{
		//		if (func(item)) // true
		//		{
		//			last = item;
		//		}
		//	}
		//	return last;
		//}


		//public static T FindLastElementByLogic<T>(IEnumerable<T> collection, Func<T, bool> func)
		//{

		//	foreach (var item in collection.Reverse())
		//	{
		//		if (func(item)) // true
		//		{
		//			return item;
		//		}
		//	}
		//	return default;
		//}

	}
}
