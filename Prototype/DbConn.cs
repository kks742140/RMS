using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Prototype
{
    class DbConn
    {
        public static MySqlConnection getConn()
        {
            MySqlConnection conn;
            const string myConnectionString = "server=127.0.0.1;uid=root;database=fypdb;Convert Zero Datetime=True";
            conn = new MySqlConnection(myConnectionString);
            return conn;
        }
    }
}
