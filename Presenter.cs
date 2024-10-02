using System.Collections.Generic;

namespace MVPexample
{
    public class Presenter
    {
        private IView view;
        private Model carModel;

        public Presenter(IView view, Model model)
        {
            this.view = view;
            this.carModel = model;
        }

        public void ShowAllCars()
        {
            List<Car> cars = carModel.GetAllCars();
            view.DisplayCars(cars);
        }

        public void AddCar()
        {
            string make = view.GetCarMake();
            string model = view.GetCarModel();
            int year = view.GetCarYear();
            carModel.AddCar(make, model, year);
            view.ShowMessage($"Додана машина: {make} {model}, рік: {year}");
        }

        public void RemoveCar()
        {
            int index = view.GetCarIndex();
            carModel.RemoveCar(index);
            view.ShowMessage("Машина видалена.");
        }
    }
}
