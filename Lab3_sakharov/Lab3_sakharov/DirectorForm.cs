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
    public partial class DirectorForm : Form
    {
        public DirectorForm()
        {
            InitializeComponent();
        }
        public Form prevFORM = null;
        private void EnterBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            // показываем скрытую форму MainForm
            if (prevFORM != null) prevFORM.Show();
        }

        private void DirectorForm_Load(object sender, EventArgs e)
        {
            HelloLabelDir.Text = "Добрый день, " + Program.USER.FIO + " !";
        }

        private void ComplimentBtn_Click(object sender, EventArgs e)
        {
            string[] compliments = { "Ваш новый костюм очень элегантный. Вы выглядите в нем профессионально.",
            "Как руководитель вы являетесь примером для нас. Вы можете разумно сочетать работу и личную жизнь. Вы все успеваете.",
            "Ты отличный организатор! Тебе по плечу организовать мероприятие любого уровня!",
            "Так бывает очень редко, но у тебя есть способности ко всему, за что ты берешься! Ты удивительный человек!",
            "Твои идеи и творчество достойны восхищения!",
            "Тобой хочется гордиться и брать с тебя пример!",
            "Талантливый человек талантлив во многих сферах. Вот ты, например. По-моему, мало что есть, чего ты не умеешь"};

            MessageBox.Show(compliments[new Random().Next(0, compliments.Length)]);
        }
    }
}
