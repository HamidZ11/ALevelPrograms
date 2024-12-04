using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            double txt1 = Convert.ToDouble(v1.Text);
            double txt2 = Convert.ToDouble(v2.Text);
            double additionsum = txt1 + txt2;
            output.Text = Convert.ToString(additionsum);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double txt1 = Convert.ToDouble(v1.Text);
            double txt2 = Convert.ToDouble(v2.Text);
            double additionsum = txt1 - txt2;
            output.Text = Convert.ToString(additionsum);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double txt1 = Convert.ToDouble(v1.Text);
            double txt2 = Convert.ToDouble(v2.Text);
            double additionsum = txt1 / txt2;
            output.Text = Convert.ToString(additionsum);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double txt1 = Convert.ToDouble(v1.Text);
            double txt2 = Convert.ToDouble(v2.Text);
            double additionsum = txt1 * txt2;
            output.Text = Convert.ToString(additionsum);
        }
    }
}
