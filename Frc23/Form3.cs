using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frc23
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dataSet1.Manager' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.managerTableAdapter.Fill(this.dataSet1.Manager);
            // TODO: Bu kod satırı 'dataSet1.Employee' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.employeeTableAdapter.Fill(this.dataSet1.Employee);
            // TODO: Bu kod satırı 'dataSet1.Departman' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.departmanTableAdapter.Fill(this.dataSet1.Departman);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int vp;
            int vp2;
            int vp3;
            int.TryParse(textBox4.Text, out vp);
            int.TryParse(comboBox1.Text, out vp2);
            int.TryParse(comboBox2.Text, out vp3);
            this.employeeTableAdapter.Insert(vp, textBox1.Text, textBox2.Text, textBox3.Text, vp2,vp3);
            this.employeeTableAdapter.Fill(this.dataSet1.Employee);

            Form3 form3 = this;
            form3.employeeTableAdapter.Fill(dataSet1.Employee);

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
