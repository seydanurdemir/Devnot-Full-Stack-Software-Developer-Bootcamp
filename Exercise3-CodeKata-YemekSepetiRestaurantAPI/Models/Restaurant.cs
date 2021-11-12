using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise3_CodeKata_YemekSepetiRestaurantAPI.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public double Speed { get; set; }
        public double Service { get; set; }
        public double Flavour { get; set; }
        public double MinDelivery { get; set; }
        public int DeliveryTimeStart { get; set; }
        public int DeliveryTimeEnd { get; set; }
    }
}
