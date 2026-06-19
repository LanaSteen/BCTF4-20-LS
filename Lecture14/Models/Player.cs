using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture14.Models
{
	internal class Player
	{

		public string Name { get; set; }

		public Inventory[] Inventory;   //{ get; set; }


		//public static Inventory[] Add(ref Inventory[] inventorylist, Inventory newinventory)
		//{
		//	int index = inventorylist.Length;

		//	Array.Resize(ref inventorylist, index + 1);

		//	inventorylist[index] = newinventory;

		//	return inventorylist;
		//}

	}

	public class Inventory
	{
		public string Name { get; set; }
		public string Description { get; set; }
	}


}
