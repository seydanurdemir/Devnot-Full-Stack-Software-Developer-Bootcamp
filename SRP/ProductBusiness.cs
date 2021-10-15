using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class ProductBusiness
    {
        // STEP 4 : her işi ayır
        public int AddProduct(string name)
        {
            string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=NewStoreDB;Integrated Security=True";
            string commandText = "INSERT into Products (Name) values (@name)";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@name", name);

            DBHelper dBHelper = new DBHelper(connectionString);
            var affectedRow = dBHelper.Execute(commandText, parameters);

            return affectedRow;
        }
    }
}
