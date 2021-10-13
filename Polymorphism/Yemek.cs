using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class Yemek
    {
        public int Sure { get; set; }
        public void Pisir()
        {
            Console.WriteLine($"{ this.GetType().Name } yemegi { this.Sure } dakika icerisinde hazir olacak.");
        }
        public virtual void SunumYap()
        {
            Console.WriteLine("Yaninda pilav :)");
        }
    }
    public class SebzeYemek : Yemek
    {
        public bool ZeytinYagliMi { get; set; }
    }
    public class Pirasa : SebzeYemek
    {

    }
    public enum PismeBicimi
    {
        Az, Orta, Cok
    }
    public class EtYemek : Yemek
    {
        public PismeBicimi PismeBicimi { get; set; }
    }
    public class KofteYemekleri : EtYemek
    {

    }
    public class InegolKofte : KofteYemekleri
    {

    }
    public class Tatli : Yemek
    {

    }
    public class Baklava : Tatli
    {
        public override void SunumYap()
        {
            Console.WriteLine("Yaninda baklava abi yaaa :)");
        }
    }
}
