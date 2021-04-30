using ShopCar.Data.Interfaces;
using ShopCar.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopCar.Data.Mocks
{
    public class MockCars : IAllCars
    {

        private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> cars {
            get {
                return new List<Car> {
                    new Car {
                        name = "Tesla",
                        shortDesc = "Стильный и безопастный",
                        longDesc = "Самая комфотрная и технологичная машина",
                        img = "/img/tesla.jpg",
                        price = 45000,
                        isfavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.First()
                    },
                    new Car {
                        name = "Ford Fiesta",
                        shortDesc = "Тихий и спокойный",
                        longDesc = "Добный для города автомобиль",
                        img = "/img/Fiesta-ST2001.jpg",
                        price = 11000,
                        isfavourite = false,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car {
                        name = "Nissan Leaf",
                        shortDesc = "Тихий и спокойный",
                        longDesc = "Добный для города автомобиль",
                        img = "/img/Nissan Leaf.jpg",
                        price = 14000,
                        isfavourite = false,
                        available = false,
                        Category = _categoryCars.AllCategories.First()
                    }

                };
            }
        }
        public IEnumerable<Car> getFavCars { get; set; }

        public Car getObjectCar(int carid)
        {
            throw new NotImplementedException();
        }
    }
}
