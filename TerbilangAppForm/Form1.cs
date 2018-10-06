using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TerbilangLibrary;

namespace TerbilangAppForm
{
    public partial class Form1 : Form
    {
        Terbilang terbilang = new Terbilang();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1Nominal.Text);
            //label3Hasil.Text = Convert.ToString(terbilang.TerbilangIndonesia(a));
            richTextBox1.Text = Convert.ToString(terbilang.TerbilangIndonesia(a));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
