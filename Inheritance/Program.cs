using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Asci asci = new Asci();

            Pirasa pirasa = new Pirasa();
            pirasa.Sure = 20;
            pirasa.ZeytinYagliMi = true;
            asci.Pisir(pirasa);
            Console.WriteLine(pirasa.ZeytinYagliMi ? "Zeytin yağlı olsun." : "Zeytin yağlı olmasın.");

            InegolKofte inegolKofte = new InegolKofte();
            inegolKofte.Sure = 40;
            inegolKofte.PismeBicimi = PismeBicimi.Orta;
            asci.Pisir(inegolKofte);
            Console.WriteLine($"{inegolKofte.PismeBicimi} pismis olsun.");
        }
    }
}
