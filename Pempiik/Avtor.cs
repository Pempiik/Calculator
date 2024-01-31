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
using static System.Resources.ResXFileRef;

namespace Pempiik
{
    public partial class Avtor : Form
    {
        Database dataBase = new Database();

        Point lastPoint;

        public Avtor()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;
        }

        private void loginn_Click(object sender, EventArgs e)
        {
            var querySelectClient = $"SELECT * FROM rer WHERE login_user = '{login.Text}' AND password_user = '{pass.Text}'";
            var queryGetId = $"SELECT id_user FROM rer WHERE login_user = '{login.Text}'";
            var commandGetId = new SqlCommand(queryGetId, dataBase.getConnection());

            dataBase.openConnection();


            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            SqlCommand command = new SqlCommand(querySelectClient, dataBase.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Вы успешно вошли!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Convertic frm1 = new Convertic();
                this.Hide();
                frm1.ShowDialog();
                this.Show();
            }
            else
                MessageBox.Show("Такого аккаунта не существует!", "Аккаунта не существует!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void krest_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ymen1_MouseEnter(object sender, EventArgs e)
        {
            ymen1.ForeColor = Color.DarkGray;
        }

        private void ymen1_MouseLeave(object sender, EventArgs e)
        {
            ymen1.ForeColor = Color.White;
        }

        private void glazz_Click(object sender, EventArgs e)
        {
            {// обработка события при нажатии на кнопку показать/ скрыть пароль
                if (pass.PasswordChar == '*')
                {
                    pass.PasswordChar = '\0';
                }
                else
                {
                    pass.PasswordChar = '*';
                }

            }
        }

        private void Avtor_MouseMove(object sender, MouseEventArgs e)
        {
            {
                if (e.Button == MouseButtons.Left)
                {
                    this.Left += e.X - lastPoint.X;
                    this.Top += e.Y - lastPoint.Y;

                }
            }
        }

        private void Avtor_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void ymen1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Regist register = new Regist();
            register.Show();
        }
    }
}
