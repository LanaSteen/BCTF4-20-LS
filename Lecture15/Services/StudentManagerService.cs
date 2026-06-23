using Lecture15.Enums;
using Lecture15.Helpers;
using Lecture15.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture15.Services
{
	internal class StudentManagerService
	{

		public StudentManagerService()
		{
			FillData();
		
		}




		public Student[] students = new Student[0];



	    private void FillData()
		{
			ArrayHelper.Add(ref students, new Student("John", "Doe", 20, "john.doe@example.com", "599595959", 4.5, Faculty.IT));
			ArrayHelper.Add(ref students, new Student("John", "Doe", 25, "john.doe@example.com", "599595959", 5, Faculty.IT));
			ArrayHelper.Add(ref students, new Student("John", "Doe", 30, "john.doe@example.com", "599595959", 3, Faculty.IT));
		}




		public void PrintAllStudents()
		{
			foreach (var student in students)
			{
				student.Print();
			}
		}



	}
}
