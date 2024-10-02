using System;

namespace MVPexample
{
    class Program
    {
        static void Main(string[] args)
        {
            Model model = new Model();
            View view = new View();
            Presenter presenter = new Presenter(view, model);

            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("Меню управління автомобілями:");
                Console.WriteLine("1. Показати всі автомобілі");
                Console.WriteLine("2. Додати автомобіль");
                Console.WriteLine("3. Видалити автомобіль");
                Console.WriteLine("4. Вийти");
                Console.Write("Виберіть дію (1-4): ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        presenter.ShowAllCars();
                        break;
                    case "2":
                        presenter.AddCar();
                        break;
                    case "3":
                        presenter.RemoveCar();
                        break;
                    case "4":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Невірний вибір. Спробуйте ще раз.");
                        break;
                }

                if (!exit)
                {
                    Console.WriteLine("\nНатисніть будь-яку клавішу, щоб продовжити...");
                    Console.ReadKey();
                }
            }
        }
    }
}
