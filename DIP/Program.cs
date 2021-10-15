using System;

namespace DIP
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5 SOLI[D] > D > DIP > Dependency Inversion Principle

            /**
             * Bağımlılıklar şöyle olmalı : küçük sistemler, büyük sistemlere bağımlı olmalı.
             */

            // Constructor injection
            ReportGenerator reportGenerator = new ReportGenerator(new DBDataSource());
            
            // Method injection
            reportGenerator.Send(new MailSender());
            reportGenerator.Send(new WhatsAppSender());
            reportGenerator.Send(new TelegramSender());

            // Property injection
            reportGenerator.Format = new PDFFormat();
            reportGenerator.Format = new PowerPointFormat();
        }
    }

    public class ReportGenerator
    {
        public IDataSource dataSource { get; set; }

        public IFormat Format { get; set; }

        public ReportGenerator(IDataSource dataSource)
        {
            this.dataSource = dataSource;
        }

        // HATA : ReportGenerator.Send MailSender.Send'e bağımlı kaldı

        //public void Send()
        //{
        //    MailSender mailSender = new MailSender();
        //    mailSender.Send();
        //}

        // DÜZELTME : Dışarıdan vererek bağımsızlaştırdık
        // HATA : Tightly coupled

        public void Send(ISender mailSender)
        {
            mailSender.Send();
        }

        public void GetData() { }

        public void TransformData() { }
    }

    public interface IDataSource
    {

    }

    public class DBDataSource : IDataSource
    {
        
    }

    public interface IFormat
    {

    }

    public class PDFFormat : IFormat
    {

    }

    public class PowerPointFormat : IFormat
    {

    }

    // DÜZELTME : Loosely coupled

    public interface ISender
    {
        public void Send();
    }

    public class MailSender : ISender
    {
        public void Send()
        {
            Console.WriteLine("Mail gönderildi");
        }
    }

    public class WhatsAppSender : ISender
    {
        public void Send()
        {
            Console.WriteLine("WS mesajı gönderildi");
        }
    }

    public class TelegramSender : ISender
    {
        public void Send()
        {
            Console.WriteLine("Telegram mesajı gönderildi");
        }
    }
}
