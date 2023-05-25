using Lab3_sakharov.ModelEF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_sakharov
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public static MainForm FORMA { get;set;}

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        static public Form prevFORM = null;
        private void EnterBtn_Click(object sender, EventArgs e)
        {
            if (LoginTxt.Text == "" || PswTxt.Text == "")
            {
                MessageBox.Show("Нужно задать логин и пароль!");
                return;
            }

            Users usr = Program.db.Users.Find(LoginTxt.Text);

            if ((usr != null) && (usr.password == PswTxt.Text))
            {
                Program.USER = usr;
                if (usr.roleId == 1)
                {
                    DirectorForm frm = new DirectorForm();
                    frm.prevFORM = this;
                    frm.Show();
                    this.Hide();
                }
                else if (usr.roleId == 2)
                {
                    ManagerForm frm = new ManagerForm();
                    frm.prevFORM = this;
                    frm.Show();
                    this.Hide();
                }
                else if (usr.roleId == 3)
                {
                    AdminForm frm = new AdminForm();
                    frm.prevFORM = this;
                    frm.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Пользователя с таким логином и паролем нет!");
                return;
            }
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            RegistryForm f = new RegistryForm();
            FORMA = this;
            this.Hide();
            f.Show();
        }
    }
}
