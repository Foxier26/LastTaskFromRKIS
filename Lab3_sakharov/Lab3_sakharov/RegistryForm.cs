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
    public partial class RegistryForm : Form
    {
        public RegistryForm()
        {
            InitializeComponent();
            
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm.FORMA.Show();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            Model1 db = new Model1();

            if (LoginTxt.Text == "" || PswTxt.Text == "" ||
              PswTxt2.Text == "" || FioTxt.Text == "")
            {
                MessageBox.Show("Нужно задать все данные!");
                return;
            }
            if (PswTxt.Text != PswTxt2.Text)
            {
                MessageBox.Show("Значения паролей не совпадают!");
                return;
            }


            Users usr = db.Users.Find(LoginTxt.Text);

            if (usr != null)
            {
                MessageBox.Show("Пользователь с таким логином уже есть!");
                return;
            }
            usr = new Users();
            usr.login = LoginTxt.Text;
            usr.password = PswTxt.Text;
            usr.roleId = RolesCombo.SelectedValue;
            usr.FIO = FioTxt.Text;

            db.Users.Add(usr);
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            MessageBox.Show("Пользователь " + usr.login + "зарегистрирован!");
            AdminForm.FORMA.Show();
            this.Close();
            return;

        }

        private void RegistryForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sampleDBSakharovDataSet2.Roles". При необходимости она может быть перемещена или удалена.
            this.rolesTableAdapter1.Fill(this.sampleDBSakharovDataSet2.Roles);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sampleDBSakharovDataSet1.Roles". При необходимости она может быть перемещена или удалена.
            this.rolesTableAdapter.Fill(this.sampleDBSakharovDataSet1.Roles);

        }
    }
}
