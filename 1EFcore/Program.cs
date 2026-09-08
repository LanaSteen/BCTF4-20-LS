using _1EFcore.Data;
using _1EFcore.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace _1EFcore
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//code first


			var context = new UniDbContext();
			context.Database.EnsureCreated(); // მიგრაციებით ჩავანაცვლებთ



			//var newCourse = new Course { Title = "Mathematics" };
			//var newStudent = new Student
			//{
			//	FirstName = "George",
			//	LastName = "Smith",
			//	Email = "4dsd@dfdf",
			//	Phone = "49595959595",
			//	Age = 25,
			//	GPA = 2.9m,
			//	Courses = new List<Course> { newCourse }

			//};

			//context.Courses.Add(newCourse);
			//context.Students.Add(newStudent);
			//context.SaveChanges();





			//var existingStudent = context.Students.FirstOrDefault(c => c.Id ==1);

			//if(existingStudent != null)
			//{
			//	existingStudent.GPA = 2.0m;
			//	//existingStudent.Courses.Add(newCourse);
			//	context.SaveChanges();
			//}


			//var studentToDelete = context.Students.FirstOrDefault(c => c.Id == 2);

			//if (studentToDelete != null)
			//{
			//	context.Students.Remove(studentToDelete);
			//	context.SaveChanges();
			//}



			//var studentsAll = context.Students
			//	.Include(s => s.Courses)
			//	.ToList();
			//foreach (var item in studentsAll)
			//{
			//	Console.Write($"{item.Id} {item.FirstName} {item.LastName} {item.Email} {item.Age} " );
			//	foreach (var course in item.Courses)
			//	{
			//		Console.Write($"{course.Title} ");
			//	}
			//	Console.WriteLine();
			//}


		}
	}
}
