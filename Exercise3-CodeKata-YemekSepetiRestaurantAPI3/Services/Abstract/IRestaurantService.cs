using Exercise3_CodeKata_YemekSepetiRestaurantAPI3.Models;
using System.Collections.Generic;

namespace Exercise3_CodeKata_YemekSepetiRestaurantAPI3.Services.Abstract
{
    public interface IRestaurantService
    {
        IList<Restaurant> GetRestaurants();
    }
}
