﻿namespace DBProject
{
    partial class Assesment
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(91)))), ((int)(((byte)(100)))));
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 21;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(201)))), ((int)(((byte)(202)))));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.button4.Location = new System.Drawing.Point(568, 61);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(141, 66);
            this.button4.TabIndex = 31;
            this.button4.Text = "Add Component";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Open_Componenet_Form);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 256);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(800, 194);
            this.dataGridView1.TabIndex = 30;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Cell_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(201)))), ((int)(((byte)(202)))));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.button3.Location = new System.Drawing.Point(438, 166);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 66);
            this.button3.TabIndex = 29;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Delete_Data);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(201)))), ((int)(((byte)(202)))));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.button2.Location = new System.Drawing.Point(258, 166);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 66);
            this.button2.TabIndex = 28;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Update_Data);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.label3.Location = new System.Drawing.Point(36, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 25);
            this.label3.TabIndex = 27;
            this.label3.Text = "Total Weightage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.label2.Location = new System.Drawing.Point(57, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "Total Marks";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(219, 113);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(265, 31);
            this.textBox3.TabIndex = 25;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(219, 58);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(265, 31);
            this.textBox2.TabIndex = 24;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(219, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(265, 31);
            this.textBox1.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.label1.Location = new System.Drawing.Point(90, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Title";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(201)))), ((int)(((byte)(202)))));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.button1.Location = new System.Drawing.Point(79, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 66);
            this.button1.TabIndex = 21;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Add_Data);
            // 
            // Assesment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Assesment";
            this.Text = "Assesment";
            this.Load += new System.EventHandler(this.Assesment_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}