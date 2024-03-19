namespace DBProject
{
    partial class Student
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addStudentPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.stdRegNoBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.stdEmailBox = new System.Windows.Forms.TextBox();
            this.stdContactBox = new System.Windows.Forms.TextBox();
            this.stdLastNameBox = new System.Windows.Forms.TextBox();
            this.stdFirstNameBox = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.addStudentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // addStudentPanel
            // 
            this.addStudentPanel.Controls.Add(this.button3);
            this.addStudentPanel.Controls.Add(this.button2);
            this.addStudentPanel.Controls.Add(this.button1);
            this.addStudentPanel.Controls.Add(this.label5);
            this.addStudentPanel.Controls.Add(this.stdRegNoBox);
            this.addStudentPanel.Controls.Add(this.label4);
            this.addStudentPanel.Controls.Add(this.label3);
            this.addStudentPanel.Controls.Add(this.label2);
            this.addStudentPanel.Controls.Add(this.label1);
            this.addStudentPanel.Controls.Add(this.stdEmailBox);
            this.addStudentPanel.Controls.Add(this.stdContactBox);
            this.addStudentPanel.Controls.Add(this.stdLastNameBox);
            this.addStudentPanel.Controls.Add(this.stdFirstNameBox);
            this.addStudentPanel.Controls.Add(this.button6);
            this.addStudentPanel.Location = new System.Drawing.Point(25, 27);
            this.addStudentPanel.Name = "addStudentPanel";
            this.addStudentPanel.Size = new System.Drawing.Size(822, 384);
            this.addStudentPanel.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "RegNo";
            // 
            // stdRegNoBox
            // 
            this.stdRegNoBox.Location = new System.Drawing.Point(203, 245);
            this.stdRegNoBox.Name = "stdRegNoBox";
            this.stdRegNoBox.Size = new System.Drawing.Size(241, 31);
            this.stdRegNoBox.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Contact";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "First Name";
            // 
            // stdEmailBox
            // 
            this.stdEmailBox.Location = new System.Drawing.Point(203, 193);
            this.stdEmailBox.Name = "stdEmailBox";
            this.stdEmailBox.Size = new System.Drawing.Size(241, 31);
            this.stdEmailBox.TabIndex = 14;
            // 
            // stdContactBox
            // 
            this.stdContactBox.Location = new System.Drawing.Point(203, 135);
            this.stdContactBox.Name = "stdContactBox";
            this.stdContactBox.Size = new System.Drawing.Size(241, 31);
            this.stdContactBox.TabIndex = 13;
            // 
            // stdLastNameBox
            // 
            this.stdLastNameBox.Location = new System.Drawing.Point(203, 80);
            this.stdLastNameBox.Name = "stdLastNameBox";
            this.stdLastNameBox.Size = new System.Drawing.Size(241, 31);
            this.stdLastNameBox.TabIndex = 12;
            // 
            // stdFirstNameBox
            // 
            this.stdFirstNameBox.Location = new System.Drawing.Point(203, 25);
            this.stdFirstNameBox.Name = "stdFirstNameBox";
            this.stdFirstNameBox.Size = new System.Drawing.Size(241, 31);
            this.stdFirstNameBox.TabIndex = 11;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(46, 299);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(168, 65);
            this.button6.TabIndex = 10;
            this.button6.Text = "Add Record";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 522);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1417, 333);
            this.dataGridView1.TabIndex = 31;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(302, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 65);
            this.button1.TabIndex = 21;
            this.button1.Text = "Update Record";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(528, 299);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 65);
            this.button2.TabIndex = 22;
            this.button2.Text = "Delete Record";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(523, 180);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(173, 83);
            this.button3.TabIndex = 23;
            this.button3.Text = "Mark Attendance";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1417, 855);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.addStudentPanel);
            this.MinimumSize = new System.Drawing.Size(820, 520);
            this.Name = "Students";
            this.Load += new System.EventHandler(this.Students_Load);
            this.addStudentPanel.ResumeLayout(false);
            this.addStudentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel addStudentPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox stdEmailBox;
        private System.Windows.Forms.TextBox stdContactBox;
        private System.Windows.Forms.TextBox stdLastNameBox;
        private System.Windows.Forms.TextBox stdFirstNameBox;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox stdRegNoBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}