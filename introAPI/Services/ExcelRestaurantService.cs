using introAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace introAPI.Services
{
    public class ExcelRestaurantService : IRestaurantService
    {
        public IList<Restaurant> GetRestaurants()
        {
            //throw new NotImplementedException();
            return new List<Restaurant>
                {
                    new Restaurant { Id=1, Name="Kofteci Yusuf - Excel"},
                    new Restaurant { Id=2, Name="Mc Donalds - Excel"},
                    new Restaurant { Id=3, Name="Burger King - Excel"},
                };
        }
    }
}
