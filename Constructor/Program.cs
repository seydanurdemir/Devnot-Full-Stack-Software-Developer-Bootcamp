using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Ekmek ekmek1 = new Ekmek();
            Ekmek ekmek2 = new Ekmek(3);
            Ekmek ekmek3 = new Ekmek("Tam Bugdayli Ekmek");
            Ekmek ekmek4 = new Ekmek(5, "Kepekli Ekmek");
            Ekmek ekmek5 = new Ekmek { Adet = 1, Tur = "Beyaz Ekmek" };
        }
    }
}
