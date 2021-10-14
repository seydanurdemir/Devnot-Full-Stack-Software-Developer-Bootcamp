using System;
using System.Collections.Generic;
using System.Text;

namespace Delegation
{
    public static class Filter
    {
        //public delegate bool criteia(int value);
        //public static int[] FilterNumbers(int[] array, criteia criteriaFunction)
        
        // .NET 4.0 Func
        public static int[] FilterNumbers(int[] array, Func<int, bool> criteriaFunction)
        {
            List<int> result = new List<int>();

            foreach (var item in array)
            {
                if (criteriaFunction(item))
                {
                    result.Add(item);
                }
            }

            return result.ToArray();
        }
    }
}
