using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SRP
{
    class Program
    {
        // 1 [S]OLID > S > SRP > Single Responsibility Principle
        static void Main(string[] args)
        {
            /**
             * Bir sınıfı değiştirmek için birden fazla sebebe ihtiyaç duyuyorsanız,
             * bu prensibi ihlal ediyorsunuz demektir.
             * Her sınıf ve her metot sadece bir işten sorumludur.
             */

            // STEP 1 : ihlal eden kod

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

            // STEP 4 : her işi ayır

            Console.WriteLine("Urun Adi :");
            string name = Console.ReadLine();
            
            int affectedRow = new ProductBusiness().AddProduct(name);
            
            string result = affectedRow > 0 ? "Kayit Basarili" : "Kayit Basarisiz";
            Console.WriteLine(result);
        }

        // STEP 2 : fonksiyonlaştır

        //private static string AddProduct(string name)
        //{
        //    SqlConnection sqlConnection = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=NewStoreDB;Integrated Security=True");
        //    SqlCommand sqlCommand = new SqlCommand("INSERT into Products (Name) values (@name)", sqlConnection);
        //    sqlCommand.Parameters.AddWithValue("@name", name);

        //    sqlConnection.Open();
        //    var affectedRow = sqlCommand.ExecuteNonQuery();
        //    sqlConnection.Close();

        //    string result = affectedRow > 0 ? "Kayit Basarili" : "Kayit Basarisiz";

        //    return result;
        //}

        // STEP 3 : tamamen böl

        //private static string AddProduct(string name)
        //{
        //    string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=NewStoreDB;Integrated Security=True";
        //    string commandText = "INSERT into Products (Name) values (@name)";
        //    Dictionary<string, object> parameters = new Dictionary<string, object>();
        //    parameters.Add("@name", name);

        //    DBHelper dBHelper = new DBHelper(connectionString);
        //    var affectedRow = dBHelper.Execute(commandText, parameters);

        //    return affectedRow > 0 ? "Kayit Basarili" : "Kayit Basarisiz";
        //}
    }
}
