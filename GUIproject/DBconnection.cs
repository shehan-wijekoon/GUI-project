using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace GUIproject
{
    internal class DBconnection
    {
        public MySqlConnection getcon() {

            string connection_string = "server=127.0.0.1 ;Database=guiproject;User ID=root;Password=;    ";
            MySqlConnection con = new MySqlConnection(connection_string);

            return con;
        }
        
    }
}
