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
    public partial class Attendance : Form
    {
        public Attendance()
        {
            InitializeComponent();
        }

        private void Attendance_Load(object sender, EventArgs e)
        {

            loadRegNo();

            loadStatus();
        }
        private void loadRegNo() 
        {
            RegNoComboBox.Items.Clear();
            Program.connection.Open();
            string query = "SELECT * FROM Student";
            var cmd = new SqlCommand(query, Program.connection);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                RegNoComboBox.Items.Add(reader.GetString(5));
            }
            Program.connection.Close();
        }
        private void loadStatus()
        {
            StatusComboBox.Items.Clear();
            Program.connection.Open();
            string query2 = "SELECT TOP 4 * FROM Lookup";
            var cmd2 = new SqlCommand(query2, Program.connection);
            var reader2 = cmd2.ExecuteReader();
            while (reader2.Read())
            {
                StatusComboBox.Items.Add(reader2.GetString(1));
            }
            Program.connection.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            insertIntoclassAttendance();
            int id = getId();
            int status = getStatus();
            MessageBox.Show(id.ToString() + status.ToString());
           
            Program.connection.Open();
            string query = "INSERT INTO StudentAttendance VALUES (@id, @StdId, @AttendanceStatus)";
            
            var cmd = new SqlCommand(query, Program.connection);
            cmd.Parameters.AddWithValue("@id", 1);    /// change id to auto increment
            cmd.Parameters.AddWithValue("@StdId", id);
            cmd.Parameters.AddWithValue("@AttendanceStatus", status);

            cmd.ExecuteNonQuery();

            Program.connection.Close();

        }
        private void insertIntoclassAttendance()
        {
            Program.connection.Open();
            string query = "INSERT INTO ClassAttendance VALUES (@Date)";
            var cmd = new SqlCommand(query, Program.connection);
            cmd.Parameters.AddWithValue("@Date", DateTime.Now);
            cmd.ExecuteNonQuery();
            Program.connection.Close();
        }
        private int getStatus()
        {
            Program.connection.Open();
            string attendance = StatusComboBox.Text;
            int status = -1;

            string queryForStatus = "SELECT Lookupid FROM Lookup WHERE Name = @Status";
            var cmdForStatus = new SqlCommand(queryForStatus, Program.connection);
                
            cmdForStatus.Parameters.AddWithValue("@Status", attendance);
            var reader = cmdForStatus.ExecuteReader();
            while (reader.Read())
            {
                status = reader.GetInt32(0);
            }

            Program.connection.Close();
            return status;
        }
        private int getId()
        {
            string regNo = RegNoComboBox.Text;

            Program.connection.Open();
            int id = -1;
            
            string queryForId = "SELECT Id FROM Student WHERE RegistrationNumber = @RegNo";
            var cmdForId = new SqlCommand(queryForId, Program.connection);
            cmdForId.Parameters.AddWithValue("@RegNo", regNo);
            var reader = cmdForId.ExecuteReader();
            while (reader.Read())
            {
                id = reader.GetInt32(0);
            }

            Program.connection.Close();
            return id;
        }
    }
}
