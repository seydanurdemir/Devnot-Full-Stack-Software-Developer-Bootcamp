using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class DBHelper
    {
        // STEP 3 : tamamen böl

        SqlConnection sqlConnection;

        public DBHelper(string connectionString)
        {
            sqlConnection = new SqlConnection(connectionString);
        }

        public int Execute(string commandText, Dictionary<string, object> parameters)
        {
            SqlCommand sqlCommand = CreateCommand(commandText, parameters);
            sqlCommand.Connection.Open();
            int rowCount = sqlCommand.ExecuteNonQuery();
            sqlCommand.Connection.Close();
            return rowCount;
        }

        public SqlCommand CreateCommand(string commandText, Dictionary<string, object> parameters)
        {
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = commandText;
            AddParametersToCommand(sqlCommand, parameters);
            return sqlCommand;
        }

        public void AddParametersToCommand(SqlCommand sqlCommand, Dictionary<string, object> parameters)
        {
            foreach (var item in parameters)
            {
                sqlCommand.Parameters.AddWithValue(item.Key, item.Value);
            }
        }
    }
}
