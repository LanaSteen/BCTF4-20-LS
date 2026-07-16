using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture22
{
	internal class UserService
	{

		private List<User> users = new List<User>()
		{
		 new User {Id = 1, Name = "Lars"},
		 new User {Id = 2, Name = "Rasmus"}

		};


		public async Task<List<User>> GetAllUsers()
		{
			return users;
		}
		public async Task<User> GetUserById(int id)
		{
			return users.Find(x => x.Id == id);
		}
		public async Task AddUser(User user)
		{
			users.Add(user);
		}

	}
}
