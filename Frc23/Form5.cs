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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dataSet1.EComputer' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.eComputerTableAdapter.Fill(this.dataSet1.EComputer);
            // TODO: Bu kod satırı 'dataSet1.EComputer' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.eComputerTableAdapter.Fill(this.dataSet1.EComputer);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int vp;
            int.TryParse(textBox1.Text, out vp);
            this.eComputerTableAdapter.Insert(vp, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
            this.eComputerTableAdapter.Fill(this.dataSet1.EComputer);
        }
    }
}
