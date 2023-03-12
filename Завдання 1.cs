using System;
using System.Collections.Generic;

namespace SharpWasher
{
    
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public Car(string brand, string model, int year, string color)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Color = color;
        }
    }

        public class Garage
    {
        private List<Car> cars = new List<Car>();

        public void AddCar(Car car)
        {
            cars.Add(car);
        }

        public void RemoveCar(Car car)
        {
            cars.Remove(car);
        }

        public List<Car> GetAllCars()
        {
            return cars;
        }
    }

   
    public class Washer
    {
        public void Wash(Car car)
        {
            Console.WriteLine($"Мию автомобіль {car.Brand} {car.Model}, {car.Color}, {car.Year} року випуску");
        }
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            
            Garage garage = new Garage();
            garage.AddCar(new Car("BMW", "X5", 2020, "Чорний"));
            garage.AddCar(new Car("Mercedes-Benz", "E-Class", 2022, "Сірий"));
            garage.AddCar(new Car("Audi", "A4", 2019, "Білий"));

           
            Washer washer = new Washer();

            
            List<Car> cars = garage.GetAllCars();
            foreach (Car car in cars)
            {
                washer.Wash(car);
            }

            Console.ReadKey();
        }
    }
}