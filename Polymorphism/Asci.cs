using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class Asci
    {
        public void Pisir(Yemek yemek)
        {
            yemek.Pisir();
        }
        public void SunumYap(Yemek yemek)
        {
            yemek.SunumYap();
        }
    }
}
