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
    internal class MainDL
    {
        public static int GetIdFromTableUsingString(string valueToGet, string table, string columnName, string value)
        {
            int id = -1;
            Program.connection.Open();
         
            string query = $"SELECT {valueToGet} FROM {table} WHERE {columnName} = {value}";
            
            var cmdForId = new SqlCommand(query, Program.connection);
            var reader = cmdForId.ExecuteReader();
            
            while (reader.Read()) {
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


            while (reader.Read()) {
                id = reader.GetInt32(0);
            }
            Program.connection.Close();

            return id;
        }
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
        public static void TextBoxEmptyError()
        {
            MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static int getId(DataGridView dataGrid)
        {
            // as id is always the first column
            return Convert.ToInt32(dataGrid.SelectedRows[0].Cells[0].Value);
        }
    }
}
