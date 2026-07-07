using UnivercityApplication.Implementations;
using UnivercityCore.Interfaces;
using UnivercityRepository;

namespace UnivercityUI
{
	internal class Program
	{
		static void Main(string[] args)
		{


			IFlieManager repository = new FileRepository();

			StudentService studentService = new StudentService(repository);



			studentService.RegisterStudent("John Doe", "email123@gmail.com", "password123");


		}
	}
}
