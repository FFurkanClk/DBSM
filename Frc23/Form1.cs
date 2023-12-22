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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 Department = new Form2();
            Department.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 Employee2 = new Form3();
            Employee2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 EComputer = new Form4();
           EComputer.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 Department = new Form5();
            Department.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 Enroll = new Form6();
            Enroll.ShowDialog();
        }
    }
}
