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
    public partial class Uet : Form
    {
        public static string connectionString = "Data Source=DESKTOP-AJHCE58\\MOOOJN;Initial Catalog=ProjectB;Integrated Security=True";
        public Uet()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pass = textBox1.Text;
            if (pass == "admin") 
            {
                this.Hide();
                Dashboard f = new Dashboard();
                f.Show();
            }
            else
            {
                MessageBox.Show("Invalid Password");
            }
        }
    }
}
