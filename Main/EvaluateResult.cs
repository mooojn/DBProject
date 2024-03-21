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
    public partial class EvaluateResult : Form
    {
        public EvaluateResult()
        {
            InitializeComponent();
        }

        private void EvaluateResult_Load(object sender, EventArgs e)
        {
            loadData();
            
            loadComboBox(StudentComboBox, "FirstName", "Student");

            loadComboBox(AssessmentComboBox, "Title", "Assessment");
            loadComboBox(ComponentComboBox, "Name", "AssessmentComponent");

            loadComboBox(RubricLevel_IdComboBox, "Id", "RubricLevel");
            loadComboBox(RubricLevelComboBox, "MeasurementLevel", "RubricLevel");
            
            loadComboBox(RubricDetailComboBox, "Details", "Rubric");

        }
        private void loadData()
        {
            Program.connection.Open();
            string query = "SELECT * FROM StudentResult";
            SqlDataAdapter SDA = new SqlDataAdapter(query, Program.connection);
            DataTable dt = new DataTable();
                
            SDA.Fill(dt);
                
            dataGridView1.DataSource = dt;
            Program.connection.Close();

        }
        private void loadComboBox(ComboBox ComboBoxToUse, string value, string table)
        {
            ComboBoxToUse.Items.Clear();
            Program.connection.Open();
            string query = $"SELECT {value} FROM {table}";
            SqlCommand command = new SqlCommand(query, Program.connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ComboBoxToUse.Items.Add(reader[0]);
                
            }
            Program.connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int stdId = QueryDL.GetIdFromTableUsingString("Id", "Student", "FirstName", StudentComboBox.Text);
            int assessmentId = QueryDL.GetIdFromTableUsingString("Id", "AssessmentComponent", "Name", ComponentComboBox.Text);
            int rubricId = QueryDL.GetIdFromTableUsingString("Id", "RubricLevel", "MeasurementLevel", RubricLevelComboBox.Text);

            Program.connection.Open();
            string query = "INSERT INTO StudentResult VALUES (@StudentId, @AssessmentComponentId, @RubricMeasurementId, @EvaluationDate)";
            SqlCommand command = new SqlCommand(query, Program.connection);

            command.Parameters.AddWithValue("@StudentId", stdId);
            command.Parameters.AddWithValue("@AssessmentComponentId", assessmentId);
            command.Parameters.AddWithValue("@RubricMeasurementId", rubricId);
            command.Parameters.AddWithValue("@EvaluationDate", dateTimePicker1.Value);
            
            command.ExecuteNonQuery();

            Program.connection.Close();

            loadData();
        }
    }
}
