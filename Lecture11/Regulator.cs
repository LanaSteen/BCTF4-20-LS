using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture11
{
	internal interface IRegulator 
	{
	

		public string RegulationTopic  { get; set; }

		void Regulate();  // public  abstract

		public void Regulate2() 
		{
			Console.WriteLine("Regulate2");
		}

	}
}



