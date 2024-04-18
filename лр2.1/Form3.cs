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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Проверка корректности ввода параметров
            if (!double.TryParse(textBox1.Text, out double xStart) ||
                !double.TryParse(textBox2.Text, out double xEnd) ||
                !double.TryParse(textBox3.Text, out double step) ||
                !double.TryParse(textBox4.Text, out double a) ||
                !double.TryParse(textBox5.Text, out double b) ||
                !double.TryParse(textBox6.Text, out double c))
            {
                MessageBox.Show("Некорректный ввод параметров.");
                return;
            }

            // Создание таблицы для вывода результатов
            DataTable table = new DataTable();
            table.Columns.Add("X", typeof(double));
            table.Columns.Add("F", typeof(double));

            // Вычисление и добавление значений функции в таблицу
            for (double x = xStart; x <= xEnd; x += step)
            {
                double result;
                if (x < 5 && c != 0)
                {
                    result = -a * x * x - b;
                }
                else if (x > 5 && c == 0)
                {
                    result = (x - a) / x;
                }
                else
                {
                    if (c == 0)
                    {
                        MessageBox.Show("Деление на ноль!");
                        return;
                    }
                    result = -x / c;
                }

                if (((int)a & (int)b) % 2 != 0 || ((int)a & (int)c) % 2 != 0)
                {
                    result = Math.Round(result, MidpointRounding.AwayFromZero);
                }

                table.Rows.Add(x, result);
            }

            // Отображение результатов в DataGridView
            dataGridView1.DataSource = table;
        }
    }
}
