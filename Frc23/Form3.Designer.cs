
namespace Frc23
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            this.dataSet1 = new Frc23.DataSet1();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.departmanBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.departmanTableAdapter = new Frc23.DataSet1TableAdapters.DepartmanTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeLNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeAgeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmanIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.managerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.managerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmanBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.employeeBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.employeeBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.employeeBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new Frc23.DataSet1TableAdapters.EmployeeTableAdapter();
            this.managerTableAdapter = new Frc23.DataSet1TableAdapters.ManagerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmanBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmanBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(120, 212);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(120, 251);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(120, 287);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 20);
            this.textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(120, 177);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(121, 20);
            this.textBox4.TabIndex = 4;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.departmanBindingSource2;
            this.comboBox1.DisplayMember = "Departman_ID";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(120, 373);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.ValueMember = "Departman_ID";
            // 
            // departmanBindingSource2
            // 
            this.departmanBindingSource2.DataMember = "Departman";
            this.departmanBindingSource2.DataSource = this.dataSet1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(166, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "INSERT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // departmanTableAdapter
            // 
            this.departmanTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIDDataGridViewTextBoxColumn,
            this.employeeNameDataGridViewTextBoxColumn,
            this.employeeLNameDataGridViewTextBoxColumn,
            this.employeeAgeDataGridViewTextBoxColumn,
            this.departmanIDDataGridViewTextBoxColumn,
            this.managerIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.employeeBindingSource5;
            this.dataGridView1.Location = new System.Drawing.Point(12, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(659, 150);
            this.dataGridView1.TabIndex = 7;
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "Employee_ID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "Employee_ID";
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            // 
            // employeeNameDataGridViewTextBoxColumn
            // 
            this.employeeNameDataGridViewTextBoxColumn.DataPropertyName = "Employee_Name";
            this.employeeNameDataGridViewTextBoxColumn.HeaderText = "Employee_Name";
            this.employeeNameDataGridViewTextBoxColumn.Name = "employeeNameDataGridViewTextBoxColumn";
            // 
            // employeeLNameDataGridViewTextBoxColumn
            // 
            this.employeeLNameDataGridViewTextBoxColumn.DataPropertyName = "Employee_LName";
            this.employeeLNameDataGridViewTextBoxColumn.HeaderText = "Employee_LName";
            this.employeeLNameDataGridViewTextBoxColumn.Name = "employeeLNameDataGridViewTextBoxColumn";
            // 
            // employeeAgeDataGridViewTextBoxColumn
            // 
            this.employeeAgeDataGridViewTextBoxColumn.DataPropertyName = "Employee_Age";
            this.employeeAgeDataGridViewTextBoxColumn.HeaderText = "Employee_Age";
            this.employeeAgeDataGridViewTextBoxColumn.Name = "employeeAgeDataGridViewTextBoxColumn";
            // 
            // departmanIDDataGridViewTextBoxColumn
            // 
            this.departmanIDDataGridViewTextBoxColumn.DataPropertyName = "Departman_ID";
            this.departmanIDDataGridViewTextBoxColumn.HeaderText = "Departman_ID";
            this.departmanIDDataGridViewTextBoxColumn.Name = "departmanIDDataGridViewTextBoxColumn";
            // 
            // managerIDDataGridViewTextBoxColumn
            // 
            this.managerIDDataGridViewTextBoxColumn.DataPropertyName = "Manager_ID";
            this.managerIDDataGridViewTextBoxColumn.HeaderText = "Manager_ID";
            this.managerIDDataGridViewTextBoxColumn.Name = "managerIDDataGridViewTextBoxColumn";
            // 
            // employeeBindingSource5
            // 
            this.employeeBindingSource5.DataMember = "Employee";
            this.employeeBindingSource5.DataSource = this.dataSet1;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.managerBindingSource;
            this.comboBox2.DisplayMember = "Manager_ID";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(120, 335);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 8;
            this.comboBox2.ValueMember = "Manager_ID";
            // 
            // managerBindingSource
            // 
            this.managerBindingSource.DataMember = "Manager";
            this.managerBindingSource.DataSource = this.dataSet1;
            // 
            // employeeBindingSource1
            // 
            this.employeeBindingSource1.DataMember = "Employee";
            this.employeeBindingSource1.DataSource = this.dataSet1;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.dataSet1;
            // 
            // departmanBindingSource
            // 
            this.departmanBindingSource.DataMember = "Departman";
            this.departmanBindingSource.DataSource = this.dataSet1;
            // 
            // departmanBindingSource1
            // 
            this.departmanBindingSource1.DataMember = "Departman";
            this.departmanBindingSource1.DataSource = this.dataSet1;
            // 
            // employeeBindingSource2
            // 
            this.employeeBindingSource2.DataMember = "Employee";
            this.employeeBindingSource2.DataSource = this.dataSet1;
            // 
            // employeeBindingSource3
            // 
            this.employeeBindingSource3.DataMember = "Employee";
            this.employeeBindingSource3.DataSource = this.dataSet1;
            // 
            // employeeBindingSource4
            // 
            this.employeeBindingSource4.DataMember = "Employee";
            this.employeeBindingSource4.DataSource = this.dataSet1;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // managerTableAdapter
            // 
            this.managerTableAdapter.ClearBeforeFill = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmanBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmanBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource departmanBindingSource;
        private DataSet1TableAdapters.DepartmanTableAdapter departmanTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource employeeBindingSource1;
        private DataSet1TableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.BindingSource departmanBindingSource1;
        private System.Windows.Forms.BindingSource departmanBindingSource2;
        private System.Windows.Forms.BindingSource employeeBindingSource2;
        private System.Windows.Forms.BindingSource employeeBindingSource3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeLNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeAgeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmanIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn managerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource employeeBindingSource4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource managerBindingSource;
        private DataSet1TableAdapters.ManagerTableAdapter managerTableAdapter;
        private System.Windows.Forms.BindingSource employeeBindingSource5;
    }
}