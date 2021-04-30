using Microsoft.EntityFrameworkCore;
using ShopCar.Data.Interfaces;
using ShopCar.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopCar.Data.Repository
{
    public class CarRepository : IAllCars
    {
        private readonly AppDBContent appDBContent;
        public CarRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Car> cars => appDBContent.Car.Include(c => c.Category);

        public IEnumerable<Car> getFavCars => appDBContent.Car.Where(p => p.isfavourite).Include(c => c.Category);

        public Car getObjectCar(int carid) => appDBContent.Car.FirstOrDefault(p => p.id == carid);
    }
}
