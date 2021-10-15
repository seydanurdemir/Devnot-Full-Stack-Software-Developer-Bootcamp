using System;

namespace LSP
{
    class Program
    {
        static void Main(string[] args)
        {

            // 3 SO[L]ID > L > LSP > Liskov (BARBARA) Substitution Principle

            // Miras Kaosu

            var rectangle = GetRectangle();
            //rectangle.Width = 20;
            //rectangle.Height = 15;
            Console.WriteLine(rectangle.GetArea());
        }

        // HATA : Her miras doğru değil, burada interface kullanacağız

        //static Rectangle GetRectangle()
        //{
        //    return new Square();
        //}

        // DÜZELTME : Miras yerine arayüz kullanacağız

        static ICalculateArea GetRectangle()
        {
            return new Square();
        }
    }

    // DÜZELTME : Miras yerine arayüz kullanacağız

    public interface ICalculateArea
    {
        public int GetArea();
    }

    // DÜZELTME : Miras yerine arayüz kullanacağız

    public class Rectangle : ICalculateArea
    {
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }
        public int GetArea()
        {
            return Width * Height;
        }
    }

    // HATA : Her miras doğru değil, burada interface kullanacağız

    //public class Square : Rectangle
    //{
    //    public override int Width
    //    { 
    //        get => base.Width;
    //        set
    //        { 
    //            base.Width = value;
    //            base.Height = value;
    //        } 
    //    }
    //    public override int Height
    //    { 
    //        get => base.Height;
    //        set
    //        {
    //            base.Height = value;
    //            base.Width = value;
    //        }
    //    }
    //}

    public class Square : ICalculateArea
    {
        public int Width { get; set; }

        public int GetArea()
        {
            return Width * Width;
        }
    }
}
