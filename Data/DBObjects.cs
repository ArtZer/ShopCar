using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using ShopCar.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopCar.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));

            if (!content.Car.Any())
            {
                content.AddRange(
                    new Car
                    {
                        name = "Tesla",
                        shortDesc = "Стильный и безопастный",
                        longDesc = "Самая комфотрная и технологичная машина",
                        img = "/img/tesla.jpg",
                        price = 45000,
                        isfavourite = true,
                        available = true,
                        Category = Categories["Электромобили"]
                    },
                    new Car
                    {
                        name = "Ford Fiesta",
                        shortDesc = "Обычный",
                        longDesc = "Добный для города автомобиль",
                        img = "/img/Fiesta-ST2001.jpg",
                        price = 11000,
                        isfavourite = false,
                        available = true,
                        Category = Categories["Классические автомобили"]
                    },
                    new Car
                    {
                        name = "Nissan Leaf",
                        shortDesc = "Тихий и спокойный",
                        longDesc = "Добный для города автомобиль",
                        img = "/img/Nissan Leaf.jpg",
                        price = 14000,
                        isfavourite = false,
                        available = false,
                        Category = Categories["Электромобили"]
                    }
                    );
            }

            content.SaveChanges();
        }

        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories 
        {
            get
            {
                if(category == null)
                {
                    var list = new Category[]
                    {
                        new Category {categoryName = "Электромобили", desc = "Современный вид транспорта"},
                        new Category {categoryName = "Классические автомобили", desc = "Машины с двигателем внутреннего сгорания"}
                    };

                    category = new Dictionary<string, Category>();
                    foreach (Category element in list)
                        category.Add(element.categoryName, element);
                }

                return category;
            }

        }
    }
}
