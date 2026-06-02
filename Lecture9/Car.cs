namespace Lecture9
{
	internal class Car
	{
		private string _brand;
		private string _model;
		private int _year;
		private decimal _price;
		private Color _color;

		public Car(string brand, string model, int year, decimal price, Color color)
		{
			Brand = brand;
			Model = model;
			Year = year;
			Price = price;
			Color = color;
		}
		public Car()
		{
			
		}


		//Toyota,Corolla,2022,25000,White

		//full property 
		//get set 

		public string? Brand  // "" "    "  "   Corola" 
		{
			get { return _brand; }
			set 
			{
				if (string.IsNullOrWhiteSpace(value))
				{
					Console.WriteLine("Brand cannot be empty");
					return;
				}

				_brand = value.Trim();

			}
		}

		public string Model  // "" "    "  "   Corola" 
		{
			get { return _model; }
			set
			{
				if (string.IsNullOrWhiteSpace(value))
				{
					Console.WriteLine("Brand cannot be empty");
					return;
				}

				_model = value.Trim();

			}
		}

		public int? Year
		{
			get { return _year; }
			set 
			{

				if (!int.TryParse(value.ToString(), out _year))
				{
					Console.WriteLine("Year must be a number");
					return;
				}
				
				else if (value < 1800 || value > DateTime.Now.Year)
				{
					Console.WriteLine("Year must be between 1800 and current year");
					return;

				}
				_year = value ?? 0;
			}
		}
		public decimal Price
		{
			get { return _price; }
			set
			{

				if (!decimal.TryParse(value.ToString(), out _price))
				{
					Console.WriteLine("Price must be a number");
					return;
				}

				else if (value <=0)
				{
					Console.WriteLine("Price must be greater than 0");
					return;

				}
				_price = value;
			}
		}
		public Color Color  // "" "    "  "   Corola" 
		{
			get { return _color; }
			set
			{
				if (!Color.TryParse(value.ToString(), out _color))
				{
					Console.WriteLine("Color cannot other then in the list");
					return;
				}

				_color = value;

			}
		}





		public void PrintInfo()
		{
			//if (Brand == null)
			//{

			//}
			//?? 
			Brand ??= "No brand";
			Console.WriteLine($"{Brand ??= "No brand"} {Model} {Year} {Price} {Color}");

		}


		public static void PrintAllCarsInfo(Car[] cars) 
		{
			foreach (var car in cars)
			{
				//Console.WriteLine($"{car.Brand} {car.Model} {car.Year} {car.Price} {car.Color}");
				Console.WriteLine(car.ToString());
			}
		}
	
		public static bool Equals(Car? car, Car? other)
		{
			if(car.Model == other.Model && car.Year == other.Year && car.Price == other.Price && car.Color == other.Color && car.Brand == other.Brand)
			{
				return true;
			}
			return false;
		}

		//public override int GetHashCode()
		//{
		//	return base.GetHashCode();
		//}

		public override string? ToString()
		{
			return  $"{Brand} {Model} {Year} {Price} {Color}";
				//base.ToString();
		}



		// TryParse-ის მსგავსი მეთოდი, რომელიც სტრინგიდან ეცდება მანქანის "გაპარსვას".
		public static bool TryParse(string line, char delimiter, out Car parsedCar)
		{
			if (string.IsNullOrWhiteSpace(line))
			{
				// default მნიშვნელობებით ვაკეთებ ობიექტს
				parsedCar = new Car();
				return false;
			}

			string[] data = line.Split(delimiter);

			if (data.Length < 5)
			{
				parsedCar = new Car();
				return false;
			}

			if (!int.TryParse(data[2], out int year)) { year = 0; }
			if (!decimal.TryParse(data[3], out decimal price)) { price = -1; }

			parsedCar = new Car(data[0], data[1], year, price, (Color)Enum.Parse(typeof(Color), data[4]));
			return true;
		}

		// სტატიკური მეთოდი ფაილიდან მანქანების წასაკითხად
		public static Car[] ReadCarsFromFile(string fileName)
		{
			if (!File.Exists(fileName))
			{
				Console.WriteLine($"Error: The file '{fileName}' not found.\nReturning empty array...");
				return [];
			}
			string[] lines = File.ReadAllLines(fileName);
			//გამოვყოთ მანქანების მასივი
			Car[] cars = new Car[lines.Length];
			/* შესაძლოა ზოგიერთი ხაზი არავალიდური იყოს, ამ შემთხვევაში
               მანქანას არ დავამატებ სანამ ვალიდურ ხაზს არ მივიღებ.
               თუ ასე მოხდა მასივი მთლიანად არ შეივსება, ამიტომ Array.resize-ს გამოვიყენებ.
             */
			int validCount = 0;

			foreach (string line in lines)
			{
				if (TryParse(line, ',', out Car temp))
				{
					cars[validCount] = temp;
					validCount++;
				}
			}
			if (cars.Length != validCount)
				Array.Resize(ref cars, validCount);
			return cars;
		}


		// obejct 
		// ToString()
		// Equals()
		// GetHashCode()
	}






	//მთელი რიცხვები და დეფაულთად ინტ

	public enum Color : byte
	{
		Red = 10,  // 0
		Blue,
		Green,
		Yellow,
		Black,
		White,
		Pink,
		Silver,
		Gray,
		FluidMetal
	}

	

}
