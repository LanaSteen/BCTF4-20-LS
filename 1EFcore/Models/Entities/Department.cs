using System;
using System.Collections.Generic;
using System.Text;

namespace _1EFcore.Models.Entities
{
	internal class Department
	{
		public int Id { get; set; }
		public string Name { get; set; }
        public List<Student> Students { get; set; }

	}
}
