// Import used namespaces.
using System;

/**
* namespace Exercise1_Strategy_HepsiBuradaCalculatePrice : Covers exercise of fourth day.
*/
namespace Exercise1_Strategy_HepsiBuradaCalculatePrice
{
    /**
     * class Cargo : Implements ICampaign interface.
     */
    public class Cargo : ICampaign
    {
        /**
         * double CARGO_FEE : Order cargo fee.
         */
        public const double CARGO_FEE = 12.99;

        /**
         * double CARGO_FREE_BASE_LIMIT : Order cargo free base limit.
         */
        public const double CARGO_FREE_BASE_LIMIT = 50;

        /**
         * double CARGO_FREE_TOP_LIMIT : Order cargo free top limit.
         */
        public const double CARGO_FREE_TOP_LIMIT = 999999;

        /**
         * ApplyCampaign method : Takes product price, calculates and returns product cargo fee.
         * @param double price : Product price.
         * @return double discountedPrice : Product discounted price.
         */
        public double ApplyCampaign(double price)
        {
            if (price < CARGO_FREE_BASE_LIMIT)
            {
                Console.WriteLine("Kargo Ucretlendirmesi : " + String.Format("{0:0.00}", CARGO_FEE));
                Console.WriteLine("*** Ücretsiz kargo icin kalan tutar " + String.Format("{0:0.00}", (CARGO_FREE_BASE_LIMIT - price)));
                return (price + CARGO_FEE);
            }
            else if ((price >= CARGO_FREE_BASE_LIMIT) && (price <= CARGO_FREE_TOP_LIMIT))
            {
                Console.WriteLine("Kargo Ucretlendirmesi : " + String.Format("{0:0.00}", 0));
                Console.WriteLine("*** Kargo bedava");
                return (price);
            }
            else if (price > CARGO_FREE_TOP_LIMIT)
            {
                Console.WriteLine("Kargo Ucretlendirmesi : " + String.Format("{0:0.00}", 0));
                Console.WriteLine("*** Kargo ucreti icin sizinle iletisime gececegiz");
                return (price);
            }
            else
            {
                return (price);
            }
        }
    }

    /**
     * class BirthDay : Implements ICampaign interface.
     */
    public class BirthDay : ICampaign
    {
        /**
         * double DISCOUNT_RATE : Product discount rate.
         */
        public const double DISCOUNT_RATE = 50;

        /**
         * ApplyCampaign method : Takes product price, calculates and returns product discounted price.
         * @param double price : Product price.
         * @return double discountedPrice : Product discounted price.
         */
        public double ApplyCampaign(double price)
        {
            return (price * ((100 - DISCOUNT_RATE) / 100));
        }
    }

    /**
     * class NewYear : Implements ICampaign interface.
     */
    public class NewYear : ICampaign
    {
        /**
         * double DISCOUNT_RATE : Product discount rate.
         */
        public const double DISCOUNT_RATE = 30;

        /**
         * ApplyCampaign method : Takes product price, calculates and returns product discounted price.
         * @param double price : Product price.
         * @return double discountedPrice : Product discounted price.
         */
        public double ApplyCampaign(double price)
        {
            return (price * ((100 - DISCOUNT_RATE) / 100));
        }
    }

    /**
     * class NationalHoliday : Implements ICampaign interface.
     */
    public class NationalHoliday : ICampaign
    {
        /**
         * double DISCOUNT_RATE : Product discount rate.
         */
        public const double DISCOUNT_RATE = 10;

        /**
         * ApplyCampaign method : Takes product price, calculates and returns product discounted price.
         * @param double price : Product price.
         * @return double discountedPrice : Product discounted price.
         */
        public double ApplyCampaign(double price)
        {
            return (price * ((100 - DISCOUNT_RATE) / 100));
        }
    }

    /**
     * class ReligiousHoliday : Implements ICampaign interface.
     */
    public class ReligiousHoliday : ICampaign
    {
        /**
         * double DISCOUNT_RATE : Product discount rate.
         */
        public const double DISCOUNT_RATE = 10;

        /**
         * ApplyCampaign method : Takes product price, calculates and returns product discounted price.
         * @param double price : Product price.
         * @return double discountedPrice : Product discounted price.
         */
        public double ApplyCampaign(double price)
        {
            return (price * ((100 - DISCOUNT_RATE) / 100));
        }
    }

    /**
     * class SpecialDay : Implements ICampaign interface.
     */
    public class SpecialDay : ICampaign
    {
        /**
         * double DISCOUNT_RATE : Product discount rate.
         */
        public const double DISCOUNT_RATE = 20;

        /**
         * ApplyCampaign method : Takes product price, calculates and returns product discounted price.
         * @param double price : Product price.
         * @return double discountedPrice : Product discounted price.
         */
        public double ApplyCampaign(double price)
        {
            return (price * ((100 - DISCOUNT_RATE) / 100));
        }
    }

    /**
     * class BlackFriday : Implements ICampaign interface.
     */
    public class BlackFriday : ICampaign
    {
        /**
         * double DISCOUNT_RATE : Product discount rate.
         */
        public const double DISCOUNT_RATE = 13;

        /**
         * ApplyCampaign method : Takes product price, calculates and returns product discounted price.
         * @param double price : Product price.
         * @return double discountedPrice : Product discounted price.
         */
        public double ApplyCampaign(double price)
        {
            return (price * ((100 - DISCOUNT_RATE) / 100));
        }
    }
}