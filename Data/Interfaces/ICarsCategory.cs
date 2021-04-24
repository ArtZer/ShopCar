using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopCar.Data.Models;

namespace ShopCar.Data.Interfaces
{
    public interface ICarsCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
