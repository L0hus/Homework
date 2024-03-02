using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double angle; // угол броска
        double v0; // начальная скорость
        double g = 9.81; // ускорение свободного падения
        double deltaT = 0.05; // интервал времени
        double x0, y0; // координаты объекта
        double vHorizontal, vVertical; // компоненты скорости
        double targetX, targetY; // координаты мишени
        bool targetHit; // флаг попадания в мишень

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out angle))
            {
                angle = angle * Math.PI / 180; // угол в радианах
                v0 = 100; // начальная скорость
                x0 = 20; // начальное положение по оси X
                y0 = 380; // начальное положение по оси Y
                vHorizontal = v0 * Math.Cos(angle); // вычисление горизонтальной составляющей скорости
                vVertical = v0 * Math.Sin(angle); // вычисление вертикальной составляющей скорости
                targetX = 500; // задаем координаты мишени
                targetY = 200;
                targetHit = false; // сброс флага попадания в мишень
                pictureBox1.Size = new Size(55, 55); // устанавливаем размер снаряда
                pictureBox2.Size = new Size(85, 23); // устанавливаем размер мишени
                pictureBox2.Location = new Point((int)targetX, (int)targetY); // устанавливаем положение мишени на форме
                pictureBox1.Location = new Point((int)x0, (int)y0);
                timer1.Enabled = true;
            }
            else
            {
                MessageBox.Show("Введите корректное значение угла");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            x0 += vHorizontal * deltaT;
            y0 -= vVertical * deltaT;
            vVertical -= g * deltaT;
            pictureBox1.Location = new Point((int)x0, (int)y0);

            if (!targetHit)
            {
                if (x0 > targetX && x0 < targetX + pictureBox2.Width && y0 > targetY && y0 < targetY + pictureBox2.Height)
                {
                    targetHit = true;
                    MessageBox.Show("Попадание в мишень!");
                    timer1.Enabled = false;
                }
            }

            if (y0 >= 400)
            {
                timer1.Enabled = false;
            }
        }
    }
}
