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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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
            createCol();

            loadData();

            loadComboBox(StudentComboBox, "FirstName", "Student");

            loadComboBox(AssessmentComboBox, "Title", "Assessment");

        }
        private void createCol()
        {
            dataGridView1.Columns.Add("Student", "Student");
            dataGridView1.Columns.Add("Assessment", "Assessment");
            dataGridView1.Columns.Add("Rubric Level", "Rubric Level");            

            dataGridView1.Columns.Add("Total Marks", "Total Marks");
            dataGridView1.Columns.Add("Obtained Marks", "Obtained Marks");
        }
        private void loadData()
        {
            dataGridView1.Rows.Clear();

            Program.connection.Open();
            string query = "SELECT * FROM StudentResult";


            SqlDataAdapter SDA = new SqlDataAdapter(query, Program.connection);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            
            Program.connection.Close();
            if (dt.Rows.Count > 0) {
                foreach (DataRow row in dt.Rows) {
                    int stdId = Convert.ToInt32(row["StudentId"]);
                    int assessmentId = Convert.ToInt32(row["AssessmentComponentId"]);
                    int rubricId = Convert.ToInt32(row["RubricMeasurementId"]);
                    int totalMarks = 100;// remove hardcoding
                 
                    float obtainedMarks = CalculateMarks(assessmentId, rubricId);
                 
                    dataGridView1.Rows.Add(stdId, assessmentId, rubricId, totalMarks, obtainedMarks);
                }
            }
        }
        private float CalculateMarks(int assesmentId, int rubricId)
        {
            string query1 = $"SELECT TotalMarks FROM AssessmentComponent WHERE Id = {assesmentId}";
            float componentMarks = getField(query1);

            string query2 = $"SELECT MAX(MeasurementLevel) FROM RubricLevel WHERE RubricId = (SELECT RubricId FROM RubricLevel WHERE Id = {rubricId})";
            float maxRubricLevel = getField(query2);

            string query3 = $"SELECT MeasurementLevel FROM RubricLevel WHERE Id = {rubricId}";
            float currentRubricLevel = getField(query3);

            return (currentRubricLevel /maxRubricLevel) * componentMarks;  
        }
        private float getField(string query)
        {
            Program.connection.Open();

            SqlCommand command = new SqlCommand(query, Program.connection);
            float field = Convert.ToInt32(command.ExecuteScalar());
            
            Program.connection.Close();
            return field;
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
        private void loadComboBoxWhere(ComboBox ComboBoxToUse, string value, string table, string subQuery)
        {
            ComboBoxToUse.Items.Clear();
            Program.connection.Open();
            string query = $"SELECT {value} FROM {table} WHERE {subQuery}";
            SqlCommand command = new SqlCommand(query, Program.connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ComboBoxToUse.Items.Add(reader[0]);

            }
            Program.connection.Close();
        }

        private void Add_Data(object sender, EventArgs e)
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

        private void StudentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AssessmentComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            string subQuery = $"AssessmentId = (SELECT Id FROM Assessment WHERE Title = '{AssessmentComboBox.Text}')";
            loadComboBoxWhere(ComponentComboBox, "Name", "AssessmentComponent", subQuery);
        }

        private void ComponentComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            string subQuery = $"Id = (SELECT RubricId FROM AssessmentComponent WHERE Name = '{ComponentComboBox.Text}')";
            loadComboBoxWhere(RubricDetailComboBox, "Details", "Rubric", subQuery);
        }

        private void RubricLevelComboBox_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void RubricDetailComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            
            string subQuery = $"RubricId = (SELECT Id FROM Rubric WHERE Details = '{RubricDetailComboBox.Text}')";
            loadComboBoxWhere(RubricLevelComboBox, "MeasurementLevel", "RubricLevel", subQuery);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
