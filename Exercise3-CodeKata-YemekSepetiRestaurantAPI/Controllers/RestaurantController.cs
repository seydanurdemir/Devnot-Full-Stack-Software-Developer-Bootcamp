﻿using Exercise3_CodeKata_YemekSepetiRestaurantAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise3_CodeKata_YemekSepetiRestaurantAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantController : ControllerBase
    {
        private List<Restaurant> restaurants = new List<Restaurant>
        {
            new Restaurant { Id = 0, Name = "Pizza Bulls", City = "Istanbul", Region = "Tuzla-Icmeler-Mah", MinDelivery = 19.90, DeliveryTimeMin = 30, DeliveryTimeMax = 40 },
            new Restaurant { Id = 1, Name = "Little Caesars Pizza", City = "Kocaeli", Region = "Darica-Baglarbasi-Mah", MinDelivery = 24.90, DeliveryTimeMin = 20, DeliveryTimeMax = 30 },
            new Restaurant { Id = 2, Name = "Oses Cig Kofte", City = "Kocaeli", Region = "Darica-Zincirlikuyu-Mah", MinDelivery = 20.00, DeliveryTimeMin = 20, DeliveryTimeMax = 30 }
         };

        [HttpGet("All")]

        public IActionResult GetRestaurants()
        {
            return Ok(restaurants);
        }

        [HttpGet("Id/{id}")]

        public IActionResult GetRestaurantById(int id)
        {
            Restaurant restaurant = restaurants.FirstOrDefault(r => r.Id == id);
            if (restaurant != null)
            {
                return Ok(restaurant);
            }
            return BadRequest(new { Message = "There is no any restaurant by this id."});
        }

        [HttpGet("City/{city}")]

        public IActionResult GetRestaurantsByCity(string city)
        {
            List<Restaurant> newRestaurantsByCity = new List<Restaurant>();
            foreach(Restaurant restaurant in restaurants)
            {
                if (restaurant.City == city)
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
            List<Restaurant> newRestaurantsByRegion = new List<Restaurant>();
            foreach (Restaurant restaurant in restaurants)
            {
                if (restaurant.Region == region)
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
    }
}
