using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pempiik
{
    public partial class Regist : Form
    {
        Database dataBase = new Database();

        Point lastPointt;

        public Regist()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;
        }

        private void register_Click(object sender, EventArgs e)
        {
            bool hasCif = false; //есть ли цифры
            bool hasAlp = false; //есть ли латинские буквы
            for (int i = 0; i < pass2.Text.Length; i++)
            {
                hasCif = hasCif || ((pass2.Text[i] >= '0') && (pass2.Text[i] <= '9'));
                hasAlp = hasAlp || ((pass2.Text[i] >= 'a') && (pass2.Text[i] <= 'z')) ||
                    ((pass2.Text[i] >= 'A') && (pass2.Text[i] <= 'Z'));
            }
            //Получили: есть или нет цифры, есть или нет латинские буквы (отдельными 2-мя переменными)


            if (String.IsNullOrWhiteSpace(login2.Text) ||
                String.IsNullOrWhiteSpace(pass2.Text))
            {
                MessageBox.Show("Есть неверные (пустые?) поля");
                return;
            } else if (pass2.Text.Length < 8)
            {
                MessageBox.Show("Пароль менее 8 символов");
                return;
            } else if (!(hasCif & hasAlp))
            {
                MessageBox.Show("В пароле требуются лат.буквы и цифры");
                return;
            }
                        
            string yourSQL = "SELECT login_user FROM rer WHERE login_user = '" + login2.Text + "'";

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            SqlCommand command = new SqlCommand(yourSQL, dataBase.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь с таким логином уже существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult result;
            result = MessageBox.Show("Вы хотите сохранить запись?", "Сохранение данных", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string mySQL = string.Empty;

                mySQL += "INSERT INTO rer (login_user, password_user) ";
                mySQL += "VALUES ('" + login2.Text + "','" + pass2.Text + "')";

                dataBase.openConnection();

                SqlCommand commandAddNewUser = new SqlCommand(mySQL, dataBase.getConnection());
                commandAddNewUser.ExecuteNonQuery();

                MessageBox.Show("Аккаунт успешно создан!", "Данные сохранены", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dataBase.closeConnection();

                Avtor frm_vhod = new Avtor();
                this.Hide();
                frm_vhod.ShowDialog();
                this.Show();
            }
        }

        private void krest_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ymen2_MouseEnter(object sender, EventArgs e)
        {
            ymen2.ForeColor = Color.DarkGray;
        }

        private void ymen2_MouseLeave(object sender, EventArgs e)
        {
            ymen2.ForeColor = Color.White;
        }

        private void ymen2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Avtor avtor = new Avtor();
            avtor.Show();
        }

        private void glazz2_Click(object sender, EventArgs e)
        {
            {// обработка события при нажатии на кнопку показать/ скрыть пароль
                if (pass2.PasswordChar == '*')
                {
                    pass2.PasswordChar = '\0';
                }
                else
                {
                    pass2.PasswordChar = '*';
                }

            }
        }

        private void Regist_MouseDown(object sender, MouseEventArgs e)
        {
            lastPointt = new Point(e.X, e.Y);
        }

        private void Regist_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPointt.X;
                this.Top += e.Y - lastPointt.Y;

            }
        }
    }
}
