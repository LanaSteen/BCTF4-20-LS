using System;
using System.Collections.Generic;
using System.Text;

// this sxtension methods


namespace Lecture17.Helper
{
	internal static class Algorithms
	{
		public static T FindElement<T>(this IEnumerable<T> collection, T element)
		{
			foreach (var item in collection)
			{
				if (item.Equals(element)) // true
				{
					return item;
				}
			}
			return default;
		}




		public static T CustomFirstOrDefault<T>(this IEnumerable<T> collection, Predicate<T> predicate)
		{
			foreach (var item in collection)
			{
				if (predicate(item)) // true  // x=> x>40
				{
					return item;
				}
			}
			return default;
		}

		public static T CustomLastOrDefault<T>(this IEnumerable<T> collection, Func<T, bool> func)
		{

			T last = default;

			foreach (var item in collection)
			{
				if (func(item)) // true
				{
					last = item;
				}
			}
			return last;
		}



		public static IEnumerable<T> CustomWhere<T>(this IEnumerable<T> collection, Func<T, bool> func = null)
		{
			if(collection == null)
			{
				throw new ArgumentNullException(nameof(collection) + " is null");
			}

			if (func == null)
			{
				throw new ArgumentNullException(nameof(func) + " is null");
			}

			foreach (var item in collection)
			{

				if (func(item))
				{
					yield return item;
				}
				
			}
		}


		//OrderBy ალაგებს ელემენტებს ზრდადობით(Ascending).


		public static IEnumerable<T> CustomOrderBy<T>(this IEnumerable<T> collection)
		{
			List<T> list = new List<T>(collection);

			int count = list.Count();

			for (int i = 0; i < count-1; i++)
			{
				for (int j = 0; j < count-1-i; j++)
				{
					T temp = list[j];
					list[j] = list[j+1];
					list[j+1] = temp;
				}

			}

			return list;
		}



		//Where ფილტრავს კოლექციას და აბრუნებს მხოლოდ იმ ელემენტებს, რომლებიც მოცემულ პირობას აკმაყოფილებენ.


		//First აბრუნებს პირველ ელემენტს.თუ ელემენტი არ არსებობს, აგდებს Exception-ს.
		public static T CustomFirst<T>(this IEnumerable<T> collection, Predicate<T> predicate)
		{
			foreach (var item in collection)
			{
				if (predicate(item)) // true  // x=> x>40
				{
					return item;
				}
			}
			throw new InvalidOperationException();
		}




		public static IEnumerable<T> CustomDistinct<T>(this IEnumerable<T> collection)
		{
			collection.ToHashSet();
			return collection;

		}

		//2 2  2 3 3 1
		//2 3 1




	}
}
