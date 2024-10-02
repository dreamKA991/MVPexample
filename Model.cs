using System;
using System.Collections.Generic;

namespace MVPexample
{
    public struct Car
    {
        public string Make;
        public string Model;
        public int Year;

        public Car(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }
    }

    public class Model
    {
        private List<Car> cars;

        public Model()
        {
            cars = new List<Car>
            {
                new Car("Toyota", "Corolla", 2020),
                new Car("Ford", "Mustang", 2022),
                new Car("Honda", "Civic", 2018),
                new Car("BMW", "X5", 2021),
                new Car("Mercedes", "C-Class", 2019)
            };
        }

        public void AddCar(string make, string model, int year)
        {
            Car newCar = new Car(make, model, year);
            cars.Add(newCar);
        }

        public void RemoveCar(int index)
        {
            if (index >= 0 && index < cars.Count)
            {
                cars.RemoveAt(index);
            }
        }

        public List<Car> GetAllCars()
        {
            return cars;
        }
    }
}
