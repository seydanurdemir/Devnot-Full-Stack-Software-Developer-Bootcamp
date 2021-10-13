using System;

namespace Polymorphism
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
            asci.SunumYap(pirasa);

            InegolKofte inegolKofte = new InegolKofte();
            inegolKofte.Sure = 40;
            inegolKofte.PismeBicimi = PismeBicimi.Orta;
            asci.Pisir(inegolKofte);
            Console.WriteLine($"{inegolKofte.PismeBicimi} pismis olsun.");
            asci.SunumYap(inegolKofte);

            Baklava baklava = new Baklava();
            baklava.Sure = 10;
            asci.Pisir(baklava);
            asci.SunumYap(baklava);
        }
    }
}
