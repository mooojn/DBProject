using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBProject
{
    internal class QueryDL
    {
        public static void DeleteFromTable(string table, string columnName, int idToDelete)
        {
            Program.connection.Open();

            string query = $"DELETE FROM {table} WHERE {columnName} = {idToDelete}";

            SqlCommand cmd = new SqlCommand(query, Program.connection);
            cmd.ExecuteNonQuery();

            Program.connection.Close();
        }
        public static int GetIdFromTableUsingString(string valueToGet, string table, string columnName, string value)
        {
            int id = -1;
            Program.connection.Open();

            string query = $"SELECT {valueToGet} FROM {table} WHERE {columnName} = '{value}'";

            var cmdForId = new SqlCommand(query, Program.connection);
            var reader = cmdForId.ExecuteReader();

            while (reader.Read())
            {
                id = reader.GetInt32(0);
            }
            Program.connection.Close();
            return id;

        }
        public static int GetIdFromTable(string valueToGet, string table)
        {
            int id = -1;

            Program.connection.Open();
            string query = $"SELECT {valueToGet} FROM {table}";

            SqlCommand cmd = new SqlCommand(query, Program.connection);
            SqlDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {
                id = reader.GetInt32(0);
            }
            Program.connection.Close();

            return id;
        }
        public static void LoadComboBox(ComboBox box, string field, string table)
        {
            box.Items.Clear();
            Program.connection.Open();
            string query = $"SELECT {field} FROM {table}";
            SqlCommand command = new SqlCommand(query, Program.connection);
            SqlDataReader data = command.ExecuteReader();
            while (data.Read())
            {
                box.Items.Add(data[0]);
            }
            Program.connection.Close();
        }
    }
}
