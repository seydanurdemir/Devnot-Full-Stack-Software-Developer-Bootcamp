using Exercise3_CodeKata_YemekSepetiRestaurantAPI2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise3_CodeKata_YemekSepetiRestaurantAPI2.Services
{
    public class AltRestaurantService : IRestaurantService
    {
        private List<Restaurant> restaurants = new List<Restaurant>
            {
                new Restaurant { Id = 0, Name = "Pizza Bulls", City = "Istanbul", Region = "Tuzla-Icmeler-Mah", MinDelivery = 19.90, DeliveryTimeMin = 30, DeliveryTimeMax = 40, IsDeleted = false },
                new Restaurant { Id = 1, Name = "Little Caesars Pizza", City = "Kocaeli", Region = "Darica-Baglarbasi-Mah", MinDelivery = 24.90, DeliveryTimeMin = 20, DeliveryTimeMax = 30, IsDeleted = true },
                new Restaurant { Id = 2, Name = "Oses Cig Kofte", City = "Kocaeli", Region = "Darica-Zincirlikuyu-Mah", MinDelivery = 20.00, DeliveryTimeMin = 20, DeliveryTimeMax = 30, IsDeleted = false }
            };

        public IList<Restaurant> GetRestaurants()
        {
            return restaurants;
        }

        public Restaurant AddRestaurant(Restaurant restaurant)
        {
            restaurants.Add(restaurant);
            return restaurant;
        }

        public Restaurant EditRestaurant(int index, Restaurant restaurant)
        {
            restaurants[index] = restaurant;
            return restaurant;
        }

        public void DeleteRestaurant(int index)
        {
            restaurants.RemoveAt(index);
        }
    }
}
