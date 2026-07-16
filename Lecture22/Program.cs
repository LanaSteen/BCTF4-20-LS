using System.ComponentModel.Design;
using System.Diagnostics.Metrics;

namespace Lecture22
{
	internal class Program
	{
		static async Task Main(string[] args)
		{

			#region Thread


			//Thread.CurrentThread.Name = "Main";
			//Console.WriteLine($"Thread Name: {Thread.CurrentThread.Name} {Thread.CurrentThread.ManagedThreadId}");
			////Thread.Sleep(1000);

			//Thread secondThread = new Thread(() => 
			//{
			//	for (int i = 0; i < 5; i++) 
			//	{
			//		Console.WriteLine($"{i} Thread Name: {Thread.CurrentThread.Name} {Thread.CurrentThread.ManagedThreadId}");
			//		Thread.Sleep(1000);
			//	}

			//});

			//Thread thirtyThread = new Thread(ThirdThread);


			//secondThread.Start();
			//thirtyThread.Start();
			//secondThread.Join();
			//thirtyThread.Join();


			//Console.WriteLine("Main thread finished");

			//bool running = true;
			//int count1 = 0;
			//int count2 = 0;

			//Thread first = new Thread(() => 
			//{
			//	while (running)
			//	{
			//		count1++;
			//	}

			//});
			//first.Priority = ThreadPriority.Highest;


			//Thread second = new Thread(() => 
			//{
			//	while (running) 
			//	{
			//		count2++;
			//	}
			//});
			//second.Priority = ThreadPriority.Lowest;


			//first.Start();
			//second.Start();

			//Thread.Sleep(1000);

			//running = false;

			//first.Join();
			//second.Join();


			//Console.WriteLine($"Count1: {count1} Count2: {count2}");
			//Console.WriteLine($"{count1 / count2} jer meti");







			// ორი სრედი შექმენით და პირველმა რიცხვები ჩამოწეროს 0 დან 10 მდე
			// და მეორემ 10 დან 0 მდე პარალელურად ერთნაირი პრიორიტეტით


			//int count1 = 0;
			//int count2 = 10;

			//Thread countUp = new Thread(() => {
			//	while (count1 <= 10)
			//	{
			//		Console.WriteLine($"Count1: {count1}");
			//		count1++;
			//		Thread.Sleep(100);
			//	}

			//});
			//Thread countDown = new Thread(() => {
			//	while (count2 >=0)
			//	{
			//		Console.WriteLine($"Count1: {count2}");
			//		count2--;
			//		Thread.Sleep(100);
			//	}

			//});

			//countUp.Start();
			//countDown.Start();

			//countUp.Join();
			//countDown.Join();

			//countUp.Abort();  // აჩერებს სრედს აღარ გამოიყენება



			//CancellationTokenSource cts = new CancellationTokenSource();

			//Thread thread = new Thread(() => 
			//{
			//	while (!cts.Token.IsCancellationRequested) 
			//	{
			//		Console.WriteLine("Working..");
			//		Thread.Sleep(500);
			//	}

			//});
			//thread.Start();

			//Thread.Sleep(5000);
			//cts.Cancel();

			//thread.Join();
			//Console.WriteLine("finished");



			#endregion



			//Task
			//Console.WriteLine("main started");

			//await Task.Delay(1000);

			//Console.WriteLine("main finished");


			UserService userService = new UserService();

			List<User> users  = await userService.GetAllUsers();

			foreach (var item in users)
			{
				Console.WriteLine(item.Name);
			}


			User user = await userService.GetUserById(1);
			Console.WriteLine(user.Name);


			await userService.AddUser(new User { Name = "Luka" });





		}



		//static void ThirdThread()
		//{
		//	Thread.Sleep(1000);
		//	Thread.CurrentThread.Name = "Third";
		//	Console.WriteLine($"Thread Name: {Thread.CurrentThread.Name} {Thread.CurrentThread.ManagedThreadId}");
		//}
	}
}
