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
            loadRegNoComboBox();
            loadStatusComboBox();
        }
        private void insertIntoclassAttendance()
        {
            if (textBoxIsNull())
            {
                MainDL.TextBoxEmptyError();
                return;
            }
            Program.connection.Open();

            string query = "INSERT INTO ClassAttendance VALUES (@Date)";

            var cmd = new SqlCommand(query, Program.connection);
            cmd.Parameters.AddWithValue("@Date", DateTime.Now);
            cmd.ExecuteNonQuery();

            Program.connection.Close();
        }

        private void Save_Attendance(object sender, EventArgs e)
        {
            if (textBoxIsNull()) {
                MainDL.TextBoxEmptyError();
                return;
            }
            insertIntoclassAttendance();
            
            // getting the ids
            int attendanceId = MainDL.GetIdFromTable("MAX(Id)", "ClassAttendance");
            int stdId = MainDL.GetIdFromTableUsingString("Id", "Student", "RegistrationNumber", RegNoComboBox.Text);
            int status = MainDL.GetIdFromTableUsingString("Lookupid", "Lookup", "Name", StatusComboBox.Text);
            
            Program.connection.Open();
            string query = "INSERT INTO StudentAttendance VALUES (@id, @StdId, @AttendanceStatus)";
            
            var cmd = new SqlCommand(query, Program.connection);
            cmd.Parameters.AddWithValue("@id", attendanceId);    /// change id to auto increment
            cmd.Parameters.AddWithValue("@StdId", stdId);
            cmd.Parameters.AddWithValue("@AttendanceStatus", status);
            cmd.ExecuteNonQuery();

            Program.connection.Close();

            MessageBox.Show("Attendance Marked", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        private void loadRegNoComboBox()
        {
            RegNoComboBox.Items.Clear();

            Program.connection.Open();

            string query = "SELECT * FROM Student";

            SqlCommand cmd = new SqlCommand(query, Program.connection);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read()) {
                RegNoComboBox.Items.Add(reader.GetString(5));
            }
            Program.connection.Close();
        }
        private void loadStatusComboBox()
        {
            StatusComboBox.Items.Clear();

            Program.connection.Open();

            string query = "SELECT TOP 4 * FROM Lookup";

            SqlCommand cmd = new SqlCommand(query, Program.connection);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read()) {
                StatusComboBox.Items.Add(reader.GetString(1));
            }
            Program.connection.Close();
        }
        private bool textBoxIsNull()
        {
            if (RegNoComboBox.Text == "" || StatusComboBox.Text == "") {
                return true;
            }
            return false;
        }
    }
}
