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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Получаем значения из текстовых полей
            double r = double.Parse(textBox1.Text);
            double x = double.Parse(textBox2.Text);
            double y = double.Parse(textBox3.Text);
            double b = double.Parse(textBox4.Text);

            // Проверяем, пересекаются ли круг и прямая
            bool intersect = Math.Abs(y - b) <= r;

            // Выводим результат на форму
            if (intersect)
            {
                label3.Text = "Круг и прямая пересекаются";
            }
            else
            {
                label3.Text = "Круг и прямая не пересекаются";
            }
        }
    }
}
