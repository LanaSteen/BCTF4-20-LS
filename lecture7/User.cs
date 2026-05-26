using System;
using System.Collections.Generic;
using System.Text;

namespace lecture7
{
	internal class User
	{
		public User(string userName, string email)
		{
			this.UserName = userName;
			this.Email = email;
		}

		//public string UserName;
		//public string Email;

		public string UserName { get; set; }
		public string Email { get; set; }


	  public void DisplayInfo()
		{
			Console.WriteLine($"name : {UserName} - email :  {Email}");
		}

	
	}
}


//this დარეზერვებული სიტყვა 