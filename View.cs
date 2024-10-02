using System;
using System.Collections.Generic;

namespace MVPexample
{
    public interface IView
    {
        void DisplayCars(List<Car> cars);
        void ShowMessage(string message);
        string GetCarMake();
        string GetCarModel();
        int GetCarYear();
        int GetCarIndex();
    }

    public class View : IView
    {
        public void DisplayCars(List<Car> cars)
        {
            Console.WriteLine("Список автомобілів:");
            for (int i = 0; i < cars.Count; i++)
            {
                Car car = cars[i];
                Console.WriteLine($"{i}. {car.Make} {car.Model}, рік: {car.Year}");
            }
        }

        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }

        public string GetCarMake()
        {
            Console.Write("Введіть марку автомобіля: ");
            return Console.ReadLine();
        }

        public string GetCarModel()
        {
            Console.Write("Введіть модель автомобіля: ");
            return Console.ReadLine();
        }

        public int GetCarYear()
        {
            int year;
            Console.Write("Введіть рік випуску: ");
            while (!int.TryParse(Console.ReadLine(), out year) || year < 1886 || year > DateTime.Now.Year)
            {
                Console.Write("Некоректний рік. Спробуйте ще раз: ");
            }
            return year;
        }

        public int GetCarIndex()
        {
            Console.Write("Введіть індекс автомобіля для видалення: ");
            int index;
            while (!int.TryParse(Console.ReadLine(), out index))
            {
                Console.Write("Невірний індекс. Спробуйте ще раз: ");
            }
            return index;
        }
    }
}
