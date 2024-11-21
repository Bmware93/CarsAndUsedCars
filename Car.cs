using System;
namespace CarsAndUsedCars
{
	internal class Car
	{
		public string Make { get; set; }
										
		public string Model { get; set; }

		public int Year { get; set; }

		public decimal Price { get; set; }

        public static List<Car> Cars = new();

		public Car()
		{
			Make = "";
			Model = "";
			Year = 0;
			Price = 0;
		}

		public Car(string make, string model, int year, decimal price)
		{
			Make = make;
			Model = model;
			Year = year;
			Price = price;
		}

		public override string ToString()
		{
			return $"{Year} {Make} {Model} {Price}";
		}

		public static void ListCars()
		{
			for(int i = 0; i < Cars.Count; i++)
			{
				Console.WriteLine($"{Cars[i].ToString} {i}");
			}
		}

		public static void Remove(int indexToRemove)
		{
			try
			{
                Cars.RemoveAt(indexToRemove);
            }
			catch (ArgumentOutOfRangeException error)
			{
				Console.WriteLine(error.Message);
			}
			
		}


	}
}

