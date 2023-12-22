
namespace Frc23
{
    partial class Form4
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.managerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.managerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.managerLNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.managerPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmanIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.managerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Frc23.DataSet1();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.departmanBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.managerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmanTableAdapter = new Frc23.DataSet1TableAdapters.DepartmanTableAdapter();
            this.managerBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.managerTableAdapter = new Frc23.DataSet1TableAdapters.ManagerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmanBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.managerIDDataGridViewTextBoxColumn,
            this.managerNameDataGridViewTextBoxColumn,
            this.managerLNameDataGridViewTextBoxColumn,
            this.managerPhoneDataGridViewTextBoxColumn,
            this.departmanIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.managerBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(51, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(557, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // managerIDDataGridViewTextBoxColumn
            // 
            this.managerIDDataGridViewTextBoxColumn.DataPropertyName = "Manager_ID";
            this.managerIDDataGridViewTextBoxColumn.HeaderText = "Manager_ID";
            this.managerIDDataGridViewTextBoxColumn.Name = "managerIDDataGridViewTextBoxColumn";
            // 
            // managerNameDataGridViewTextBoxColumn
            // 
            this.managerNameDataGridViewTextBoxColumn.DataPropertyName = "Manager_Name";
            this.managerNameDataGridViewTextBoxColumn.HeaderText = "Manager_Name";
            this.managerNameDataGridViewTextBoxColumn.Name = "managerNameDataGridViewTextBoxColumn";
            // 
            // managerLNameDataGridViewTextBoxColumn
            // 
            this.managerLNameDataGridViewTextBoxColumn.DataPropertyName = "Manager_LName";
            this.managerLNameDataGridViewTextBoxColumn.HeaderText = "Manager_LName";
            this.managerLNameDataGridViewTextBoxColumn.Name = "managerLNameDataGridViewTextBoxColumn";
            // 
            // managerPhoneDataGridViewTextBoxColumn
            // 
            this.managerPhoneDataGridViewTextBoxColumn.DataPropertyName = "Manager_Phone";
            this.managerPhoneDataGridViewTextBoxColumn.HeaderText = "Manager_Phone";
            this.managerPhoneDataGridViewTextBoxColumn.Name = "managerPhoneDataGridViewTextBoxColumn";
            // 
            // departmanIDDataGridViewTextBoxColumn
            // 
            this.departmanIDDataGridViewTextBoxColumn.DataPropertyName = "Departman_ID";
            this.departmanIDDataGridViewTextBoxColumn.HeaderText = "Departman_ID";
            this.departmanIDDataGridViewTextBoxColumn.Name = "departmanIDDataGridViewTextBoxColumn";
            // 
            // managerBindingSource1
            // 
            this.managerBindingSource1.DataMember = "Manager";
            this.managerBindingSource1.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(135, 206);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(135, 241);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(135, 278);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 20);
            this.textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(135, 316);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(121, 20);
            this.textBox4.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.departmanBindingSource1;
            this.comboBox1.DisplayMember = "Departman_ID";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(135, 357);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.ValueMember = "Departman_ID";
            // 
            // departmanBindingSource1
            // 
            this.departmanBindingSource1.DataMember = "Departman";
            this.departmanBindingSource1.DataSource = this.dataSet1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(333, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "INSERT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // managerBindingSource
            // 
            this.managerBindingSource.DataMember = "Manager";
            this.managerBindingSource.DataSource = this.dataSet1;
            // 
            // departmanBindingSource
            // 
            this.departmanBindingSource.DataMember = "Departman";
            this.departmanBindingSource.DataSource = this.dataSet1;
            // 
            // departmanTableAdapter
            // 
            this.departmanTableAdapter.ClearBeforeFill = true;
            // 
            // managerBindingSource2
            // 
            this.managerBindingSource2.DataMember = "Manager";
            this.managerBindingSource2.DataSource = this.dataSet1;
            // 
            // managerTableAdapter
            // 
            this.managerTableAdapter.ClearBeforeFill = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmanBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource managerBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn managerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn managerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn managerLNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn managerPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmanIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource departmanBindingSource;
        private System.Windows.Forms.BindingSource managerBindingSource1;
        private System.Windows.Forms.BindingSource departmanBindingSource1;
        private DataSet1TableAdapters.DepartmanTableAdapter departmanTableAdapter;
        private System.Windows.Forms.BindingSource managerBindingSource2;
        private DataSet1TableAdapters.ManagerTableAdapter managerTableAdapter;
    }
}