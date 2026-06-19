using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture14.Models
{
	internal class Enemy
	{
		public string Name { get; set; }

		public Weapon[] Weapon; // { get; set; }



		//public static Weapon[] Add(ref Weapon[] weaponlist, Weapon newWeapon)
		//{
		//	int index = weaponlist.Length;

		//	Array.Resize(ref weaponlist, index + 1);

		//	weaponlist[index] = newWeapon;

		//	return weaponlist;


		//}
	}


	public class Weapon
	{
		public string Name { get; set; }
		public int Damage { get; set; }
	}
}
