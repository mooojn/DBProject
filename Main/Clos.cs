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
    public partial class Clos : Form
    {
        public Clos()
        {
            InitializeComponent();
        }

        private void Clos_Load(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Hide();
            panel3.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Program.connection.Open();
            string query = "INSERT INTO CLO VALUES (@Name, @DateCreated, @DateCreated)";   // 3rd val for DateUpdated
            
            SqlCommand cmd = new SqlCommand(query, Program.connection);
            cmd.Parameters.AddWithValue("@Name", textBox1.Text);
            cmd.Parameters.AddWithValue("@DateCreated", DateTime.Now);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Data has been inserted");
            Program.connection.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Show();
            panel2.Hide();
            panel3.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Show();
            panel1.Hide();
            panel3.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Program.connection.Open();
            string query = "UPDATE CLO SET Name = @NewName," +
                "DateUpdated = @NewTime WHERE Name = @OldName";  

            SqlCommand cmd = new SqlCommand(query, Program.connection);
            cmd.Parameters.AddWithValue("@OldName", textBox2.Text);
            cmd.Parameters.AddWithValue("@NewName", textBox3.Text);
            cmd.Parameters.AddWithValue("@NewTime", DateTime.Now);
            int changes = cmd.ExecuteNonQuery();

            if (changes>0)
                MessageBox.Show("Data has been updated");
            else
                MessageBox.Show("Data not found");
            Program.connection.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel3.Show();
            panel1.Hide();
            panel2.Hide();

            Program.connection.Open();
            string query = "SELECT Name, DateUpdated FROM CLO";
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

    }
}
