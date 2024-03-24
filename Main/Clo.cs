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
using System.Net;
using DBProject.Functions;

namespace DBProject
{
    public partial class Clo : Form
    {
        public Clo()
        {
            InitializeComponent();
            MainDL.LoadDataOnGridTable(dataGridView1, "CLO");
        }
        
        private void Clos_Load(object sender, EventArgs e)
        {
            UtilDL.hideUD_Btns(addBtn, updateBtn, deleteBtn, udBtn);
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var row = dataGridView1.SelectedRows[0];
            textBox1.Text = row.Cells[1].Value.ToString();
            UtilDL.showUD_Btns(addBtn, updateBtn, deleteBtn, udBtn);
        }

        private void Add_Data(object sender, EventArgs e)
        {
            if (textBoxIsNull())
            {
                MsgDL.TextBoxEmptyError();
                return;
            }
            Program.connection.Open();
            
            string query = "INSERT INTO CLO VALUES (@Name, @DateCreated, @DateCreated)";   

            SqlCommand cmd = new SqlCommand(query, Program.connection);
            cmd.Parameters.AddWithValue("@Name", textBox1.Text);
            cmd.Parameters.AddWithValue("@DateCreated", DateTime.Now);
            cmd.ExecuteNonQuery();

            Program.connection.Close();

            MainDL.LoadDataOnGridTable(dataGridView1, "CLO");
        }
        private void Update_Data(object sender, EventArgs e)
        {
            if (textBoxIsNull()) {
                MsgDL.TextBoxEmptyError();
                return;
            }
            Program.connection.Open();

            string query = "UPDATE CLO SET Name = @NewName, DateUpdated = @NewTime WHERE Id = @Id";
            int id = MainDL.GetIdFromGridTable(dataGridView1);

            SqlCommand cmd = new SqlCommand(query, Program.connection);
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.Parameters.AddWithValue("@NewName", textBox1.Text);
            cmd.Parameters.AddWithValue("@NewTime", DateTime.Now);
            cmd.ExecuteNonQuery();

            Program.connection.Close();

            MainDL.LoadDataOnGridTable(dataGridView1, "CLO");
        }

        private void Delete_Data(object sender, EventArgs e)
        {
            if (textBoxIsNull()) {
                MsgDL.TextBoxEmptyError();
                return;
            }
            int id = MainDL.GetIdFromGridTable(dataGridView1);
            
            QueryDL.DeleteFromTable("CLO", "Id", id);
            
            MainDL.LoadDataOnGridTable(dataGridView1, "CLO");
        }
        private bool textBoxIsNull()
        {
            if (textBox1.Text == "") {
                return true;
            }
            return false;
        }
        private void UD_Btn_Click(object sender, EventArgs e)
        {
            UtilDL.hideUD_Btns(addBtn, updateBtn, deleteBtn, udBtn);
        }
    }
}
