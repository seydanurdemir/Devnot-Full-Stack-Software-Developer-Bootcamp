/**
 * namespace Exercise1_Strategy_HepsiBuradaCalculatePrice : Covers exercise of fourth day.
 */
namespace Exercise1_Strategy_HepsiBuradaCalculatePrice
{
    /**
     * class CalculatePrice : Calculates product price.
     */
    public class CalculatePrice
    {
        /**
         * CalculateDiscountedPrice method : Takes price and campaign, applies campaign, calculates discounted price and returns.
         * @param double price : Product price.
         * @param ICampaign campaign : Campaign.
         * @return double discountedPrice : Product discounted price.
         */
        public double CalculateDiscountedPrice(double price, ICampaign campaign)
        {
            return (campaign.ApplyCampaign(price));
        }

        /**
         * CalculateLastPrice method : Takes discounted price and coupon, applies coupon, calculates last price and returns.
         * @param double discountedPrice : Product discounted price.
         * @param ICoupon coupon : Coupon.
         * @return double lastPrice : Product last price.
         */
        public double CalculateLastPrice(double discountedPrice, ICoupon coupon)
        {
            return (coupon.ApplyCoupon(discountedPrice));
        }
    }
}