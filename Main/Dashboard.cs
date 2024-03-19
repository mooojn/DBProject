using DBProject.Main;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace DBProject
{
    public partial class Dashboard : Form
    {
        Form activeForm;
        public Dashboard()
        {
            InitializeComponent();
            this.Size = new Size(820, 520);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new Student(), sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new Clo(), sender);
        }
        private void openChildForm(Form child, object sender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = child;
            
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            
            this.panel.Controls.Add(child);
            this.panel.Tag = child;
            
            child.BringToFront();
            child.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
             
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openChildForm(new Assesment(), sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new Rubric(), sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openChildForm(new RubricLevel(), sender);
        }
    }
}
