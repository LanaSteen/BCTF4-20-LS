using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;
using UnivercityApplication.Interfaces;

namespace UnivercityApplication.Implementations
{
	public class EmailService : IEmailservice
	{

		public void SeedEmail(string to, string subject, string body) 
		{
		
			 SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
			 smtpClient.UseDefaultCredentials = false;
			 smtpClient.Credentials = new NetworkCredential("stepacc210@gmail.com", "puos ljow yrdh awpl");
			 smtpClient.EnableSsl = true;


			 MailMessage mailMessage = new MailMessage("stepacc210@gmail.com", to, subject, body);


			 smtpClient.Send(mailMessage);



		}
	}
}


//Smtp  - simple mail transfer protocol პროტოკოლი

//http  - პროტოკოლი   - https ssl 
//ftp - პროტოკოლი

//sendgrid 