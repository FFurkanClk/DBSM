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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dataSet1.EComputer' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.eComputerTableAdapter.Fill(this.dataSet1.EComputer);
            // TODO: Bu kod satırı 'dataSet1.Employee' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.employeeTableAdapter.Fill(this.dataSet1.Employee);
            // TODO: Bu kod satırı 'dataSet1.Enroll' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.enrollTableAdapter.Fill(this.dataSet1.Enroll);
            // TODO: Bu kod satırı 'dataSet1.Enroll' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.enrollTableAdapter.Fill(this.dataSet1.Enroll);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
