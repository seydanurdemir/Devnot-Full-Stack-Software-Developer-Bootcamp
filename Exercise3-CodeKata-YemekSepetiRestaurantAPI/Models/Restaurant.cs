using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise3_CodeKata_YemekSepetiRestaurantAPI.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Required!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Required!")]
        public string City { get; set; }
        [Required(ErrorMessage = "Required!")]
        public string Region { get; set; }
        public double Speed { get; set; }
        public double Service { get; set; }
        public double Flavour { get; set; }
        [Required(ErrorMessage = "Required!")]
        public double MinDelivery { get; set; }
        [Required(ErrorMessage = "Required!")]
        public int DeliveryTimeMin { get; set; }
        [Required(ErrorMessage = "Required!")]
        public int DeliveryTimeMax { get; set; }
    }
}
