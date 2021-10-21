/**
 * namespace Day4_Strategy_HepsiBuradaCalculatePrice : Covers exercise of fourth day.
 */
namespace Day4_Strategy_HepsiBuradaCalculatePrice
{
    /**
     * interface ICampaign : Defines prototype/signature of ApplyCampaign method.
     */
    public interface ICampaign
    {
        /**
         * ApplyCampaign method : Takes product price, calculates and returns product discounted price.
         * @param double price : Product price.
         * @return double discountedPrice : Product discounted price.
         */
        public double ApplyCampaign(double price);
    }
}