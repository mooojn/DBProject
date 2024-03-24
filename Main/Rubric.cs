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
using DBProject.Functions;

namespace DBProject
{
    public partial class Rubric : Form
    {
        public Rubric()
        {
            InitializeComponent();
        }

        private void Rubric_Load(object sender, EventArgs e)
        {
            loadComboBox();
            loadData();
            UtilDL.hideUD_Btns(addBtn, updateBtn, deleteBtn, udBtn);
        }
        private void loadComboBox()
        {
            Clo_IDComboBox.Items.Clear();
            Program.connection.Open();
            string query = "SELECT Name FROM Clo";
            SqlCommand command = new SqlCommand(query, Program.connection);
            SqlDataReader data = command.ExecuteReader();
            while (data.Read())
            {
                Clo_IDComboBox.Items.Add(data[0]);
            }
            Program.connection.Close();
        }
        private void Cell_Click(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
            textBox1.Text = selectedRow.Cells[1].Value.ToString();
            Clo_IDComboBox.Text = selectedRow.Cells[2].Value.ToString();
            UtilDL.showUD_Btns(addBtn, updateBtn, deleteBtn, udBtn);
        }

        private void Insert_Data(object sender, EventArgs e)
        {
            if (textBoxIsNull()) {
                MsgDL.TextBoxEmptyError();
                return;
            }
            Program.connection.Open();
            string query = "INSERT INTO Rubric values (@Details, (SELECT Id FROM Clo WHERE Name = @CloId))";
            SqlCommand command = new SqlCommand(query, Program.connection);

            command.Parameters.AddWithValue("@Details", textBox1.Text);
            command.Parameters.AddWithValue("@CloId", Clo_IDComboBox.Text);
            command.ExecuteNonQuery();
            Program.connection.Close();
            loadData();

        }
        private int getId()
        {
            Program.connection.Open();
            string query = "SELECT MAX(Id) FROM Rubric";
            SqlCommand command = new SqlCommand(query, Program.connection);
            SqlDataReader data = command.ExecuteReader();
            int id = 0;
            while (data.Read())
            {
                id = data.GetInt32(0);
            }
            Program.connection.Close();
            return id + 1;

        }
        private void loadData()
        {
            Program.connection.Open();
            string query = "SELECT * FROM Rubric";
            SqlDataAdapter SDA = new SqlDataAdapter(query, Program.connection);
            DataTable data = new DataTable();
            SDA.Fill(data);
            dataGridView1.DataSource = data;
            Program.connection.Close();
        }

        private void Update_Data(object sender, EventArgs e)
        {
            if (textBoxIsNull()) {
                MsgDL.TextBoxEmptyError();
                return;
            }
            Program.connection.Open();
            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

            string query = "UPDATE Rubric SET Details = @Details, CloId = @CloId " +
                "WHERE Id = @Id";
            
            SqlCommand command = new SqlCommand(query, Program.connection);
            command.Parameters.AddWithValue("@Id", id);
            command.Parameters.AddWithValue("@Details", textBox1.Text);
            command.Parameters.AddWithValue("@CloId", Clo_IDComboBox.Text);
            command.ExecuteNonQuery();
            
            Program.connection.Close();
            loadData();
        }

        private void Delete_Data(object sender, EventArgs e)
        {
            if (textBoxIsNull()) {
                MsgDL.TextBoxEmptyError();
                return;
            }
            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            Program.connection.Open();
            string query = "DELETE FROM Rubric " +
                "WHERE Id = @Id";

            SqlCommand command = new SqlCommand(query, Program.connection);
            command.Parameters.AddWithValue("@Id", id);
            command.ExecuteNonQuery();

            Program.connection.Close();
            loadData();
        }
        private bool textBoxIsNull()
        {
            if (textBox1.Text == "" || Clo_IDComboBox.Text == "") {
                return true;
            }
            return false;
        }

        private void udBtn_Click(object sender, EventArgs e)
        {
            UtilDL.hideUD_Btns(addBtn, updateBtn, deleteBtn, udBtn);
        }
    }
}
