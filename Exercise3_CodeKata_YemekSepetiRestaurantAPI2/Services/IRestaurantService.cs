using Exercise3_CodeKata_YemekSepetiRestaurantAPI2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise3_CodeKata_YemekSepetiRestaurantAPI2.Services
{
    public interface IRestaurantService
    {
        IList<Restaurant> GetRestaurants();
    }
}
