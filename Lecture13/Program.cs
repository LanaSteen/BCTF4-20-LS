using System.Reflection.PortableExecutable;

namespace Lecture13
{
	internal class Program
	{
		static void Main(string[] args)
		{

			try
			{

			  string path = @"../../../data.txt";

			  using	StreamReader reader = new StreamReader(path);  // გახსნის წაიკითხავს მაგრამ არ ხურავს  using ის გარეშე
			  Student[] students = new Student[0];
			   int index = 0;

				while (!reader.EndOfStream)
				{
					string line = reader.ReadLine();
					string[] data = line.Split(',');

					Student student = new Student();

					student.FirstName = data[0];
					student.LastName = data[1];
					student.Age = int.Parse(data[2]); // -100
					student.Email = data[3];
					student.Phone = data[4];
					student.Point = int.Parse(data[5]);


					Array.Resize(ref students, index + 1);
					students[index] = student;
					index++;



					//Console.WriteLine(line);

				}



				foreach (Student student in students) 
				{
					Console.WriteLine(student.ToString());
				}
				



				//reader.Close();
				//reader.Dispose();


				//string[] lines = File.ReadAllLines(path);   // გახსნის ფაილს წაიკითხავს ავტოატურად  დახურავს



				//Student[] students = new Student[lines.Length];


				//for (int i = 0; i < students.Length; i++)
				//{

				//	string[] data = lines[i].Split(',');

				//	students[i] = new Student();

				//	students[i].FirstName = data[0];
				//	students[i].LastName = data[1];
				//	students[i].Age = int.Parse(data[2]); // -100
				//	students[i].Email = data[3];
				//	students[i].Phone = data[4];
				//	students[i].Point = int.Parse(data[5]);

				//}

			}
			catch (FileNotFoundException ex)
			{
				Console.WriteLine(ex.Message);
				Console.WriteLine("File was not found on destionation path");
			}
			catch (FormatException ex)
			{
				Console.WriteLine(ex.Message);
				Console.WriteLine("Age or Point is not number");
			}
			catch (IndexOutOfRangeException ex)
			{
				Console.WriteLine(ex.Message);
				Console.WriteLine("one of line does not have enough data");
			}
			catch (InvalidAgeException ex)
			{
				Console.WriteLine("Age is not valid");
				Console.WriteLine(ex.Message);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				Console.WriteLine("unknown error");
			}
			finally
			{
		
				Console.WriteLine("File reading is done");  // ყველა შემთხვევაში იმუშვებს
			}



			Console.WriteLine("hello");




			//Array.Sort(students);

			//foreach (var student in students)
			//{
			//	Console.WriteLine(student);
			//}

			//Console.WriteLine($"minimal point is {students[0].Point}");

			//Student oldest = students[0];
			//foreach (var student in students)
			//{
			//	if(student > oldest) oldest = student;
			//}

			//Console.WriteLine($"oldest student {oldest} ");




			//int sum = 0;
			//foreach (var item in students)
			//{
			//	sum+= item;
			//}

			//int sum = 0;
			//foreach (var student in students)
			//{
			//	sum += student;
			//}


			//int point = 90;

			//Student stud = new Student();
			//stud = (Student)point;

			//Console.WriteLine($"average point is {(double)sum/students.Length}");

		}
	}
}
