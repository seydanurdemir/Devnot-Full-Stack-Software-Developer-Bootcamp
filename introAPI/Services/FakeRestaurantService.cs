using introAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace introAPI.Services
{
    public class FakeRestaurantService : IRestaurantService
    {
        private List<Restaurant> restaurants = new List<Restaurant>
        {
            new Restaurant { Id=1, Name="Kofteci Yusuf"},
            new Restaurant { Id=2, Name="Mc Donalds"},
            new Restaurant { Id=3, Name="Burger King"},
        };
        
        //public IEnumerable<Restaurant> GetRestaurants()
        public IList<Restaurant> GetRestaurants()
        {
            return restaurants;
        }
    }
}
