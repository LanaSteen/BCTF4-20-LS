using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture16.Services
{
	internal class Logger : IDisposable
	{



		private const string path = @"../../../Data/log.txt";
		private readonly StreamWriter streamWriter;


		public Logger()
		{
			streamWriter =  new StreamWriter(path, true );
		}

		public void Log(string message)
		{

			streamWriter.Write(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
			streamWriter.Write(" - "); 
			streamWriter.Write(message);
			streamWriter.WriteLine();

			streamWriter.Flush();
		}


		public void Dispose()
		{
			Console.WriteLine("Disposed");
		}

	}
}



//File.ReadAllLines();   // disposable ar aris



//StreamReader streamReader; streamReader.ReadLine();