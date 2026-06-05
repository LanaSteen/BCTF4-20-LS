using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture10
{
	internal class Enemy  : Sprite
	{

		public int Health { get; set; }
		public int Demage { get; set; }


		public override void Move(int x, int y)
		{
			X += x;
		
		}


		public override void Drow()
		{
			Console.WriteLine("I am enemy");
		}

	}
}
