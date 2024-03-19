using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net;

namespace DBProject
{
    public partial class Clo : Form
    {
        public Clo()
        {
            InitializeComponent();
            loadData();
        }
        private void loadData()
        {
            Program.connection.Open();
            string query = "SELECT * FROM CLO";
            SqlDataAdapter sda = new SqlDataAdapter(query, Program.connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            // Converting date+time from dateUpdated coloumn to date only
            dt.AsEnumerable().ToList().ForEach(row =>
            {
                if (row["DateUpdated"] != DBNull.Value)
                {
                    row["DateUpdated"] = ((DateTime)row["DateUpdated"]).ToShortDateString();
                }
            });

            dataGridView1.DataSource = dt;
            Program.connection.Close();
        }
        private void Clos_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.connection.Open();
            string query = "INSERT INTO CLO VALUES (@Name, @DateCreated, @DateCreated)";   // 3rd val for DateUpdated

            SqlCommand cmd = new SqlCommand(query, Program.connection);
            cmd.Parameters.AddWithValue("@Name", textBox1.Text);
            cmd.Parameters.AddWithValue("@DateCreated", DateTime.Now);
            cmd.ExecuteNonQuery();

            Program.connection.Close();
            loadData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }


        

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var row = dataGridView1.SelectedRows[0].DataBoundItem;
            textBox1.Text = ((DataRowView)row).Row.ItemArray[1].ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Program.connection.Open();
            string name = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();


            string query = "UPDATE CLO SET Name = @NewName," +
                "DateUpdated = @NewTime WHERE Name = @OldName";

            SqlCommand cmd = new SqlCommand(query, Program.connection);
            cmd.Parameters.AddWithValue("@OldName", name);
            cmd.Parameters.AddWithValue("@NewName", textBox1.Text);
            cmd.Parameters.AddWithValue("@NewTime", DateTime.Now);
            int changes = cmd.ExecuteNonQuery();

            if (changes > 0)
                MessageBox.Show("Data has been updated");
            else
                MessageBox.Show("Data not found");
            Program.connection.Close();
            loadData();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            Program.connection.Open();
            string query = "DELETE FROM CLO WHERE Id = @id";
            SqlCommand cmd = new SqlCommand(query, Program.connection);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            Program.connection.Close();
            loadData();

        }
    }
}
