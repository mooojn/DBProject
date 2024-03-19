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
    public partial class Student : Form
    {
        public Student()
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

            cmd.Parameters.AddWithValue("@f_Name", stdFirstNameBox.Text);
            cmd.Parameters.AddWithValue("@L_Name", stdContactBox.Text);
            cmd.Parameters.AddWithValue("@Contact", stdLastNameBox.Text);
            cmd.Parameters.AddWithValue("@Email", stdEmailBox.Text);
            cmd.Parameters.AddWithValue("@RegNo", stdRegNoBox.Text);

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
            stdFirstNameBox.Text = ((DataRowView)row).Row.ItemArray[1].ToString();
            stdContactBox.Text = ((DataRowView)row).Row.ItemArray[2].ToString();
            stdLastNameBox.Text = ((DataRowView)row).Row.ItemArray[3].ToString();
            stdEmailBox.Text = ((DataRowView)row).Row.ItemArray[4].ToString();
            stdRegNoBox.Text = ((DataRowView)row).Row.ItemArray[5].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.connection.Open();

            int id = getId();

            string query = "UPDATE Student SET FirstName = @F_Name, LastName = @L_Name, " +
                "Contact = @Contact, Email = @Email, RegistrationNumber = @RegNo " +
                "WHERE Id = @id";

            
            SqlCommand cmd = new SqlCommand(query, Program.connection);    

            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@F_Name", stdFirstNameBox.Text);
            cmd.Parameters.AddWithValue("@L_Name", stdLastNameBox.Text);
            cmd.Parameters.AddWithValue("@Contact", stdContactBox.Text);
            cmd.Parameters.AddWithValue("@Email", stdEmailBox.Text);
            cmd.Parameters.AddWithValue("@RegNo", stdRegNoBox.Text);

            cmd.ExecuteNonQuery();
            
            Program.connection.Close();
            loadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.connection.Open();

            int id = getId();
    
            string query = $"DELETE FROM Student WHERE Id = {id}";


            SqlCommand cmd = new SqlCommand(query, Program.connection);

            
            cmd.ExecuteNonQuery();

            Program.connection.Close();
            loadData();
        }
        private int getId()
        {
            var row = dataGridView1.SelectedRows[0].DataBoundItem;
            return Convert.ToInt32(((DataRowView)row).Row.ItemArray[0]);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form form = new Attendance();
            form.Show();

        }
    }
}
