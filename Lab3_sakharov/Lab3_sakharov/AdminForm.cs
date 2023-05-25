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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }
        public static MainForm FORMA { get; set; }
        public Form prevFORM = null;
        private void AdminForm_Load(object sender, EventArgs e)
        {
            HelloLabelAdmin.Text = "Добрый день, " + Program.USER.FIO + " !";
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            // показываем скрытую форму MainForm
            if (prevFORM != null) prevFORM.Show();
        }

        private void AccountBtn_Click(object sender, EventArgs e)
        {
            UsersOfDb usersOfDb = new UsersOfDb();
            this.Hide();
            usersOfDb.Show();
        }

        private void PasswordRestore_Click(object sender, EventArgs e)
        {

        }
    }
}
