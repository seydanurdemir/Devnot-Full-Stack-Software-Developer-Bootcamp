using introAPI.Models;
using introAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace introAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantsController : ControllerBase
    {
        /*private List<Restaurant> restaurants = new List<Restaurant>
            {
                new Restaurant{ Id=1, Name="Kofteci Yusuf"},
                new Restaurant{ Id=2, Name="Mc Donalds"},
                new Restaurant{ Id=3, Name="Burger King"}
            };*/

        //FakeRestaurantService restaurantService = new FakeRestaurantService();
        //FakeRestaurantService restaurantService;
        IRestaurantService restaurantService;

        //public RestaurantsController(FakeRestaurantService restaurantService)
        public RestaurantsController(IRestaurantService restaurantService)
        {
            //this.restaurantService = restaurantService;
            this.restaurantService = restaurantService;
        }

        [HttpGet]
        public IActionResult GetRestaurants()
        {
            /*FakeRestaurantService restaurantService = new FakeRestaurantService();*/
            var restaurants = restaurantService.GetRestaurants();
            return Ok(restaurants);
        }

        [HttpGet("{id}")]
        public IActionResult GetRestaurant(int id)
        {
            var restaurants = restaurantService.GetRestaurants();
            var restaurant = restaurants.FirstOrDefault(r => r.Id == id);
            if (restaurant != null)
            {
                return Ok(restaurants);
            }
            //return NotFound();
            return BadRequest(new { Message = $"{id} id'li bir restoran bulunamadi!" });
        }

        [HttpGet("Search/{cityId}")]
        public IActionResult GetRestaurantByCity(int cityId)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult AddRestaurant([FromBody]Restaurant restaurant)
        {
            var restaurants = restaurantService.GetRestaurants();
            if (ModelState.IsValid)
            {
                restaurants.Add(restaurant);
                restaurant.Id = restaurants[restaurants.Count - 1].Id + 1;
                //StatusCodes.201
                return CreatedAtAction(nameof(GetRestaurant), new { id = restaurant.Id }, null);
            }
            return BadRequest(ModelState);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateRestaurant(int id, Restaurant newRestaurant)
        {
            if (id > 0)
            {
                if (ModelState.IsValid)
                {
                    // guncellendi
                    return Ok(newRestaurant);
                }
                return BadRequest(ModelState);
            }
            return NotFound();
        }

        //private bool isExist(int id)
        //{
        //    return id % 2 == 0 ? true : false;
        //}

        [HttpDelete("{id}")]
        //[HttpDelete()]
        public IActionResult DeleteRestaurant(int id)
        //public IActionResult DeleteRestaurant(List<int> id)
        {
            // silindi
            return Ok();
        }

        [HttpGet("Rest")]
        public Restaurant GetRestaurant()
        {
            return new Restaurant { Id = 4, Name = "Kayseri Mutfagi" };
        }
    }
}
