using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace DBProject
{
    internal class StdDL
    {
        
        public static void DeleteFromTable(string table, string columnName, int idToDelete)
        {
            Program.connection.Open();  

            string query = $"DELETE FROM {table} WHERE {columnName} = {idToDelete}";

            SqlCommand cmd = new SqlCommand(query, Program.connection);
            cmd.ExecuteNonQuery();

            Program.connection.Close();
        }
        public static void LoadData(DataGridView dataGridView, string table)
        {
            Program.connection.Open();

            string query = $"SELECT * FROM {table}";
            SqlDataAdapter sda = new SqlDataAdapter(query, Program.connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView.DataSource = dt;

            Program.connection.Close();
        }
    }
}
