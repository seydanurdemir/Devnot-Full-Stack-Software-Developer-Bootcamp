/**
 * namespace Day4_Strategy_HepsiBuradaCalculatePrice : Covers exercise of fourth day.
 */
namespace Day4_Strategy_HepsiBuradaCalculatePrice
{
    /**
     * interface ICoupon : Defines prototype/signature of ApplyCoupon method.
     */
    public interface ICoupon
    {
        /**
         * ApplyCoupon method : Takes product discounted price, calculates and returns product last price.
         * @param double discountedPrice : Product discounted price.
         * @return double lastPrice : Product last price.
         */
        public double ApplyCoupon(double discountedPrice);
    }
}