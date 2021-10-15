using System;

namespace OCP
{
    class Program
    {
        // 2 S[O]LID > O > OCP > Open Closed Principle
        static void Main(string[] args)
        {
            /**
             * Bir nesne gelişime AÇIK değişime KAPALI olmalıdır.
             * Bir nesnenin davranışını değiştirmek için o nesneye kod yazıyorsanız,
             * prensibi ihlal ediyorsunuz.
             */

            // HATA 1 : yeni bir kart tipi gelince, örneğin yılbaşı kartı, hediye kartı vb.,
            // tekrar değişmem gerekecek, buraya ekleme yapmam gerekecek, sıkıntı

            //OrderManager orderManager = new OrderManager {  Customer = new Customer { Name = "A", Card = CardType.Gold} };

            // DÜZELTME 1 : Artık rahatça kartı ekleyip çalıştırabilirim

            OrderManager orderManager = new OrderManager { Customer = new Customer { Name = "A", Card = new PremiumCard() } };
            Console.WriteLine(orderManager.GetTotalPrice(1000));
        }

        // HATA 1 : yeni bir kart tipi gelince, örneğin yılbaşı kartı, hediye kartı vb.,
        // tekrar değişmem gerekecek, buraya ekleme yapmam gerekecek, sıkıntı

        //public enum CardType
        //{
        //    Standart,
        //    Silver,
        //    Gold
        //}

        // DÜZELTME 1 : Artık rahatça kartı ekleyip çalıştırabilirim

        public abstract class CardType
        {
            public abstract double GetDiscountedPrice(double price);
        }

        public class StandartCard : CardType
        {
            public override double GetDiscountedPrice(double price)
            {
                return price * 0.95;
            }
        }

        public class SilverCard : CardType
        {
            public override double GetDiscountedPrice(double price)
            {
                return price * 0.90;
            }
        }

        public class GoldCard : CardType
        {
            public override double GetDiscountedPrice(double price)
            {
                return price * 0.85;
            }
        }

        public class PremiumCard : CardType
        {
            public override double GetDiscountedPrice(double price)
            {
                return price * 0.80;
            }
        }

        public class Customer
        {
            public string Name { get; set; }
            public CardType Card { get; set; }
        }

        public class OrderManager
        {
            public Customer Customer { get; set; }
            public double GetTotalPrice(double total)
            {
                // HATA 1 : yeni bir kart tipi gelince, örneğin yılbaşı kartı, hediye kartı vb.,
                // tekrar değişmem gerekecek, buraya ekleme yapmam gerekecek, sıkıntı

                //switch (Customer.Card)
                //{
                //    case CardType.Standart:
                //        return total * 0.95;
                //    case CardType.Silver:
                //        return total * 0.90;
                //    case CardType.Gold:
                //        return total * 0.85;
                //    default:
                //        return total;
                //}
                
                // DÜZELTME 1 : Artık rahatça kartı ekleyip çalıştırabilirim

                return Customer.Card.GetDiscountedPrice(total);
            }
        }
    }
}
