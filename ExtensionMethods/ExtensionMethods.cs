using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethods
{
    public static class ExtensionMethods
    {
        // Extended method, static and this keywords

        public static double GetSquare(this int number)
        {
            return Math.Pow(number, 2);
        }

        public static string RemoveAllSpaces(this string value)
        {
            return value.Replace(" ", string.Empty);
        }

        //public static int GetTotalWorkDays (this DateTime dateTime, DateTime[] vacations)
        //{
        //    return 0;
        //}
    }
}
