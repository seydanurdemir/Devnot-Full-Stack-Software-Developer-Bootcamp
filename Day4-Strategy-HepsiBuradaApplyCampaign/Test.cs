// Import used namespaces.
using System;
using System.Collections.Generic;

/**
 * namespace Day4_Strategy_HepsiBuradaCalculatePrice : Covers exercise of fourth day.
 */
namespace Day4_Strategy_HepsiBuradaCalculatePrice
{
    /**
     * class Test : Tests all campaigns in different test methods.
     */
    public class Test
    {
        public void TestCampaigns(List<Product> products, ICampaign campaign, ICoupon coupon)
        {
            Console.WriteLine("--------------------------------------------------");

            Console.WriteLine("HEPSI BURADA SEPET");
            Console.WriteLine("--------------------------------------------------");

            Console.WriteLine("Sepetteki Urunler");
            Console.WriteLine("--------------------------------------------------");

            double discountedPrice = 0;
            double totalPrice = 0;
            double totalDiscountedPrice = 0;
            double lastPrice = 0;
            double cargoAppliedPrice = 0;
            CalculatePrice calculate = new CalculatePrice();

            foreach (var product in products)
            {
                totalPrice += product.Price;
                discountedPrice = calculate.CalculateDiscountedPrice(product.Price, campaign);
                totalDiscountedPrice += discountedPrice;
                Console.WriteLine(product.ToString() + " yerine sadece " + discountedPrice);
            }

            Console.WriteLine("--------------------------------------------------");

            Console.WriteLine("Toplam Tutar : " + String.Format("{0:0.00}", totalPrice));
            Console.WriteLine("*** " + campaign.GetType().Name + " kampanyasi uygulandi");
            Console.WriteLine("Kampanyali Tutar : " + String.Format("{0:0.00}", totalDiscountedPrice));

            Console.WriteLine("--------------------------------------------------");

            lastPrice = calculate.CalculateLastPrice(totalDiscountedPrice, coupon);
            Console.WriteLine("*** " + coupon.GetType().Name + " kuponu uygulandi");
            Console.WriteLine("Odenecek Tutar : " + String.Format("{0:0.00}", lastPrice));

            Console.WriteLine("--------------------------------------------------");

            cargoAppliedPrice = calculate.CalculateDiscountedPrice(lastPrice, new Cargo());
            Console.WriteLine("Kargo Dahil Toplam Tutar : " + String.Format("{0:0.00}", cargoAppliedPrice));

            Console.WriteLine("--------------------------------------------------");
        }
    }
}
