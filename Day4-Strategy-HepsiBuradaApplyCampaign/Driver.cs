// Import used namespaces.
using System;
using System.Collections.Generic;

/**
 * namespace Exercise1_Strategy_HepsiBuradaCalculatePrice : Covers exercise of fourth day.
 */
namespace Exercise1_Strategy_HepsiBuradaCalculatePrice
{
    /**
     * class Driver : Drives program using basic test method.
     */
    public class Driver
    {
        /**
         * Drive method : Drives program using basic test method.
         */
        public void Drive()
        {
            Test testCampaigns = new Test();

            List<Product> products = new List<Product>();
            products.Add(new Product { Name = "Kalem", Price = 12.50 });
            products.Add(new Product { Name = "Silgi", Price = 4.90 });
            products.Add(new Product { Name = "Kalemtiras", Price = 3.90 });
            products.Add(new Product { Name = "Defter", Price = 5.50 });
            products.Add(new Product { Name = "Okul Cantasi", Price = 259.90 });

            ICampaign campaign = new NationalHoliday();
            ICoupon coupon = new TwoHundredTL();

            testCampaigns.TestCampaigns(products, campaign, coupon);
        }
    }
}
