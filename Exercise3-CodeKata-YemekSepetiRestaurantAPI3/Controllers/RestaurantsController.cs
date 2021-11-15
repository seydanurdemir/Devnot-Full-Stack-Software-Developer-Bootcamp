using Exercise3_CodeKata_YemekSepetiRestaurantAPI3.Models;
using Exercise3_CodeKata_YemekSepetiRestaurantAPI3.Services.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Exercise3_CodeKata_YemekSepetiRestaurantAPI3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantsController : ControllerBase
    {
        IRestaurantService restaurantService;

        public RestaurantsController(IRestaurantService restaurantService)
        {
            this.restaurantService = restaurantService;
        }

        [HttpGet] // Ok + data

        public IActionResult GetRestaurants()
        {
            var restaurants = restaurantService.GetRestaurants();
            return Ok(restaurants);
        }

        [HttpGet("{id}")] // Ok + data | NotFound + message | NotFound + message

        public IActionResult GetRestaurantById(int id)
        {
            var restaurants = restaurantService.GetRestaurants();
            int index = restaurants.IndexOf(restaurants.FirstOrDefault(r => r.Id == id));
            if (index != -1)
            {
                if (restaurants[index].IsDeleted == false)
                {
                    return Ok(restaurants[id]);
                }
                return NotFound(new { Message = "There is no any restaurant by this id." });
            }
            return NotFound(new { Message = "There is no any restaurant by this id." });
        }

        [HttpGet("City/{city}")] // Ok + data | NotFound + message

        public IActionResult GetRestaurantsByCity(string city)
        {
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
            return NotFound(new { Message = "There is no any restaurant in this city." });
        }

        [HttpGet("Region/{region}")] // Ok + data | NotFound + message

        public IActionResult GetRestaurantsByRegion(string region)
        {
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
            return NotFound(new { Message = "There is no any restaurant in this region." });
        }

        [HttpPost] // CreatedAtAction + link | BadRequest + data

        public IActionResult AddRestaurant([FromBody] Restaurant restaurant)
        {
            var restaurants = restaurantService.GetRestaurants();
            if (ModelState.IsValid)
            {
                var newId = restaurants[restaurants.Count - 1].Id + 1;
                restaurant.Id = newId;
                restaurants.Add(restaurant);
                return CreatedAtAction(nameof(GetRestaurants), new { id = restaurant.Id }, null);
            }
            return BadRequest(ModelState);
        }

        [HttpPut("{id}")] // Ok + data | NotFound + message | BadRequest + message

        public IActionResult EditRestaurant(int id, Restaurant restaurant)
        {
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
                return NotFound(new { Message = "There is no any restaurant by this id." });
            }
            return BadRequest(new { Message = "Invalid entry." });
        }

        [HttpDelete("{id}")] // Ok | NotFound + message

        public IActionResult RemoveRestaurant(int id)
        {
            var restaurants = restaurantService.GetRestaurants();
            int index = restaurants.IndexOf(restaurants.FirstOrDefault(r => r.Id == id));
            if (index != -1)
            {
                restaurants[index].IsDeleted = true;
                return Ok();
            }
            return NotFound(new { Message = "There is no any restaurant by this id." });
        }
    }
}
