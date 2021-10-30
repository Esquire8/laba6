using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(textBox1.Text);
                int year = Convert.ToInt32(textBox2.Text);
                if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
                {
                    labelYear.Text = $"Год: {Convert.ToString(year)} (високосный)";
                    if (x > 0 && x <= 366)
                    {
                        if (x <= 31)
                        {
                            labelLetter.Text = $"День: {Convert.ToString(x)}";
                            labelMonth.Text = "Месяц: Январь";
                        }
                        else if (x > 31 && x <= 60)
                        {
                            x -= 31;
                            labelLetter.Text = $"День: {Convert.ToString(x)}";
                            labelMonth.Text = "Месяц: Февраль";
                        }
                        else if (x > 60 && x <= 91)
                        {
                            x -= 29 + 31;
                            labelLetter.Text = $"День: {Convert.ToString(x)}";
                            labelMonth.Text = "Месяц: Март";
                        }
                        else if (x > 91 && x <= 121)
                        {
                            x -= 31 + 29 + 31;
                            labelLetter.Text = $"День: {Convert.ToString(x)}";
                            labelMonth.Text = "Месяц: Апрель";
                        }
                        else if (x > 121 && x <= 152)
                        {
                            x -= 31 + 29 + 31 + 30;
                            labelLetter.Text = $"День: {Convert.ToString(x)}";
                            labelMonth.Text = "Месяц: Май";
                        }
                        else if (x > 152 && x <= 182)
                        {
                            x -= 31 + 29 + 31 + 30 + 31;
                            labelLetter.Text = $"День: {Convert.ToString(x)}";
                            labelMonth.Text = "Месяц: Июнь";
                        }
                        else if (x > 182 && x <= 213)
                        {
                            x -= 31 + 29 + 31 + 30 + 31 + 30;
                            labelLetter.Text = $"День: {Convert.ToString(x)}";
                            labelMonth.Text = "Месяц: Июль";
                        }
                        else if (x > 213 && x <= 244)
                        {
                            x -= 31 + 29 + 31 + 30 + 31 + 30 + 31;
                            labelLetter.Text = $"День: {Convert.ToString(x)}";
                            labelMonth.Text = "Месяц: Август";
                        }
                        else if (x > 244 && x <= 274)
                        {
                            x -= 31 + 29 + 31 + 30 + 31 + 30 + 31 + 31;
                            labelLetter.Text = $"День: {Convert.ToString(x)}";
                            labelMonth.Text = "Месяц: Сентябрь";
                        }
                        else if (x > 274 && x <= 305)
                        {
                            x -= 31 + 29 + 31 + 30 + 31 + 30 + 31 + 31 + 30;
                            labelLetter.Text = $"День: {Convert.ToString(x)}";
                            labelMonth.Text = "Месяц: Октябрь";
                        }
                        else if (x > 305 && x <= 335)
                        {
                            x -= 31 + 29 + 31 + 30 + 31 + 30 + 31 + 31 + 30 + 31;
                            labelLetter.Text = $"День: {Convert.ToString(x)}";
                            labelMonth.Text = "Месяц: Ноябрь";
                        }
                        else if (x > 335 && x <= 366)
                        {
                            x -= 31 + 29 + 31 + 30 + 31 + 30 + 31 + 31 + 30 + 30 + 31;
                            labelLetter.Text = $"День: {Convert.ToString(x)}";
                            labelMonth.Text = "Месяц: Декабрь";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Введите число от 1 до 366", "Ошибка!");
                        labelYear.Text = " ";

                    }
                }
                else
                {
                    labelYear.Text = $"Год: {Convert.ToString(year)} (не високосный)";
                    if (x > 0 && x <= 365)
                    {
                        if (x <= 31)
                        {
                            labelLetter.Text = $"День: {Convert.ToString(x)}";
                            labelMonth.Text = "Месяц: Январь";
                        }
                        else if (x > 31 && x <= 59)
                        {
                            x -= 31;
                            labelLetter.Text = $"День: {Convert.ToString(x)}";
                            labelMonth.Text = "Месяц: Февраль";
                        }
                        else if (x > 59 && x <= 90)
                        {
                            x -= 28 + 31;
                            labelLetter.Text = $"День: {Convert.ToString(x)}";
                            labelMonth.Text = "Месяц: Март";
                        }
                        else if (x > 90 && x <= 120)
                        {
                            x -= 31 + 28 + 31;
                            labelLetter.Text = $"День: {Convert.ToString(x)}";
                            labelMonth.Text = "Месяц: Апрель";
                        }
                        else if (x > 120 && x <= 151)
                        {
                            x -= 31 + 28 + 31 + 30;
                            labelLetter.Text = $"День: {Convert.ToString(x)}";
                            labelMonth.Text = "Месяц: Май";
                        }
                        else if (x > 151 && x <= 181)
                        {
                            x -= 31 + 28 + 31 + 30 + 31;
                            labelLetter.Text = $"День: {Convert.ToString(x)}";
                            labelMonth.Text = "Месяц: Июнь";
                        }
                        else if (x > 181 && x <= 212)
                        {
                            x -= 31 + 28 + 31 + 30 + 31 + 30;
                            labelLetter.Text = $"День: {Convert.ToString(x)}";
                            labelMonth.Text = "Месяц: Июль";
                        }
                        else if (x > 212 && x <= 243)
                        {
                            x -= 31 + 28 + 31 + 30 + 31 + 30 + 31;
                            labelLetter.Text = $"День: {Convert.ToString(x)}";
                            labelMonth.Text = "Месяц: Август";
                        }
                        else if (x > 243 && x <= 273)
                        {
                            x -= 31 + 28 + 31 + 30 + 31 + 30 + 31 + 31;
                            labelLetter.Text = $"День: {Convert.ToString(x)}";
                            labelMonth.Text = "Месяц: Сентябрь";
                        }
                        else if (x > 273 && x <= 304)
                        {
                            x -= 31 + 28 + 31 + 30 + 31 + 30 + 31 + 31 + 30;
                            labelLetter.Text = $"День: {Convert.ToString(x)}";
                            labelMonth.Text = "Месяц: Октябрь";
                        }
                        else if (x > 304 && x <= 334)
                        {
                            x -= 31 + 28 + 31 + 30 + 31 + 30 + 31 + 31 + 30 + 31;
                            labelLetter.Text = $"День: {Convert.ToString(x)}";
                            labelMonth.Text = "Месяц: Ноябрь";
                        }
                        else if (x > 334 && x <= 365)
                        {
                            x -= 31 + 28 + 31 + 30 + 31 + 30 + 31 + 31 + 30 + 30 + 31;
                            labelLetter.Text = $"День: {Convert.ToString(x)}";
                            labelMonth.Text = "Месяц: Декабрь";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Введите число от 1 до 365", "Ошибка!");
                        labelYear.Text = " ";
                    }
                }
            }
            catch
            {
                MessageBox.Show("Введите значение");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            labelLetter.Text = " ";
            labelMonth.Text = " ";
            labelYear.Text = " ";
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
