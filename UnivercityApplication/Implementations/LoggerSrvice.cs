using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using UnivercityApplication.Interfaces;

namespace UnivercityApplication.Implementations
{
	public  class LoggerSrvice  : IloggerService
	{
		string path = "C:\\Users\\l4nst\\Desktop\\doit2026\\BCTF4-20-LS-v1\\UnivercityCore\\Logs1\\logs.txt";


		//public void Log(string message)
		//{
		//	File.AppendAllText(path, message);
		//}


		public  void Log(string message)
		{
			string ip = GetUserIp();
			using (StreamWriter sw = new StreamWriter(path, true))
			{
				sw.WriteLine($"[{DateTime.Now} - IP {ip}]" + message);
			}
		}


		private string GetUserIp()
		{
			var host = Dns.GetHostEntry(Dns.GetHostName());

			foreach (var ip in host.AddressList)
			{
				if (ip.AddressFamily == AddressFamily.InterNetwork)
				{
					return ip.ToString();
				}
			}

			return string.Empty;
		}
	}
}
