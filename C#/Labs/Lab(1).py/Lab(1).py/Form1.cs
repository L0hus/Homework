using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1_.py
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Top = 20;
            label1.Left = 20;
            label2.Top = 117;
            label2.Left = 622;
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Left += 3;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            this.Height *= 2;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            this.Height /= 2;
        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            label2.Top += 3;
        }
    }
}
