using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Получение исходных данных из TextBox 
            try
            {
                double x = Convert.ToDouble(textBox2.Text);
                double y = Convert.ToDouble(textBox1.Text);
                double z = Convert.ToDouble(textBox3.Text);
                double u;
            
            // Ввод исходных данных в окно результатов
            textBox4.Text = "Результаты работы программы " + "Bogdan Sh." +
            Environment.NewLine;
            textBox4.Text += "При X = " + textBox2.Text + Environment.NewLine;
            textBox4.Text += "При Y = " + textBox1.Text + Environment.NewLine;
            textBox4.Text += "При Z = " + textBox3.Text + Environment.NewLine;
            // Вычисление выражения double u;
           
                double fx;
                if (radioButton1.Checked)
                {
                    fx = Math.Pow(x, 2);
                    Console.WriteLine("STEpen");
                }
                else
                {
                    fx = Math.Exp(x);
                    Console.WriteLine("EXPONENT");
                }
                if (x > y)
                {
                    double tmp = (fx - y);
                    u = (Math.Pow(tmp, 3) + Math.Atan(Math.Pow(x, 2)));
                    textBox4.Text += "U = " + u.ToString() + Environment.NewLine;
                }
                else if (y > x)
                {
                    double tmp = (y - fx);
                    u = (Math.Pow(tmp, 3) + Math.Atan(Math.Pow(x, 2)));
                    textBox4.Text += "U = " + u.ToString() + Environment.NewLine;
                }
                else if (y == x)
                {
                    double tmp = (fx + y);
                    u = (Math.Pow(tmp, 3) + 0.5); // Вывод результата
                    textBox4.Text += "U = " + u.ToString() + Environment.NewLine;
                }
            } catch (FormatException) 
            {
                MessageBox.Show("Работа программы прекращена! Неверные данные!!!");
            }
         


        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();




        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}