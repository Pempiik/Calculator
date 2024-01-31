using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pempiik
{
    public partial class Convertic : Form
    {
        Point lastPointtt;

        public Convertic()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;
        }

        private void krest_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Convertic_MouseMove(object sender, MouseEventArgs e)
        {
            {
                if (e.Button == MouseButtons.Left)
                {
                    this.Left += e.X - lastPointtt.X;
                    this.Top += e.Y - lastPointtt.Y;

                }
            }
        }

        private void Convertic_MouseDown(object sender, MouseEventArgs e)
        {
            lastPointtt = new Point(e.X, e.Y);
        }

        private void perevesti_Click(object sender, EventArgs e)
        {
            char[] numb = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j' };
            string chis = chislo.Text;
            chis = chis.ToLower();
            int k;
            int c;
            //Проверка введенных данных
            if (chis != "" && iz.Text != "" && v.Text != "") //если все поля заполнены, проверяем правильность
            {
                k = Convert.ToInt32(iz.Text);
                c = Convert.ToInt32(v.Text);
                if (!(k > 1 && k < 21 && c > 1 && c < 21))
                {
                    MessageBox.Show("Неверная система счисления! Введите число от 2 до 20.");
                    return;
                };
                for (int i = 0; i < chis.Length; i++)
                {
                    for (int j = 0; j < 20; j++)
                    {
                        if (chis[i] == numb[j])
                        {
                            if (j > (k - 1))
                            {
                                MessageBox.Show("Число не соответствует системе счисления.");
                                return;
                            }
                        }
                    }
                }

            }
            else //если заполнены не все поля
            {
                MessageBox.Show("Заполните все поля!");
                return;
            };

            //перевод числа в десятичную систему
            int chis_10 = 0;
            int st = 0;//степень
            for (int i = chis.Length - 1; i >= 0; i--)//цикл по символам введенного числа
            {
                for (int j = 0; j < 20; j++)//цикл по массиву
                {
                    if (chis[i] == numb[j])
                    {
                        chis_10 += (int)(j * Math.Pow(k, st));
                        st++;
                        break;
                    }
                }
            }

            //перевод числа в нужную систему путем взятия остатка
            string res = "";
            while (chis_10 != 0)
            {
                res = numb[chis_10 % c].ToString() + res;//ищем остаток в массиве и пишем в строку
                chis_10 = chis_10 / c;
            }
            resul.Text = res.ToUpper();

        }

        private void chislo_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                //разрешение ввода только необходимых символов 
                Match mh = Regex.Match(e.KeyChar.ToString(), "[0-9a-jA-J]");

                if (!(mh.Success) && e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }
    }
}
