using System;
using System.Collections.Generic;
using System.Text;

namespace UnivercityApplication.Interfaces
{
	internal interface IEmailservice
	{
		void SeedEmail(string to, string subject, string body);
	}
}
