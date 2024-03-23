﻿namespace DBProject
{
    partial class EvaluateResult
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
            this.label1 = new System.Windows.Forms.Label();
            this.StudentComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.ComponentComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RubricLevelComboBox = new System.Windows.Forms.ComboBox();
            this.RubricDetailComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AssessmentComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 33;
            this.label1.Text = "Component";
            // 
            // StudentComboBox
            // 
            this.StudentComboBox.FormattingEnabled = true;
            this.StudentComboBox.Location = new System.Drawing.Point(224, 33);
            this.StudentComboBox.Name = "StudentComboBox";
            this.StudentComboBox.Size = new System.Drawing.Size(209, 33);
            this.StudentComboBox.TabIndex = 32;
            this.StudentComboBox.SelectedIndexChanged += new System.EventHandler(this.StudentComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "Student";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 298);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(875, 230);
            this.dataGridView1.TabIndex = 27;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(666, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 63);
            this.button1.TabIndex = 26;
            this.button1.Text = "Evaluate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ComponentComboBox
            // 
            this.ComponentComboBox.FormattingEnabled = true;
            this.ComponentComboBox.Location = new System.Drawing.Point(224, 81);
            this.ComponentComboBox.Name = "ComponentComboBox";
            this.ComponentComboBox.Size = new System.Drawing.Size(209, 33);
            this.ComponentComboBox.TabIndex = 34;
            this.ComponentComboBox.SelectedValueChanged += new System.EventHandler(this.ComponentComboBox_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 25);
            this.label3.TabIndex = 35;
            this.label3.Text = "Rubric Level";
            // 
            // RubricLevelComboBox
            // 
            this.RubricLevelComboBox.FormattingEnabled = true;
            this.RubricLevelComboBox.Location = new System.Drawing.Point(415, 146);
            this.RubricLevelComboBox.Name = "RubricLevelComboBox";
            this.RubricLevelComboBox.Size = new System.Drawing.Size(209, 33);
            this.RubricLevelComboBox.TabIndex = 36;
            this.RubricLevelComboBox.SelectedValueChanged += new System.EventHandler(this.RubricLevelComboBox_SelectedValueChanged);
            // 
            // RubricDetailComboBox
            // 
            this.RubricDetailComboBox.FormattingEnabled = true;
            this.RubricDetailComboBox.Location = new System.Drawing.Point(635, 84);
            this.RubricDetailComboBox.Name = "RubricDetailComboBox";
            this.RubricDetailComboBox.Size = new System.Drawing.Size(209, 33);
            this.RubricDetailComboBox.TabIndex = 40;
            this.RubricDetailComboBox.SelectedValueChanged += new System.EventHandler(this.RubricDetailComboBox_SelectedValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(480, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 25);
            this.label5.TabIndex = 39;
            this.label5.Text = "Rubric Detail";
            // 
            // AssessmentComboBox
            // 
            this.AssessmentComboBox.FormattingEnabled = true;
            this.AssessmentComboBox.Location = new System.Drawing.Point(635, 36);
            this.AssessmentComboBox.Name = "AssessmentComboBox";
            this.AssessmentComboBox.Size = new System.Drawing.Size(209, 33);
            this.AssessmentComboBox.TabIndex = 38;
            this.AssessmentComboBox.SelectedValueChanged += new System.EventHandler(this.AssessmentComboBox_SelectedValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(480, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 25);
            this.label6.TabIndex = 37;
            this.label6.Text = "Assessment";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(123, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 25);
            this.label7.TabIndex = 43;
            this.label7.Text = "Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(224, 221);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(391, 31);
            this.dateTimePicker1.TabIndex = 44;
            // 
            // EvaluateResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 528);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.RubricDetailComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AssessmentComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RubricLevelComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ComponentComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StudentComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "EvaluateResult";
            this.Text = "EvaluateResult";
            this.Load += new System.EventHandler(this.EvaluateResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox StudentComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox ComponentComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox RubricLevelComboBox;
        private System.Windows.Forms.ComboBox RubricDetailComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox AssessmentComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}