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

namespace DBProject
{
    public partial class Assesment : Form
    {
        public Assesment()
        {
            InitializeComponent();
        }

        private void Assesment_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.connection.Open();
            string query = "INSERT INTO Assessment values" +
                "(@Title, @DateCreated, @TotalMarks, @TotalWeightage)";
            SqlCommand command = new SqlCommand(query, Program.connection);
            command.Parameters.AddWithValue("@Title", textBox1.Text);    
            command.Parameters.AddWithValue("@DateCreated", DateTime.Now);
            command.Parameters.AddWithValue("@TotalMarks", textBox2.Text);
            command.Parameters.AddWithValue("@TotalWeightage", textBox3.Text);
            command.ExecuteNonQuery();
            Program.connection.Close();
            
            loadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
            int id = Convert.ToInt32(selectedRow.Cells[0].Value);   

            Program.connection.Open();
            string query = "UPDATE Assessment SET Title = @Title, TotalMarks = @TotalMarks," +
                " TotalWeightage = @TotalWeightage " +
                "WHERE Id = @Id";
            
            SqlCommand command = new SqlCommand(query, Program.connection);
            command.Parameters.AddWithValue("@Id", id);
            command.Parameters.AddWithValue("@Title", textBox1.Text);
            command.Parameters.AddWithValue("@TotalMarks", textBox2.Text);    
            command.Parameters.AddWithValue("@TotalWeightage", textBox3.Text);
            command.ExecuteNonQuery();
            
            Program.connection.Close();
            loadData();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dataGridView1.SelectedRows[0];
            textBox1.Text = row.Cells[1].Value.ToString();
            textBox2.Text = row.Cells[3].Value.ToString();
            textBox3.Text = row.Cells[4].Value.ToString();
        }
        private void loadData()
        {
            Program.connection.Open();
            string query = "SELECT * FROM Assessment";
            SqlDataAdapter adapter = new SqlDataAdapter(query, Program.connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            Program.connection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            Program.connection.Open();
            string query = "DELETE FROM Assessment WHERE Id = @Id";
            SqlCommand command = new SqlCommand(query, Program.connection);
            command.Parameters.AddWithValue("@Id", id);
            command.ExecuteNonQuery();
            Program.connection.Close();
            loadData();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            AssesmentComponent form = new AssesmentComponent();
            form.Show();
        }
    }
}
