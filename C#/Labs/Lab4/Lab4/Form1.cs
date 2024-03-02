using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        int op;
        double a, b;
        double c;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += 9;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += 0;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(',')) textBox1.Text += ',';
        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                op = 1;
                a = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
            }

            catch { }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            b = Convert.ToDouble(textBox1.Text);
            switch (op)
            {
                case 1: c = a + b; break;
                case 2: c = a - b; break;
                case 3: if (b != 0)
                    {
                        c = a / b;
                    }
                    else
                    {
                        MessageBox.Show("Ошибка: Деление на ноль недопустимо");
                        return;
                    }
                    break;
                case 4: c = a * b; break;
                
            }
            textBox1.Text = c.ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                op = 2;
                a = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
            }

            catch { }
        }
        
        private void button20_Click(object sender, EventArgs e)
        {
            try
            {
                op = 3;
                a = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
            }

            catch { }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                op = 4;
                a = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
            }

            catch { }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            b = Convert.ToDouble(textBox1.Text);
            textBox1.Text = Convert.ToString(-b);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            b = Convert.ToDouble(textBox1.Text);
            textBox1.Text = Convert.ToString(Math.Sqrt(b));
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                b = Convert.ToDouble(textBox1.Text);

                if (b > 0)
                {
                    textBox1.Text = Convert.ToString(1 / b);
                }
                else
                {
                    MessageBox.Show("Ошибка: Деление на ноль и менее недопустимо");
                    return;
                }
            }

            catch { }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}
