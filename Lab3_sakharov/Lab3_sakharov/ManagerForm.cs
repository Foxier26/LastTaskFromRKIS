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
    public partial class ManagerForm : Form
    {
        public ManagerForm()
        {
            InitializeComponent();
        }
        public Form prevFORM = null;

        private void ManagerForm_Load(object sender, EventArgs e)
        {
            HelloLabelManage.Text = "Добрый день, " + Program.USER.FIO + " !";
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            if (prevFORM != null) prevFORM.Show();
        }
    }
}
