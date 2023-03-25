using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace uchettt
{
    class DBUtils
    {
        public static MySqlConnection GetDBConnection()
        {
            string host = "194.67.68.221";
            int port = 3306;
            string database = "grocery_store";
            string user = "igor";
            string password = "13q24w35E46R__";
            return DBMySQLUtils.GetDBConnection(host, port, database, user, password);
        }
    }
}
