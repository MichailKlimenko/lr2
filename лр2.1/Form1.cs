using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace лр2._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Метод для вычисления наибольшего общего делителя (НОД)
        private int FindGCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        // Метод для вычисления наименьшего общего кратного (НОК)
        private int FindLCM(int a, int b)
        {
            return (a * b) / FindGCD(a, b);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Считываем значения m и n из текстовых полей
                int m = int.Parse(textBox1.Text);
                int n = int.Parse(textBox2.Text);

                // Вычисляем НОК и выводим результат в лейбл
                int lcm = FindLCM(m, n);
                label3.Text = $"НОК({m}, {n}) = {lcm}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Пожалуйста, введите целые числа в оба поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void задание2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void задание3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }
    }
}
