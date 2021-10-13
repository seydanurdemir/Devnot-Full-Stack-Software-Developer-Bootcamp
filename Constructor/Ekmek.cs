using System;
using System.Collections.Generic;
using System.Text;

namespace Constructor
{
    class Ekmek
    {
        public string Tur { get; set; }
        public int Adet { get; set; }
        public Ekmek() : this(1,"Beyaz Ekmek") // References to last constructor using this keyword
        {
            //Adet = 1;
            //Tur = "Beyaz Ekmek";
        }

        public Ekmek(int adet) : this(adet, "Beyaz Ekmek")
        {
            //Adet = adet;
            //Tur = "Beyaz Ekmek";
        }
        public Ekmek(string tur) : this(1, tur)
        {
            //Adet = 1;
            //Tur = tur;
        }
        public Ekmek(int adet, string tur)
        {
            Adet = adet;
            Tur = tur;
        }
    }
}
