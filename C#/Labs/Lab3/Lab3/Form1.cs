using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        private string currentFileName;

        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialog2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                using (FileStream fs = File.Create(saveFileDialog1.FileName))
                {
                    // Создаем новый файл
                }
            }
        }
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                this.Text = Path.GetFileName(openFileDialog1.FileName);
            }
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                currentFileName = saveFileDialog1.FileName;
                this.Text = currentFileName;
                richTextBox1.SaveFile(currentFileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentFileName != null)
            {
                richTextBox1.SaveFile(currentFileName, RichTextBoxStreamType.PlainText);
            }
            else
            {
                сохранитьКакToolStripMenuItem_Click(sender, e);
            }

        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
            }
        }

        private void цветФонаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.BackColor = colorDialog1.Color;
            }
        }
    }
}
