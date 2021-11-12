// Import used namespaces.
using System;

/**
* namespace Exercise1_Strategy_HepsiBuradaCalculatePrice : Covers exercise of fourth day.
*/
namespace Exercise1_Strategy_HepsiBuradaCalculatePrice
{
    /**
     * class Cargo : Implements ICoupon interface.
     */
    public class CargoFree : ICoupon
    {
        /**
         * double CARGO_FEE : Order cargo fee.
         */
        public const double CARGO_FEE = 12.99;

        /**
         * ApplyCoupon method : Takes product discounted price, calculates and returns product last price.
         * @param double discountedPrice : Product discounted price.
         * @return double lastPrice : Product last price.
         */
        public double ApplyCoupon(double discountedPrice)
        {
            if (discountedPrice >= CARGO_FEE)
            {
                return (discountedPrice - CARGO_FEE);
            }
            else
            {
                return (0);
            }
        }
    }

    /**
     * class FiftyTL : Implements ICoupon interface.
     */
    public class FiftyTL : ICoupon
    {
        /**
         * double QUANTITY : Coupon quantity.
         */
        public const double QUANTITY = 50.00;

        /**
         * ApplyCoupon method : Takes product discounted price, calculates and returns product last price.
         * @param double discountedPrice : Product discounted price.
         * @return double lastPrice : Product last price.
         */
        public double ApplyCoupon(double discountedPrice)
        {
            if (discountedPrice >= QUANTITY)
            {
                Console.WriteLine("Kupon Indirim Tutari : " + String.Format("{0:0.00}", QUANTITY));
                return (discountedPrice - QUANTITY);
            }
            else
            { 
                Console.WriteLine("Kupon Indirim Tutari : " + String.Format("{0:0.00}", (discountedPrice)));
                Console.WriteLine("Kalan Kupon Miktari : " + String.Format("{0:0.00}", (QUANTITY - discountedPrice)));
                return (0);
            }
        }
    }

    /**
     * class TwoHundredTL : Implements ICoupon interface.
     */
    public class TwoHundredTL : ICoupon
    {
        /**
         * double QUANTITY : Coupon quantity.
         */
        public const double QUANTITY = 20.00;

        /**
         * double COUPON_BASE_LIMIT : Coupon base limit.
         */
        public const double COUPON_BASE_LIMIT = 200.00;

        /**
         * ApplyCoupon method : Takes product discounted price, calculates and returns product last price.
         * @param double discountedPrice : Product discounted price.
         * @return double lastPrice : Product last price.
         */
        public double ApplyCoupon(double discountedPrice)
        {
            if (discountedPrice >= COUPON_BASE_LIMIT)
            {
                Console.WriteLine("Kupon indirim tutari : " + QUANTITY);
                return (discountedPrice - QUANTITY);
            }
            else
            {
                Console.WriteLine("Kuponunuzu kullanabilmek icin kalan harcama tutari : " + String.Format("{0:0.00}", (COUPON_BASE_LIMIT - discountedPrice)));
                return (discountedPrice);
            }
        }
    }
}
