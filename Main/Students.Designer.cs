namespace DBProject
{
    partial class Students
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
            this.button4 = new System.Windows.Forms.Button();
            this.addStudentPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addStudentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(443, 474);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(210, 75);
            this.button4.TabIndex = 29;
            this.button4.Text = "View All Students";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // addStudentPanel
            // 
            this.addStudentPanel.Controls.Add(this.label4);
            this.addStudentPanel.Controls.Add(this.label3);
            this.addStudentPanel.Controls.Add(this.label2);
            this.addStudentPanel.Controls.Add(this.label1);
            this.addStudentPanel.Controls.Add(this.textBox4);
            this.addStudentPanel.Controls.Add(this.textBox2);
            this.addStudentPanel.Controls.Add(this.textBox3);
            this.addStudentPanel.Controls.Add(this.textBox1);
            this.addStudentPanel.Controls.Add(this.button6);
            this.addStudentPanel.Location = new System.Drawing.Point(150, 12);
            this.addStudentPanel.Name = "addStudentPanel";
            this.addStudentPanel.Size = new System.Drawing.Size(571, 456);
            this.addStudentPanel.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Contact";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "First Name";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(262, 263);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(241, 31);
            this.textBox4.TabIndex = 14;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(262, 191);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(241, 31);
            this.textBox2.TabIndex = 13;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(262, 119);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(241, 31);
            this.textBox3.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(262, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(241, 31);
            this.textBox1.TabIndex = 11;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(229, 336);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(168, 65);
            this.button6.TabIndex = 10;
            this.button6.Text = "Add Record";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(96, 475);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(213, 75);
            this.button8.TabIndex = 27;
            this.button8.Text = "Add New Student";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, -2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(788, 453);
            this.dataGridView1.TabIndex = 30;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 579);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.addStudentPanel);
            this.Controls.Add(this.button8);
            this.Name = "Students";
            this.Text = "Students";
            this.Load += new System.EventHandler(this.Students_Load);
            this.addStudentPanel.ResumeLayout(false);
            this.addStudentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel addStudentPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}