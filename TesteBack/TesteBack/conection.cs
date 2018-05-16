using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TesteBack
{
    class conection
    {
        string server = "127.0.0.1";
        string database = "bank";
        string root = "root";
        string key = "";

       public MySqlConnection connection;

        public void connect()
        {
           
            string way = "SERVER=" + server + ";Database=" + database + ";UID=" + root + ";PASSWORD=" + key + ";SSL MODE = NONE";
            
            try
            {
                connection = new MySqlConnection(way);
                connection.Open();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void disconnect()
        {
            connection.Close();
        }

       

    }
}
