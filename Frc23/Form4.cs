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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dataSet1.Manager' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.managerTableAdapter.Fill(this.dataSet1.Manager);
            // TODO: Bu kod satırı 'dataSet1.Departman' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.departmanTableAdapter.Fill(this.dataSet1.Departman);
            // TODO: Bu kod satırı 'dataSet1.Manager' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.managerTableAdapter.Fill(this.dataSet1.Manager);
            // TODO: Bu kod satırı 'dataSet1.Departman' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.departmanTableAdapter.Fill(this.dataSet1.Departman);
            // TODO: Bu kod satırı 'dataSet1.Manager' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.managerTableAdapter.Fill(this.dataSet1.Manager);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int vp;
            int vp2;
            int.TryParse(textBox1.Text, out vp);
            int.TryParse(comboBox1.Text, out vp2);
            this.managerTableAdapter.Insert(vp, textBox2.Text, textBox3.Text, textBox4.Text, vp2);
            this.managerTableAdapter.Fill(this.dataSet1.Manager);
        }
    }
    }

