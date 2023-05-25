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
    public partial class UsersOfDb : Form
    {
        public UsersOfDb()
        {
            InitializeComponent();
        }
        private void RegistNew_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sampleDBSakharovDataSet.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.sampleDBSakharovDataSet.Users);

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            MessageBox.Show("Ns dct cltkfk ghfdbkmyj");
            this.Close();
            adminForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ns dct cltkfk ghfdbkmyj");
        }
    }
}
