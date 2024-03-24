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
            MainDL.LoadDataOnGridTable(dataGridView1, "Student");
            hide_UD_Btns();
        }
        private void Data_Table_Click(object sender, DataGridViewCellEventArgs e)
        {
            // data type 
            var row = dataGridView1.SelectedRows[0];
            
            stdFirstNameBox.Text = row.Cells[1].Value.ToString();
            stdLastNameBox.Text = row.Cells[2].Value.ToString();
            stdContactBox.Text = row.Cells[3].Value.ToString();
            stdEmailBox.Text = row.Cells[4].Value.ToString();    
            stdRegNoBox.Text = row.Cells[5].Value.ToString();

            MainDL.LoadDataOnGridTable(dataGridView1, "Student");
            show_UD_Btns();
        }
        private void Add_Student(object sender, EventArgs e)
        {
            if (TextBoxHasNull()) {
                MsgDL.TextBoxEmptyError();
                return;
            }
            Program.connection.Open();

            string query = "INSERT INTO Student VALUES (@F_Name, @L_Name, @Contact, @Email, @RegNo, 1)";
            
            SqlCommand cmd = new SqlCommand(query, Program.connection);
            getParameters(cmd);
            
            cmd.ExecuteNonQuery();

            Program.connection.Close();

            MainDL.LoadDataOnGridTable(dataGridView1, "Student");
        }
        private void Update_Student(object sender, EventArgs e)
        {
            if (TextBoxHasNull()) {
                MsgDL.TextBoxEmptyError();
                return;
            }
            Program.connection.Open();

            int id = MainDL.GetIdFromGridTable(dataGridView1);

            string query = "UPDATE Student SET FirstName = @F_Name, LastName = @L_Name, Contact = @Contact, Email = @Email, RegistrationNumber = @RegNo WHERE Id = @id";
            
            SqlCommand cmd = new SqlCommand(query, Program.connection);    
            cmd.Parameters.AddWithValue("@id", id);
            getParameters(cmd);  // gets all the other parameters
            
            cmd.ExecuteNonQuery();
            
            Program.connection.Close();
            MainDL.LoadDataOnGridTable(dataGridView1, "Student");
        }
        private void Delete_Student(object sender, EventArgs e)
        {
            if (TextBoxHasNull()) {
                MsgDL.TextBoxEmptyError();
                return;
            }
            int id = MainDL.GetIdFromGridTable(dataGridView1);

            QueryDL.DeleteFromTable("StudentAttendance", "StudentId" ,id);
            QueryDL.DeleteFromTable("Student", "Id" ,id);

            MainDL.LoadDataOnGridTable(dataGridView1, "Student");
        }
        private void getParameters(SqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@F_Name", stdFirstNameBox.Text);
            cmd.Parameters.AddWithValue("@L_Name", stdLastNameBox.Text);
            cmd.Parameters.AddWithValue("@Contact", stdContactBox.Text);
            cmd.Parameters.AddWithValue("@Email", stdEmailBox.Text);
            cmd.Parameters.AddWithValue("@RegNo", stdRegNoBox.Text);
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
        private void hideUdBtn_Click(object sender, EventArgs e)
        {
            hide_UD_Btns();
        }
        private void Mark_Attendance(object sender, EventArgs e)
        {
            Form form = new Attendance();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
        }
        private void addStudentPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
