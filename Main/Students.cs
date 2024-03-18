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
            loadData();   
        }
        private void loadData()
        {
            Program.connection.Open();
            string query = "SELECT * FROM Student";
            SqlDataAdapter sda = new SqlDataAdapter(query, Program.connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            Program.connection.Close();
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
            cmd.Parameters.AddWithValue("@RegNo", textBox5.Text);

            cmd.ExecuteNonQuery();

            Program.connection.Close();
            //MessageBox.Show("Data has been inserted");
            loadData();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
        
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var row = dataGridView1.SelectedRows[0].DataBoundItem;
            textBox1.Text = ((DataRowView)row).Row.ItemArray[1].ToString();
            textBox2.Text = ((DataRowView)row).Row.ItemArray[2].ToString();
            textBox3.Text = ((DataRowView)row).Row.ItemArray[3].ToString();
            textBox4.Text = ((DataRowView)row).Row.ItemArray[4].ToString();
            textBox5.Text = ((DataRowView)row).Row.ItemArray[0].ToString();
        }
    }
}
