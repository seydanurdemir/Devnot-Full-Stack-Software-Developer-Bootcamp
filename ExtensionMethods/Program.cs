using System;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 8;
            var value1 = x.GetSquare();
            Console.WriteLine(value1);

            string y = "Devnot CSharp Bootcamp";
            var value2 = y.RemoveAllSpaces();
            Console.WriteLine(value2);

            //int z = DateTime.Now.GetTotalWorkDays(new DateTime[] { });
            //Console.WriteLine(z);

            var result = new Test().Random?.Next(1, 100);
            Console.WriteLine(result);
        }
    }
    public class Test
    {
        public Random Random { get; set; }
    }
}
