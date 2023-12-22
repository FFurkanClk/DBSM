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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dataSet1.Departman' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.departmanTableAdapter.Fill(this.dataSet1.Departman);
            // TODO: Bu kod satırı 'dataSet1.Manager' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int value;
            int.TryParse(textBox1.Text, out value);
            this.departmanTableAdapter.Insert(value, textBox2.Text);
            this.departmanTableAdapter.Fill(this.dataSet1.Departman);
        }
    }
}
