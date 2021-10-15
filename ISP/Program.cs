using System;

namespace ISP
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4 SOL[I]D > I > ISP > Interface Segregation Principle

            /**
             * İşlevlerine göre fonksiyonlar, farklı arayüzlere sahip olmalıdır.
             * Eğer bir fonksiyon, interface'ten implement edildiği halde kullanılmıyorsa,
             * bu prensibi ihlal ediyorsunuz.
             */
        }
    }

    // HATA : Her sey tek bir yerde, bunları ilgili yerlere göre ayırmalıyız

    //public interface IMessage
    //{
    //    public string From { get; set; }
    //    public string To { get; set; }
    //    public string Subject { get; set; }
    //    public string Body { get; set; }
    //    public string VideoFormat { get; set; }
    //    public int Duration { get; set; }
    //    public int Width { get; set; }
    //    public int Height { get; set; }
    //    public string AudioFormat { get; set; }
    //}

    // DÜZELTME : Her şeyi ayırdık

    public interface IMessage
    {
        public string From { get; set; }
        public string To { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }

    public interface IVideoMessage : IMessage
    {
        public string VideoFormat { get; set; }
        public int Duration { get; set; }
    }

    public interface IAudioMessage : IMessage
    {
        public string AudioFormat { get; set; }
    }

    public interface IImageMessage : IMessage
    {
        public int Width { get; set; }
        public int Height { get; set; }
    }

    public class TextMessage : IMessage
    {
        public string From { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string To { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Subject { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Body { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        // DÜZELTME : Bunları gereksiz yere implement etmiyoruz

        //public string VideoFormat { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        //public int Duration { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        //public int Width { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        //public int Height { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        //public string AudioFormat { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

    // BAKINIZ : IVideoMessage için gerekli metotlar implement edildi IMessage dahil

    public class K4VideoMessage : IVideoMessage
    {
        public string VideoFormat { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Duration { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string From { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string To { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Subject { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Body { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
