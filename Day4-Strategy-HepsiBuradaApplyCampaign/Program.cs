// Import used namespaces.
using System;

/**
 * namespace Day4_Strategy_HepsiBuradaCalculatePrice : Covers exercise of fourth day.
 */
namespace Day4_Strategy_HepsiBuradaCalculatePrice
{
    /**
     * class Program : Implements driver method of the project.
     */
    public class Program
    {
        /**
         * Main method : Implements main method of the project.
         * @param string[] args : Command line arguments.
         */
        static void Main(string[] args)
        {
            Test testCampaigns = new Test();
            ICampaign campaign = new BirthDay();
            ICoupon coupon = new FiftyTL();
            testCampaigns.TestCampaigns(campaign, coupon);
        }
    }
}
