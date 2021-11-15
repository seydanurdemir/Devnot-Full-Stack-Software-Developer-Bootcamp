namespace Exercise3_CodeKata_YemekSepetiRestaurantAPI3.Models
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
        public int DeliveryTimeMin { get; set; }
        public int DeliveryTimeMax { get; set; }
        public bool IsDeleted { get; set; }
    }
}
