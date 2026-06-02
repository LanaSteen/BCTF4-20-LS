using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture9
{
	internal class Student : Human
	{

		//public string Name { get; set; }
		//public string LastName { get; set; }

		//public byte Age { get; set; }

		public byte Grade { get; set; }

		public float GPA { get; set; }
		public bool IsActtiveStudent { get; set; }

		string[] Subjects { get; set; }

		Lesson[] Lessons { get; set; }


	}
}
