using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture13
{
	internal class InvalidAgeException : Exception
	{
		public InvalidAgeException(string? message) : base(message)
		{
		}
		public InvalidAgeException() : base("Age is not valid")
		{
		}
	}






}
