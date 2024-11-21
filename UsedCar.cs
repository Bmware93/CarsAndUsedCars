using System;
namespace CarsAndUsedCars
{
	internal class UsedCar : Car
	{
		public double Milage { get; set; }

		public UsedCar(double milage) : base()
		{
			milage = milage;
		}
	}
}

