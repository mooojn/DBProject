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

        private void button1_Click(object sender, EventArgs e)
        {
            Program.connection.Open();
            string query = "INSERT INTO StudentResult VALUES" +
                "(@StudentId, @AssessmentComponentId, @RubricMeasurementId, @EvaluationDate)";
            SqlCommand command = new SqlCommand(query, Program.connection);


            //command.Parameters.AddWithValue("@StudentId", StudentIdComboBox.Text);
            //command.Parameters.AddWithValue("@AssessmentComponentId", AssessmentComponentIdComboBox.Text);
            //command.Parameters.AddWithValue("@RubricMeasurementId", RubricMeasurementIdComboBox.Text);
            
            
            command.Parameters.AddWithValue("@EvaluationDate", dateTimePicker1.Value);
            command.ExecuteNonQuery();
            Program.connection.Close();

            loadData();
        }
    }
}
