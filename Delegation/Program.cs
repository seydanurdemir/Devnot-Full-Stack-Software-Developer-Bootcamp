using System;
using System.Collections.Generic;
using System.Linq;

namespace Delegation
{
    class Program
    {
        static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        static void Main(string[] args)
        {
            // .NET 1.0

            //Console.WriteLine("Even Numbers");
            //var evenNumbers = Filter.FilterNumbers(numbers, getEvenNumbers);
            //show(evenNumbers);
            //Console.WriteLine("Odd Numbers");
            //var oddNumbers = Filter.FilterNumbers(numbers, getOddNumbers);
            //show(oddNumbers);
            //Console.WriteLine("Numbers Bigger Than Five");
            //var numbersBiggerThanFive = Filter.FilterNumbers(numbers, getNumbersBiggerThanFive);
            //show(numbersBiggerThanFive);

            // .NET 2.0 // lambda
            Console.WriteLine("Multiply Three");
            var multiplyThree = Filter.FilterNumbers(numbers, delegate (int x) { return x % 3 == 0; });
            show(multiplyThree);

            // .NET 3.0 // lambda
            Console.WriteLine("Multiply Five");
            var multiplyFive = Filter.FilterNumbers(numbers, q => q % 5 == 0 );
            //show(multiplyFive);
            alternativeShow(multiplyFive);
        }

        static void show(int[] array)
        {
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }

        static void alternativeShow(int[] array)
        {
            // .NET 4.0 Action
            array.ToList().ForEach( x => Console.WriteLine(x) );
        }

        static bool getEvenNumbers(int value)
        {
            return value % 2 == 0;
        }

        static bool getOddNumbers(int value)
        {
            return value % 2 == 1;
        }

        static bool getNumbersBiggerThanFive(int value)
        {
            return value > 5;
        }
    }
}
