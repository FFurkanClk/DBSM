
namespace Frc23
{
    partial class Form5
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
            this.eComputerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eComputerBrandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eComputerModelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eComputerMACDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eComputerİPaddDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eComputerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Frc23.DataSet1();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.eComputerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.eComputerTableAdapter = new Frc23.DataSet1TableAdapters.EComputerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eComputerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eComputerBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eComputerIDDataGridViewTextBoxColumn,
            this.eComputerBrandDataGridViewTextBoxColumn,
            this.eComputerModelDataGridViewTextBoxColumn,
            this.eComputerMACDataGridViewTextBoxColumn,
            this.eComputerİPaddDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.eComputerBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(27, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // eComputerIDDataGridViewTextBoxColumn
            // 
            this.eComputerIDDataGridViewTextBoxColumn.DataPropertyName = "EComputer_ID";
            this.eComputerIDDataGridViewTextBoxColumn.HeaderText = "EComputer_ID";
            this.eComputerIDDataGridViewTextBoxColumn.Name = "eComputerIDDataGridViewTextBoxColumn";
            // 
            // eComputerBrandDataGridViewTextBoxColumn
            // 
            this.eComputerBrandDataGridViewTextBoxColumn.DataPropertyName = "EComputer_Brand";
            this.eComputerBrandDataGridViewTextBoxColumn.HeaderText = "EComputer_Brand";
            this.eComputerBrandDataGridViewTextBoxColumn.Name = "eComputerBrandDataGridViewTextBoxColumn";
            // 
            // eComputerModelDataGridViewTextBoxColumn
            // 
            this.eComputerModelDataGridViewTextBoxColumn.DataPropertyName = "EComputer_Model";
            this.eComputerModelDataGridViewTextBoxColumn.HeaderText = "EComputer_Model";
            this.eComputerModelDataGridViewTextBoxColumn.Name = "eComputerModelDataGridViewTextBoxColumn";
            // 
            // eComputerMACDataGridViewTextBoxColumn
            // 
            this.eComputerMACDataGridViewTextBoxColumn.DataPropertyName = "EComputer_MAC";
            this.eComputerMACDataGridViewTextBoxColumn.HeaderText = "EComputer_MAC";
            this.eComputerMACDataGridViewTextBoxColumn.Name = "eComputerMACDataGridViewTextBoxColumn";
            // 
            // eComputerİPaddDataGridViewTextBoxColumn
            // 
            this.eComputerİPaddDataGridViewTextBoxColumn.DataPropertyName = "EComputer_İPadd";
            this.eComputerİPaddDataGridViewTextBoxColumn.HeaderText = "EComputer_İPadd";
            this.eComputerİPaddDataGridViewTextBoxColumn.Name = "eComputerİPaddDataGridViewTextBoxColumn";
            // 
            // eComputerBindingSource
            // 
            this.eComputerBindingSource.DataMember = "EComputer";
            this.eComputerBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(92, 222);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(92, 248);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(92, 274);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(92, 300);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 4;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(92, 335);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(246, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "INSERT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // eComputerBindingSource1
            // 
            this.eComputerBindingSource1.DataMember = "EComputer";
            this.eComputerBindingSource1.DataSource = this.dataSet1;
            // 
            // eComputerTableAdapter
            // 
            this.eComputerTableAdapter.ClearBeforeFill = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eComputerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eComputerBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource eComputerBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn eComputerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eComputerBrandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eComputerModelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eComputerMACDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eComputerİPaddDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource eComputerBindingSource1;
        private DataSet1TableAdapters.EComputerTableAdapter eComputerTableAdapter;
    }
}