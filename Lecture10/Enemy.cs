using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Lecture10
{
	internal class Enemy  : Sprite , IShooter,  IComparable<Enemy> 
	{

		public int Health { get; set; }
		public int Demage { get; set; } //  5 2  1


		public override void Move(int x, int y)
		{
			X += x;
		
		}


		public override void Drow()
		{
			Console.WriteLine("I am enemy");
		}

		public void Shoot()
		{
			Console.WriteLine("I am shooting");
		}

		public int CompareTo(Enemy? other)
		{
			return Demage.CompareTo(other.Demage);
		}
	}
}
