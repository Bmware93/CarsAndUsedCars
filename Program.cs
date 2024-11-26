// See https://aka.ms/new-console-template for more information
using CarsAndUsedCars;

Car newCar1 = new Car { Make = "Ford", Model = "Fusion", Price = 40000.00m, Year = 2025 };
Car newCar2 = new Car { Make = "Ford", Model = "F1-50", Price = 75000.90m, Year = 2025 };
Car newCar3 = new Car { Make = "Jeep", Model = "Cherokee", Price = 65000.01m, Year = 2024 };

UsedCar usedCar1 = new UsedCar(120000)
{
    Make = "Jeep",
    Model = "Grand Cherokee",
    Price = 22000.90m,
    Year = 2015
};

UsedCar usedCar2 = new UsedCar(135438)
{
    Make = "Cadillac",
    Model = "Escalade",
    Price = 20000.18m,
    Year = 2018
};

UsedCar usedCar3 = new UsedCar(150000)
{
    Make = "Buick",
    Model = "Envision",
    Price = 19000.20m,
    Year = 2016
};

Car.Cars.Add(newCar1);
Car.Cars.Add(newCar2);
Car.Cars.Add(newCar3);
Car.Cars.Add(usedCar1);
Car.Cars.Add(usedCar2);
Car.Cars.Add(usedCar3);

Car.ListCars();
Console.WriteLine();
Car.Remove(2);
Car.ListCars();