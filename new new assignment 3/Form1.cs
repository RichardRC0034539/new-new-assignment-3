using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace new_new_assignment_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double R1 = Convert.ToDouble(textBox1.Text);
            double R2 = Convert.ToDouble(textBox2.Text);

            double Total = R1 + R2;
            label1.Text = "Total Resistance = " + Total;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double R1 = Convert.ToDouble(textBox3.Text);
            double R2 = Convert.ToDouble(textBox4.Text);
            double R3 = Convert.ToDouble(textBox5.Text);

            double Total = R1 + R2 + R3;
            label2.Text = "Total Resistance = " + Total;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double R1 = Convert.ToDouble(textBox6.Text);
            double R2 = Convert.ToDouble(textBox7.Text);
            double R3 = Convert.ToDouble(textBox8.Text);
            double R4 = Convert.ToDouble(textBox9.Text);

            double Total = R1 + R2 + R3 + R4;
            label3.Text = "Total Resistance = " + Total;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double R1 = Convert.ToDouble(textBox10.Text);
            double R2 = Convert.ToDouble(textBox11.Text);
            double R3 = Convert.ToDouble(textBox12.Text);
            double R4 = Convert.ToDouble(textBox13.Text);
            double R5 = Convert.ToDouble(textBox14.Text);


            double Total = R1 + R2 + R3 + R4 + R5;
            label4.Text = "Total Resistance = " + Total;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double R1 = Convert.ToDouble(textBox15.Text);
            double R2 = Convert.ToDouble(textBox16.Text);

            double Total = 1 / (1 / R1 + 1 / R2);
            label5.Text = "total Resistance = " + Total;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double R1 = Convert.ToDouble(textBox17.Text);
            double R2 = Convert.ToDouble(textBox18.Text);
            double R3 = Convert.ToDouble(textBox19.Text);

            double Total = 1 / (1 / R1 + 1 / R2 + 1 / R3);
            label6.Text = "total Resistance = " + Total;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double R1 = Convert.ToDouble(textBox20.Text);
            double R2 = Convert.ToDouble(textBox21.Text);
            double R3 = Convert.ToDouble(textBox22.Text);
            double R4 = Convert.ToDouble(textBox23.Text);

            double Total = 1 / (1 / R1 + 1 / R2 + 1 / R3 + 1 / R4);
            label7.Text = "total Resistance = " + Total;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            double R1 = Convert.ToDouble(textBox24.Text);
            double R2 = Convert.ToDouble(textBox25.Text);
            double R3 = Convert.ToDouble(textBox26.Text);
            double R4 = Convert.ToDouble(textBox27.Text);
            double R5 = Convert.ToDouble(textBox28.Text);

            double Total = 1 / (1 / R1 + 1 / R2 + 1 / R3 + 1 / R4 + 1 / R5);
            label8.Text = "total Resistance = " + Total;
        }
    }
}
