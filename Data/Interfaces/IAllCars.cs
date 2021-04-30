using ShopCar.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopCar.Data.Interfaces
{
    public interface IAllCars
    {
        IEnumerable<Car> cars { get; }
        IEnumerable<Car> getFavCars { get; }
        Car getObjectCar(int carid);
    }
}
