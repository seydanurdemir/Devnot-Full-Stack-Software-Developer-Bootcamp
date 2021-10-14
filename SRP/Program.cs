using System;
using System.Data.SqlClient;

namespace SRP
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * Bir sınıfı değiştirmek için birden fazla sebebe ihtiyaç duyuyorsanız,
             * bu prensibi ihlal ediyorsunuz demektir.
             * Her sınıf ve her metot sadece bir işten sorumludur.
             */

            // ihlal eden kod :

            //Console.WriteLine("Urun Adi :");
            //string name = Console.ReadLine();

            //SqlConnection sqlConnection = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=NewStoreDB;Integrated Security=True");
            //SqlCommand sqlCommand = new SqlCommand("INSERT into Products (Name) values (@name)", sqlConnection);
            //sqlCommand.Parameters.AddWithValue("@name", name);
            
            //sqlConnection.Open();
            //var affectedRow = sqlCommand.ExecuteNonQuery();
            //sqlConnection.Close();
            
            //string result = affectedRow > 0 ? "Kayit Basarili" : "Kayit Basarisiz";
            //Console.WriteLine(result);

            Console.WriteLine("Urun Adi :");
            string name = Console.ReadLine();
            string result = AddProduct(name);
            Console.WriteLine(result);
        }

        private static string AddProduct(string name)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=NewStoreDB;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("INSERT into Products (Name) values (@name)", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@name", name);

            sqlConnection.Open();
            var affectedRow = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

            string result = affectedRow > 0 ? "Kayit Basarili" : "Kayit Basarisiz";

            return result;
        }
    }
}
