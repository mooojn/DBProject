using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace DBProject
{
    public partial class AssesmentComponent : Form
    {
        public AssesmentComponent()
        {
            InitializeComponent();
        }

        private void AssesmentComponent_Load(object sender, EventArgs e)
        {
            loadData();
            loadAssessmentData();
            loadRubricData();
        }
        private void loadRubricData()
        {
            RubricNameComboBox.Items.Clear();
            Program.connection.Open();
            string query = "SELECT Details FROM Rubric";
            SqlCommand cmd = new SqlCommand(query, Program.connection);
            SqlDataReader data = cmd.ExecuteReader();
            while (data.Read())
            {
                RubricNameComboBox.Items.Add(data.GetString(0));
            }
            Program.connection.Close();
        }
        private void loadAssessmentData()
        {
            AssessmentNameComboBox.Items.Clear();
            Program.connection.Open();
            string query = "SELECT Title FROM Assessment";
            SqlCommand cmd = new SqlCommand(query, Program.connection);
            SqlDataReader data = cmd.ExecuteReader();
            while (data.Read())
            {
                AssessmentNameComboBox.Items.Add(data.GetString(0));
            }
            Program.connection.Close();
        }
        private void loadData()
        {
            Program.connection.Open();
            string query = "SELECT * FROM AssessmentComponent";
                
            SqlDataAdapter SDA = new SqlDataAdapter(query, Program.connection);
                
            DataTable data = new DataTable();
            SDA.Fill(data);
            dataGridView1.DataSource = data;
            Program.connection.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Add_Data(object sender, EventArgs e)
        {
            int assessmentId = getAssessmentId();
            int rubricId = getRubricId();

            Program.connection.Open();
            string query = "INSERT INTO AssessmentComponent VALUES " +
                "(@Name, @RubricId, @TotalMarks, @DateCreated, @DateUpdated, @AssessmentId)";
            
            SqlCommand cmd = new SqlCommand(query, Program.connection);
            
            cmd.Parameters.AddWithValue("@Name", textBox1.Text);
            cmd.Parameters.AddWithValue("@RubricId", rubricId);
            cmd.Parameters.AddWithValue("@TotalMarks", textBox2.Text);
            cmd.Parameters.AddWithValue("@DateCreated", DateTime.Now);
            cmd.Parameters.AddWithValue("@DateUpdated", DateTime.Now);
            cmd.Parameters.AddWithValue("@AssessmentId", assessmentId);
            cmd.ExecuteNonQuery();
            
            Program.connection.Close();
            loadData();
        }
        private int getAssessmentId()
        {
            int id = -1;
            Program.connection.Open();
            string query = "SELECT Id FROM Assessment WHERE Title = @Title";
            SqlCommand cmd = new SqlCommand(query, Program.connection);
            cmd.Parameters.AddWithValue("@Title", AssessmentNameComboBox.Text);
            SqlDataReader data = cmd.ExecuteReader();
            while (data.Read())
            {
                id = data.GetInt32(0);
            }
            Program.connection.Close();

            return id;
        }
        private int getRubricId()
        {
            int id = -1;
            Program.connection.Open();
            string query = "SELECT Id FROM Rubric WHERE Details = @Detail";
            SqlCommand cmd = new SqlCommand(query, Program.connection);
            cmd.Parameters.AddWithValue("@Detail", RubricNameComboBox.Text);
            SqlDataReader data = cmd.ExecuteReader();
            while (data.Read())
            {
                id = data.GetInt32(0);
            }
            Program.connection.Close();

            return id;
        }
        private void Update_Data(object sender, EventArgs e)
        {
            int assessmentId = getAssessmentId();
            int rubricId = getRubricId();
            Program.connection.Open();
            string query = "UPDATE AssessmentComponent SET " +
                "Name = @Name, RubricId = @RubricId, TotalMarks = @TotalMarks, " +
                "DateUpdated = @DateUpdated, AssessmentId = @AssessmentId WHERE Id = @Id";
            
            SqlCommand cmd = new SqlCommand(query, Program.connection);
            cmd.Parameters.AddWithValue("@Name", textBox1.Text);
            cmd.Parameters.AddWithValue("@RubricId", rubricId);
            cmd.Parameters.AddWithValue("@TotalMarks", textBox2.Text);
            cmd.Parameters.AddWithValue("@DateUpdated", DateTime.Now);
            cmd.Parameters.AddWithValue("@AssessmentId", assessmentId);
            cmd.Parameters.AddWithValue("@Id", dataGridView1.SelectedRows[0].Cells[0].Value);

            cmd.ExecuteNonQuery();
            Program.connection.Close();
            loadData();

        }

        private void Cell_Click(object sender, DataGridViewCellEventArgs e)
        {
            var rows = dataGridView1.SelectedRows[0];
            textBox1.Text = rows.Cells[1].Value.ToString();
            textBox2.Text = rows.Cells[3].Value.ToString();
        }

        private void Delete_Data(object sender, EventArgs e)
        {
            Program.connection.Open();
            string query = "DELETE FROM AssessmentComponent WHERE Id = @Id";

            SqlCommand cmd = new SqlCommand(query, Program.connection);
            cmd.Parameters.AddWithValue("@Id", dataGridView1.SelectedRows[0].Cells[0].Value);

            cmd.ExecuteNonQuery();
            Program.connection.Close();
            loadData();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
