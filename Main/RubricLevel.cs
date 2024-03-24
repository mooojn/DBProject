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
using System.Security.AccessControl;
using System.util;
using DBProject.Functions;

namespace DBProject.Main
{
    public partial class RubricLevel : Form
    {
        public RubricLevel()
        {
            InitializeComponent();
        }
        private void RubricLevel_Load(object sender, EventArgs e)
        {
            loadData();
            loadRubricId();
            UtilDL.hideUD_Btns(addBtn, updateBtn, deleteBtn, udBtn);
        }

        private void Add_Data(object sender, EventArgs e)
        {
            if (BoxIsNull())
            {
                MsgDL.TextBoxEmptyError();
                return;
            }
            Program.connection.Open();
            string query = "INSERT INTO RubricLevel VALUES (@RubricId, @Details, @MeasurementLevel)";
            
            SqlCommand command = new SqlCommand(query, Program.connection);
            command.Parameters.AddWithValue("@RubricId", RubricIdComboBox.Text);
            command.Parameters.AddWithValue("@Details", textBox1.Text);
            int measureLevel = getRubricLevelInteger();
            command.Parameters.AddWithValue("@MeasurementLevel", measureLevel);
            command.ExecuteNonQuery();
            
            Program.connection.Close();
            loadData();
        }
        private int getRubricLevelInteger()
        {
            int level = -1;
            string text = RubricLevelComboBox.Text;
            
            if (text == "Unsatisfactory")
            {
                level = 1;
            }
            else if (text == "Fair")
            {
                level = 2;
            }
            else if (text == "Good")
            {
                level = 3;
            }
            else if (text == "Exceptional")
            {
                level = 4;
            }
            return level;
        }
        private void loadData()
        {
            Program.connection.Open();
            string query = "SELECT * FROM RubricLevel";
            SqlDataAdapter sda = new SqlDataAdapter(query, Program.connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            Program.connection.Close();
        }
        private void loadRubricId()
        {
            Program.connection.Open();
            string query = "SELECT Id FROM Rubric";
            SqlCommand command = new SqlCommand(query, Program.connection);
            SqlDataReader data = command.ExecuteReader();
            while (data.Read())
            {
                RubricIdComboBox.Items.Add(data[0]);
            }
                Program.connection.Close();
        }

        private void Cell_Click(object sender, DataGridViewCellEventArgs e)
        {
            var row = dataGridView1.SelectedRows[0];
            RubricIdComboBox.Text = row.Cells[1].Value.ToString();
            textBox1.Text = row.Cells[2].Value.ToString();
            RubricLevelComboBox.Text = row.Cells[3].Value.ToString();
            UtilDL.showUD_Btns(addBtn, updateBtn, deleteBtn, udBtn);
        }

        private void Update_Data(object sender, EventArgs e)
        {
            if (BoxIsNull())
            {
                MsgDL.TextBoxEmptyError();
                return;
            }
            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            Program.connection.Open();
            string query = "UPDATE RubricLevel SET RubricId = @RubricId, Details = @Details, " +
                "MeasurementLevel = @MeasurementLevel " +
                "WHERE Id = @Id";
            
            SqlCommand command = new SqlCommand(query, Program.connection);
            command.Parameters.AddWithValue("@Id", id);
            command.Parameters.AddWithValue("@RubricId", RubricIdComboBox.Text);
            command.Parameters.AddWithValue("@Details", textBox1.Text);
            int measureLevel = getRubricLevelInteger();
            command.Parameters.AddWithValue("@MeasurementLevel", measureLevel);
            command.ExecuteNonQuery();
            
            Program.connection.Close();
            
            loadData();
        }

        private void Delete_Data(object sender, EventArgs e)
        {
            if (BoxIsNull())
            {
                MsgDL.TextBoxEmptyError();
                return;
            }
            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            Program.connection.Open();
            string query = "DELETE FROM RubricLevel " +
                "WHERE Id = @Id";

            SqlCommand command = new SqlCommand(query, Program.connection);
            command.Parameters.AddWithValue("@Id", id);
            
            command.ExecuteNonQuery();

            Program.connection.Close();

            loadData();
        }

        private void udBtn_Click(object sender, EventArgs e)
        {
            UtilDL.hideUD_Btns(addBtn, updateBtn, deleteBtn, udBtn);
        }
        private bool BoxIsNull()
        {
            if (textBox1.Text == "" || RubricIdComboBox.Text == "" || RubricLevelComboBox.Text == "")
                return true;
            return false;
        }
    }
}
