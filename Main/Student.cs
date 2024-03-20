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
            StdDL.LoadData(dataGridView1, "Student");
            hide_UD_Btns();
        }
        private void show_UD_Btns() 
        {
            // A btn
            addBtn.Hide();
            // UD btns
            hideUdBtn.Show();
            updateBtn.Show();
            deleteBtn.Show();
        }
        private void hide_UD_Btns() 
        {
            // A btn
            addBtn.Show();
            // UD btns
            hideUdBtn.Hide();
            updateBtn.Hide();
            deleteBtn.Hide();
        }

        

        private void Add_Student(object sender, EventArgs e)
        {
            if (TextBoxHasNull())
            {
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Program.connection.Open();

            string query = "INSERT INTO Student VALUES (@f_Name, @L_Name, @Contact, @Email, @RegNo, 1)";

            SqlCommand cmd = new SqlCommand(query, Program.connection);

            cmd.Parameters.AddWithValue("@f_Name", stdFirstNameBox.Text);
            cmd.Parameters.AddWithValue("@L_Name", stdLastNameBox.Text);
            cmd.Parameters.AddWithValue("@Contact", stdContactBox.Text);
            cmd.Parameters.AddWithValue("@Email", stdEmailBox.Text);
            cmd.Parameters.AddWithValue("@RegNo", stdRegNoBox.Text);

            cmd.ExecuteNonQuery();

            Program.connection.Close();
            StdDL.LoadData(dataGridView1, "Student");
        }


        

        private void Data_Table_Click(object sender, DataGridViewCellEventArgs e)
        {
            var row = dataGridView1.SelectedRows[0];
            
            stdFirstNameBox.Text = row.Cells[1].Value.ToString();
            stdLastNameBox.Text = row.Cells[2].Value.ToString();
            stdContactBox.Text = row.Cells[3].Value.ToString();
            stdEmailBox.Text = row.Cells[4].Value.ToString();    
            stdRegNoBox.Text = row.Cells[5].Value.ToString();

            StdDL.LoadData(dataGridView1, "Student");
            show_UD_Btns();
        }

        private void Update_Student(object sender, EventArgs e)
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
            StdDL.LoadData(dataGridView1, "Student");
        }

        private void Delete_Student(object sender, EventArgs e)
        {
            int id = getId();

            StdDL.DeleteFromTable("Student", "Id" ,id);
            StdDL.DeleteFromTable("StudentAttendance", "StudentId" ,id);

            StdDL.LoadData(dataGridView1, "Student");
        }
        private int getId()
        {
            var row = dataGridView1.SelectedRows[0].DataBoundItem;
            return Convert.ToInt32(((DataRowView)row).Row.ItemArray[0]);
        }

        private void Mark_Attendance(object sender, EventArgs e)
        {
            Form form = new Attendance();
            form.Show();

        }

        private void hideUdBtn_Click(object sender, EventArgs e)
        {
            hide_UD_Btns();
        }

        private void addStudentPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }
        // if any of the textboxes are empty, return true
        private bool TextBoxHasNull()
        {
            if (string.IsNullOrEmpty(stdFirstNameBox.Text) || string.IsNullOrEmpty(stdLastNameBox.Text) 
                || string.IsNullOrEmpty(stdContactBox.Text) 
                ||string.IsNullOrEmpty(stdEmailBox.Text) || string.IsNullOrEmpty(stdRegNoBox.Text)) 
            {
                return true;
            }
            return false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
