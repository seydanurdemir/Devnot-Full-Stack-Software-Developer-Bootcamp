// Import used namespaces.
using System;

/**
* namespace Day4_Strategy_HepsiBuradaCalculatePrice : Covers exercise of fourth day.
*/
namespace Day4_Strategy_HepsiBuradaCalculatePrice
{
    /**
     * class Product : Keeps product informations.
     */
    public class Product
    {
        /**
         * string Name : Product name.
         */
        public string Name { get; set; }

        /**
         * double Price : Product price.
         */
        public double Price { get; set; }
        
        /**
         * Overrided ToString method.
         * @return string productString : Product string.
         */
        public override string ToString()
        {
            return (this.Name + " " + String.Format("{0:0.00}", this.Price));
        }
    }
}