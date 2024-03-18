﻿using System;
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
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new Students(), sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new Clos(), sender);
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
    }
}
