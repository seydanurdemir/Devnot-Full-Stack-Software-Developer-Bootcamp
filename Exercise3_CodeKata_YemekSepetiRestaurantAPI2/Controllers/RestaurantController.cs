using Exercise3_CodeKata_YemekSepetiRestaurantAPI2.Models;
using Exercise3_CodeKata_YemekSepetiRestaurantAPI2.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise3_CodeKata_YemekSepetiRestaurantAPI2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantController : ControllerBase
    {
        //private List<Restaurant> restaurants = new List<Restaurant>
        //{
        //    new Restaurant { Id = 0, Name = "Pizza Bulls", City = "Istanbul", Region = "Tuzla-Icmeler-Mah", MinDelivery = 19.90, DeliveryTimeMin = 30, DeliveryTimeMax = 40, IsDeleted = false },
        //    new Restaurant { Id = 1, Name = "Little Caesars Pizza", City = "Kocaeli", Region = "Darica-Baglarbasi-Mah", MinDelivery = 24.90, DeliveryTimeMin = 20, DeliveryTimeMax = 30, IsDeleted = true },
        //    new Restaurant { Id = 2, Name = "Oses Cig Kofte", City = "Kocaeli", Region = "Darica-Zincirlikuyu-Mah", MinDelivery = 20.00, DeliveryTimeMin = 20, DeliveryTimeMax = 30, IsDeleted = false }
        // };

        // Dependency Injection
        IRestaurantService restaurantService;

        // Dependency Injection
        public RestaurantController(IRestaurantService restaurantService)
        {
            // Dependency Injection
            this.restaurantService = restaurantService;
        }

        [HttpGet]

        public IActionResult GetRestaurants()
        {
            // Dependency Injection
            var restaurants = restaurantService.GetRestaurants();
            List<Restaurant> newRestaurants = new List<Restaurant>();
            foreach (Restaurant restaurant in restaurants)
            {
                if (restaurant.IsDeleted == false)
                {
                    newRestaurants.Add(restaurant);
                }
            }
            if (newRestaurants.Count > 0)
            {
                return Ok(newRestaurants);
            }
            return Ok(new { Message = "There is no any restaurant." });
        }

        [HttpGet("{id}")]

        public IActionResult GetRestaurantById(int id)
        {
            // Dependency Injection
            var restaurants = restaurantService.GetRestaurants();
            int index = restaurants.IndexOf(restaurants.FirstOrDefault(r => r.Id == id));
            if (index != -1)
            {
                if (restaurants[index].IsDeleted == false)
                {
                    return Ok(restaurants[id]);
                }
                return BadRequest(new { Message = "There is no any restaurant by this id." });
            }
            return BadRequest(new { Message = "There is no any restaurant by this id." });
        }

        [HttpGet("City/{city}")]

        public IActionResult GetRestaurantsByCity(string city)
        {
            // Dependency Injection
            var restaurants = restaurantService.GetRestaurants();
            List<Restaurant> newRestaurantsByCity = new List<Restaurant>();
            foreach (Restaurant restaurant in restaurants)
            {
                if ((restaurant.City == city) && (restaurant.IsDeleted == false))
                {
                    newRestaurantsByCity.Add(restaurant);
                }
            }
            if (newRestaurantsByCity.Count > 0)
            {
                return Ok(newRestaurantsByCity);
            }
            return BadRequest(new { Message = "There is no any restaurant in this city." });
        }

        [HttpGet("Region/{region}")]

        public IActionResult GetRestaurantsByRegion(string region)
        {
            // Dependency Injection
            var restaurants = restaurantService.GetRestaurants();
            List<Restaurant> newRestaurantsByRegion = new List<Restaurant>();
            foreach (Restaurant restaurant in restaurants)
            {
                if ((restaurant.Region == region) && (restaurant.IsDeleted == false))
                {
                    newRestaurantsByRegion.Add(restaurant);
                }
            }
            if (newRestaurantsByRegion.Count > 0)
            {
                return Ok(newRestaurantsByRegion);
            }
            return BadRequest(new { Message = "There is no any restaurant in this region." });
        }

        [HttpPost]

        public IActionResult AddRestaurant([FromBody] Restaurant restaurant)
        {
            // Dependency Injection
            var restaurants = restaurantService.GetRestaurants();
            if (ModelState.IsValid)
            {
                var newId = restaurants[restaurants.Count - 1].Id + 1;
                restaurant.Id = newId;
                restaurants.Add(restaurant);
                return Ok(restaurant);
            }
            return BadRequest(new { Message = "Invalid entry." });
        }

        [HttpPut("{id}")]

        public IActionResult EditRestaurant(int id, Restaurant restaurant)
        {
            // Dependency Injection
            var restaurants = restaurantService.GetRestaurants();
            if (ModelState.IsValid)
            {
                int index = restaurants.IndexOf(restaurants.FirstOrDefault(r => r.Id == id));
                if (index != -1)
                {
                    if (restaurant.Name != null) restaurants[index].Name = restaurant.Name;
                    if (restaurant.City != null) restaurants[index].City = restaurant.City;
                    if (restaurant.Region != null) restaurants[index].Region = restaurant.Region;
                    if (restaurant.Speed != null) restaurants[index].Speed = restaurant.Speed;
                    if (restaurant.Service != null) restaurants[index].Service = restaurant.Service;
                    if (restaurant.Flavour != null) restaurants[index].Flavour = restaurant.Flavour;
                    if (restaurant.MinDelivery != null) restaurants[index].MinDelivery = restaurant.MinDelivery;
                    if (restaurant.DeliveryTimeMin != null) restaurants[index].DeliveryTimeMin = restaurant.DeliveryTimeMin;
                    if (restaurant.DeliveryTimeMax != null) restaurants[index].DeliveryTimeMax = restaurant.DeliveryTimeMax;
                    if (restaurant.IsDeleted != null) restaurants[index].IsDeleted = restaurant.IsDeleted;
                    return Ok(restaurants[index]);
                }
                return BadRequest(new { Message = "There is no any restaurant by this id." });
            }
            return BadRequest(new { Message = "Invalid entry." });
        }

        [HttpDelete("{id}")]

        public IActionResult RemoveRestaurant(int id)
        {
            // Dependency Injection
            var restaurants = restaurantService.GetRestaurants();
            int index = restaurants.IndexOf(restaurants.FirstOrDefault(r => r.Id == id));
            if (index != -1)
            {
                restaurants[index].IsDeleted = true;
                return Ok(restaurants[index]);
            }
            return BadRequest(new { Message = "There is no any restaurant by this id." });
        }
    }
}
