using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

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
        public static void GridViewSelect(string query, string table, DataGrid dataGrid)
        {
            string CmdString = query;
            OleDbDataAdapter sda = new OleDbDataAdapter(CmdString, ConfigurationManager.ConnectionStrings["Connection"].ToString());
            DataTable dt = new DataTable(table);
            sda.Fill(dt);
            dataGrid.ItemsSource = dt.DefaultView;
         
        }
        public static string ReadData(string queryString)
        {
            using (OleDbConnection connection = new OleDbConnection(ConfigurationManager.ConnectionStrings["Connection"].ToString()))
            {
                OleDbCommand command = new OleDbCommand(queryString, connection);

                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    return reader[0].ToString();
                }
                reader.Close();
            }
            return null;
        }


    }
}
