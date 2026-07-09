using System.Net;
using System.Net.Sockets;
using UnivercityApplication.Implementations;
using UnivercityCore.Interfaces;
using UnivercityCore.Models;
using UnivercityRepository;

namespace UnivercityUI
{
	internal class Program
	{
		static void Main(string[] args)
		{


			IFlieManager repository = new FileRepository();
			EmailService emailService = new EmailService();

			StudentService studentService = new StudentService(repository, emailService);

			LoggerSrvice ls = new LoggerSrvice();


			//studentService.RegisterStudent("Anna Smith", "steenlana492@gmail.com", "password123");

			//studentService.VerifyStudent("steenlana492@gmail.com", "9859");

			//Student authStudent = studentService.LoginStudent("steenlana492@gmail.com", "password123");
			//Console.WriteLine(authStudent.Username);

			////4465


			Student lastLoggedInStudent = repository.GetLastLoggedInStudent();
			Console.WriteLine(lastLoggedInStudent.Username + " LAst Logged In");


			Console.WriteLine(lastLoggedInStudent.Username + " LAst Logged In and its Ip is" );

			//studentService.LogoutStudent("steenlana492@gmail.com");


			ls.Log($" user Registered ");


		}





	}
}

