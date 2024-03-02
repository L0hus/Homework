using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown1.Minimum = 1;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked) textBox4.Text = radioButton1.Text;
            textBox4.Text += " " + comboBox1.Text + "!" + "\r\n";
            textBox4.Text += "Приглашаю вас ";
            if (checkBox2.Checked) textBox4.Text += checkBox2.Text;
            textBox4.Text += "\r\n" + "на" + textBox1.Text + " ";
            textBox4.Text += monthCalendar1.SelectionStart.ToShortDateString() + "\r\n";
            textBox4.Text += textBox2.Text + "\r\n";
            if (checkBox1.Checked) textBox4.Text += checkBox1.Text + " ";
            textBox4.Text += textBox3.Text + "\r\n" + "\r\n";
            button2.Enabled = true;
            button3.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (i < (int)numericUpDown1.Value - 1)
            {
                if (radioButton1.Checked) textBox4.Text += radioButton1.Text;
                textBox4.Text += " " + comboBox1.Text + "!" + "\r\n";
                textBox4.Text += "Приглашаю вас ";
                if (checkBox2.Checked) textBox4.Text += checkBox2.Text;
                textBox4.Text += "\r\n" + "на" + textBox1.Text + " ";
                textBox4.Text += monthCalendar1.SelectionStart.ToShortDateString() + "\r\n";
                textBox4.Text += textBox2.Text + "\r\n";
                if (checkBox1.Checked) textBox4.Text += checkBox1.Text + " ";
                textBox4.Text += textBox3.Text + "\r\n" + "\r\n";
                button2.Enabled = true;
                button3.Enabled = true;
                i++;
            }

            textBox4.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
            textBox4.Enabled = true;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked) textBox4.Text = radioButton1.Text;
            textBox4.Text += " " + comboBox1.Text + "!" + "\r\n";
            textBox4.Text += "Приглашаю вас ";
            if (checkBox2.Checked) textBox4.Text += checkBox2.Text;
            textBox4.Text += "\r\n" + "на" + textBox1.Text + " ";
            textBox4.Text += monthCalendar1.SelectionStart.ToShortDateString() + "\r\n";
            textBox4.Text += textBox2.Text + "\r\n";
            if (checkBox1.Checked) textBox4.Text += checkBox1.Text + " ";
            textBox4.Text += textBox3.Text + "\r\n" + "\r\n";
            button2.Enabled = true;
            button3.Enabled = true;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (i < (int)numericUpDown1.Value - 1)
            {
                if (radioButton1.Checked) textBox4.Text += radioButton1.Text;
                textBox4.Text += " " + comboBox1.Text + "!" + "\r\n";
                textBox4.Text += "Приглашаю вас ";
                if (checkBox2.Checked) textBox4.Text += checkBox2.Text;
                textBox4.Text += "\r\n" + "на" + textBox1.Text + " ";
                textBox4.Text += monthCalendar1.SelectionStart.ToShortDateString() + "\r\n";
                textBox4.Text += textBox2.Text + "\r\n";
                if (checkBox1.Checked) textBox4.Text += checkBox1.Text + " ";
                textBox4.Text += textBox3.Text + "\r\n" + "\r\n";
                button2.Enabled = true;
                button3.Enabled = true;
                i++;
            }

            textBox4.Enabled = false;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
            textBox4.Enabled = true;
        }
    }
}
