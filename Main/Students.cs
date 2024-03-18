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
    public partial class Students : Form
    {
        public Students()
        {
            InitializeComponent();
        }

        private void Students_Load(object sender, EventArgs e)
        {
            addStudentPanel.Hide();
            dataGridView1.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            addStudentPanel.Show();
            dataGridView1.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Program.connection.Open();

            string query = "INSERT INTO Student VALUES (@f_Name, @L_Name, @Contact, @Email, @RegNo, 1)";

            SqlCommand cmd = new SqlCommand(query, Program.connection);

            cmd.Parameters.AddWithValue("@f_Name", textBox1.Text);
            cmd.Parameters.AddWithValue("@L_Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@Contact", textBox3.Text);
            cmd.Parameters.AddWithValue("@Email", textBox4.Text);
            cmd.Parameters.AddWithValue("@RegNo", Program.RegNo);
            Program.RegNo++;

            cmd.ExecuteNonQuery();

            Program.connection.Close();
            MessageBox.Show("Data has been inserted");
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            addStudentPanel.Hide();
            dataGridView1.Show();
            Program.connection.Open();
            string query = "SELECT RegistrationNumber AS RegNo," +
                "CONCAT(FirstName, ' ' , LastName) AS FullName," +
                "Contact FROM Student";
            SqlDataAdapter sda = new SqlDataAdapter(query, Program.connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            dataGridView1.DataSource = dt;

            Program.connection.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
