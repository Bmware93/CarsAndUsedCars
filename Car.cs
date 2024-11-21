﻿using System;
namespace CarsAndUsedCars
{
	internal class Car
	{
		public string Make { get; set; }
										
		public string Model { get; set; }

		public int Year { get; set; }

		public decimal Price { get; set; }

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
	}
}

