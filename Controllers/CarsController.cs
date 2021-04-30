using Microsoft.AspNetCore.Mvc;
using ShopCar.Data.Interfaces;
using ShopCar.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopCar.Controllers
{
    public class CarsController: Controller // CarsController - в адресной строке только Cars, Controller ключевое слово для VS
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategory;

        public CarsController(IAllCars iAllCars, ICarsCategory iCarsCat)
        {
            _allCars = iAllCars;
            _allCategory = iCarsCat;
        }
        public ViewResult List() 
            // функция которая возвращает страницу со всеми машинами.
            // черз интерфейс связанные с mock с помощью services.AddTransient<IAllCars, MockCars>();
        {
            //ViewBag.Category = "Some new"; //После точки придумываем название. Позволяет написав название в List.chtml  сразу передать значени.
            ////Но редко сипользуется т.к. при больших кол. данных много писать надо будет.
            //var cars = _allCars.cars;
            ViewBag.Title = "Страница с автомобилями";
            CarsListViewModel obj = new CarsListViewModel();
            obj.allCars = _allCars.cars;
            obj.currCategory = "Автомобили";
             
            return View(obj);
        }
    }
}
