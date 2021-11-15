using Exercise3_CodeKata_YemekSepetiRestaurantAPI3.Models;
using Exercise3_CodeKata_YemekSepetiRestaurantAPI3.Services.Abstract;
using System.Collections.Generic;

namespace Exercise3_CodeKata_YemekSepetiRestaurantAPI3.Services.Concrete
{
    public class RestaurantService : IRestaurantService
    {
        public IList<Restaurant> GetRestaurants()
        {
            return new List<Restaurant>
                {
                    new Restaurant { Id = 0, Name = "Pizza Bulls", City = "Istanbul", Region = "Tuzla-Icmeler-Mah", MinDelivery = 19.90, DeliveryTimeMin = 30, DeliveryTimeMax = 40, IsDeleted = false },
                    new Restaurant { Id = 1, Name = "Little Caesars Pizza", City = "Kocaeli", Region = "Darica-Baglarbasi-Mah", MinDelivery = 24.90, DeliveryTimeMin = 20, DeliveryTimeMax = 30, IsDeleted = true },
                    new Restaurant { Id = 2, Name = "Oses Cig Kofte", City = "Kocaeli", Region = "Darica-Zincirlikuyu-Mah", MinDelivery = 20.00, DeliveryTimeMin = 20, DeliveryTimeMax = 30, IsDeleted = false }
                 };
        }
    }
}
