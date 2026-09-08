using _1EFcore.Data;

namespace _1EFcore
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//code first


			var context = new UniDbContext();
			context.Database.EnsureCreated(); // მიგრაციებით ჩავანაცვლებთ
		}
	}
}
