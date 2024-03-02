using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labs7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            listBox4.SelectionMode = SelectionMode.One;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null && listBox2.Items.Count > listBox1.SelectedIndex)
            {
                listBox3.Items.Add(listBox1.SelectedItem);
                listBox4.Items.Add(listBox2.Items[listBox1.SelectedIndex]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var item in listBox1.SelectedItems)
            {
                listBox3.Items.Add(item);
            }

            foreach (int index in listBox1.SelectedIndices)
            {
                if (listBox2.Items.Count > index)
                {
                    listBox4.Items.Add(listBox2.Items[index]);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int Sum = 0;
            foreach (var item in listBox4.Items)
            {
                int number;
                if (int.TryParse(item.ToString(), out number))
                {
                    Sum += number;
                }
            }
            textBox1.Text = Sum.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox3.SelectedItem != null && listBox4.Items.Count > listBox3.SelectedIndex)
            {
                listBox4.Items.RemoveAt(listBox3.SelectedIndex);
                listBox3.Items.RemoveAt(listBox3.SelectedIndex);
            }
            int Sum = 0;
            foreach (var item in listBox4.Items)
            {
                int number;
                if (int.TryParse(item.ToString(), out number))
                {
                    Sum += number;
                }
            }
            textBox1.Text = Sum.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int index = listBox1.FindString(comboBox1.SelectedItem.ToString());
            if (index != -1)
            {
                textBox2.Text = listBox2.Items[index].ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines("товарка.txt", Encoding.Default); // Код изменен, из-за проблем с кодировкой
            for (int i = 0; i < lines.Length; i++)
            {
                if (i % 2 == 0)
                {
                    listBox1.Items.Add(lines[i]);
                    comboBox1.Items.Add(lines[i]);
                }
                else
                {
                    listBox2.Items.Add(lines[i]);
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                button1.Enabled = false;
                listBox1.SelectionMode = SelectionMode.MultiExtended;

                button2.Enabled = true;
            }
            else
            {
                button1.Enabled = true;
                listBox1.SelectionMode = SelectionMode.One;

                button2.Enabled = false;
            }
        }
    }
}
