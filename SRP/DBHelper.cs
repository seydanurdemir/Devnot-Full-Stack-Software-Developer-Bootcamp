using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class DBHelper
    {
        SqlConnection sqlConnection;

        public DBHelper(string connectionString)
        {
            new SqlConnection(connectionString);
        }
    }
}
