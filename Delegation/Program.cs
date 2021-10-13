using System;
using System.Collections.Generic;

namespace Delegation
{
    class Program
    {
        static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        static void Main(string[] args)
        {
            var evenNumbers = filter(numbers);
            show(evenNumbers);
        }
        static void show(int[] array)
        {
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
        static int[] filter(int[] array)
        {
            List<int> result = new List<int>();

            foreach (var item in array)
            {
                if (item % 2 == 0)
                {
                    result.Add(item);
                }
            }

            return result.ToArray();
        }
    }
}
