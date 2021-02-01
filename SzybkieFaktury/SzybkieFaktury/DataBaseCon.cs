using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzybkieFaktury
{
    class DataBaseCon
    {


        public static void Query (string query)
        {
            OleDbConnection con = new OleDbConnection(ConfigurationManager.ConnectionStrings["Connection"].ToString());
            OleDbCommand cmd = con.CreateCommand();
            con.Open();
            cmd.CommandText = query;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        
    }
}
