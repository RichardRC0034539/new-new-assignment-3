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
            // when a number hasnt been typed in it will show a messagebox with "type in a number"
            try
            {
                // reads numbers from textboxes 1 and 2
                double R1 = Convert.ToDouble(textBox1.Text);
                double R2 = Convert.ToDouble(textBox2.Text);

                // finds the total restistance
                double Total = R1 + R2;
                // shows the total resistance in label 1
                label1.Text = "Total Resistance = " + Total;
            } catch {
                MessageBox.Show("Type in a number.");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // when a number hasnt been typed in it will show a messagebox with "type in a number"
            try
            {
                // reads numbers from textboxes 3, 4 and 5
                double R1 = Convert.ToDouble(textBox3.Text);
                double R2 = Convert.ToDouble(textBox4.Text);
                double R3 = Convert.ToDouble(textBox5.Text);

                double Total = R1 + R2 + R3;
                label2.Text = "Total Resistance = " + Total;
                // shows the total resistance in label 2
            }
            catch
            {
                MessageBox.Show("Type in a number.");
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // when a number hasnt been typed in it will show a messagebox with "type in a number"
            try
            {
                // reads numbers from textboxes 6, 7, 8 and 9
                double R1 = Convert.ToDouble(textBox6.Text);
                double R2 = Convert.ToDouble(textBox7.Text);
                double R3 = Convert.ToDouble(textBox8.Text);
                double R4 = Convert.ToDouble(textBox9.Text);

                double Total = R1 + R2 + R3 + R4;
                label3.Text = "Total Resistance = " + Total;
                // shows the total resistance in label 3
            }
            catch
            {
                MessageBox.Show("Type in a number.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // when a number hasnt been typed in it will show a messagebox with "type in a number"
            try
            {
                // reads numbers from textboxes 10, 11, 12, 13 and 14
                double R1 = Convert.ToDouble(textBox10.Text);
                double R2 = Convert.ToDouble(textBox11.Text);
                double R3 = Convert.ToDouble(textBox12.Text);
                double R4 = Convert.ToDouble(textBox13.Text);
                double R5 = Convert.ToDouble(textBox14.Text);


                double Total = R1 + R2 + R3 + R4 + R5;
                label4.Text = "Total Resistance = " + Total;
                // shows the total resistance in label 4
            }
            catch
            {
                MessageBox.Show("Type in a number.");
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // when a number hasnt been typed in it will show a messagebox with "type in a number"
            try
            {
                // reads numbers from textboxes 15 and 16
                double R1 = Convert.ToDouble(textBox15.Text);
                double R2 = Convert.ToDouble(textBox16.Text);

                double Total = 1 / (1 / R1 + 1 / R2);
                label5.Text = "total Resistance = " + Total;
                // shows the total resistance in label 5
            }
            catch
            {
                MessageBox.Show("Type in a number.");
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // when a number hasnt been typed in it will show a messagebox with "type in a number"
            try
            {
                // reads numbers from textboxes 17, 18 and 19
                double R1 = Convert.ToDouble(textBox17.Text);
                double R2 = Convert.ToDouble(textBox18.Text);
                double R3 = Convert.ToDouble(textBox19.Text);

                double Total = 1 / (1 / R1 + 1 / R2 + 1 / R3);
                label6.Text = "total Resistance = " + Total;
                // shows the total resistance in label 6
            }
            catch
            {
                MessageBox.Show("Type in a number.");
            }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // when a number hasnt been typed in it will show a messagebox with "type in a number"
            try
            {
                // reads numbers from textboxes 20, 21, 22 and 23
                double R1 = Convert.ToDouble(textBox20.Text);
                double R2 = Convert.ToDouble(textBox21.Text);
                double R3 = Convert.ToDouble(textBox22.Text);
                double R4 = Convert.ToDouble(textBox23.Text);

                double Total = 1 / (1 / R1 + 1 / R2 + 1 / R3 + 1 / R4);
                label7.Text = "total Resistance = " + Total;
                // shows the total resistance in label 7
            }
            catch
            {
                MessageBox.Show("Type in a number.");
            }
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // when a number hasnt been typed in it will show a messagebox with "type in a number"
            try
            {
                // reads numbers from textboxes 24, 25, 26, 27 and 28
                double R1 = Convert.ToDouble(textBox24.Text);
                double R2 = Convert.ToDouble(textBox25.Text);
                double R3 = Convert.ToDouble(textBox26.Text);
                double R4 = Convert.ToDouble(textBox27.Text);
                double R5 = Convert.ToDouble(textBox28.Text);

                double Total = 1 / (1 / R1 + 1 / R2 + 1 / R3 + 1 / R4 + 1 / R5);
                label8.Text = "total Resistance = " + Total;
                // shows the total resistance in label 8
            }
            catch
            {
                MessageBox.Show("Type in a number.");
            }
            
        }
    }
}
