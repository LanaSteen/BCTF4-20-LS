using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture10
{
	internal class Player  : Sprite
	{


		public int Health { get; set; }

		public int Life { get; set; }	

		public int Points { get; set; }


		public override void Move(int x, int y)
		{
			X += x;
			Y += y;
			Console.WriteLine($"My location is X: {X}, Y: {Y}");
			
		}


		public override void Drow()
		{
			Console.WriteLine("I am player");
		}



	}
}




//ზოგადი    კონკრეტული 