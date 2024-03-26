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
using System.Text.RegularExpressions;

namespace DBProject
{
    public partial class Attendance : Form
    {
        public Attendance()
        {
            InitializeComponent();
        }

        private void Attendance_Load(object sender, EventArgs e)
        {
            QueryDL.LoadComboBox(RegNoComboBox, "RegistrationNumber", "Student");
            QueryDL.LoadComboBox(StatusComboBox, "TOP 4 Name", "Lookup");
        }
        private void insertIntoclassAttendance()
        {
            if (MainDL.IsAnyBoxNull(this.panel1))
            {
                MsgDL.TextBoxEmptyError();
                return;
            }
            Program.connection.Open();

            string query = "INSERT INTO ClassAttendance VALUES (@Date)";

            SqlCommand cmd = new SqlCommand(query, Program.connection);
            cmd.Parameters.AddWithValue("@Date", datePicker.Value);
            cmd.ExecuteNonQuery();

            Program.connection.Close();
        }

        private void Save_Attendance(object sender, EventArgs e)
        {
            if (MainDL.IsAnyBoxNull(this.panel1))
            {
                MsgDL.TextBoxEmptyError();
                return;
            }
            insertIntoclassAttendance();
            // getting the ids
            int attendanceId = QueryDL.GetIdFromTable("MAX(Id)", "ClassAttendance", "1", "1");   // 1, 1 is extra to make the function work
            int stdId = QueryDL.GetIdFromTable("Id", "Student", "RegistrationNumber", RegNoComboBox.Text);
            int status = QueryDL.GetIdFromTable("Lookupid", "Lookup", "Name", StatusComboBox.Text);
            Program.connection.Open();

            string query = $"INSERT INTO StudentAttendance VALUES ({attendanceId}, {stdId}, {status})";
            SqlCommand cmd = new SqlCommand(query, Program.connection);
            cmd.ExecuteNonQuery();

            Program.connection.Close();
            MessageBox.Show("Attendance Marked", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
