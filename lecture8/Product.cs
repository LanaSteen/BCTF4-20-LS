

//oop   

//ინკაფსულაცია
//მემკვიდრეობა 
//პოლიმორფიზმი



//const   

namespace lecture8
{
	public class Product
	{

		private int _id;  // 50
		public int Id

		{
			get
			{
				return _id;  // 50
			}
			set
			{
				if (value > 0)
				{
					_id = value;
				}

			}
		}  // full property  


		//propfull 
		//prop

		//public required int MyProperty { get; set; }



		public const int MinQuantity = 1;  // const  მუდმივა
										   
		//public readonly DateTime CreatedAt = DateTime.Now;  // readonly  მხოლოდ კონსტრუქტორში შეიძლება მნიშვნელობის მინიჭება
		public readonly DateTime CreatedAt;  // readonly  მხოლოდ კონსტრუქტორში შეიძლება მნიშვნელობის მინიჭება


		public Product()
		{
			
		}

		public Product(DateTime createdAt)
		{
			CreatedAt = createdAt;
		}

		public string Name { get; init; }   // set init 

		public string Description { get; set; }
		public decimal Price { get; set; }
		public int Quantity { get; set; }

		public string Category { get; set; }

		public float Rating { get; set; }


		public bool IsAvelable { get; set; }

	
		public void DisplayInfo()
		{
			Console.WriteLine($"Id: {_id} Name: {Name} Description: {Description} Price: {Price} Quantity: {Quantity} Caption: {Category} Rating: {Rating} Is Available: {IsAvelable}");

		}


		public void AddStock(int amount)
		{

			Console.WriteLine("Adding stock..");
			Quantity += amount;
			Console.WriteLine("stock is.." + Quantity);
		}



		public decimal Sale(decimal discount)
		{
			return Price - Price * discount / 100;
		}





	}
}
