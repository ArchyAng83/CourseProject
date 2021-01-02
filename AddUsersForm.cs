using CourseProject.Accounts;
using System;
using System.IO;

using System.Windows.Forms;

namespace CourseProject
{
    public partial class AddUsersForm : RegistrationForm
    {
        public AddUsersForm()
        {
            InitializeComponent();
            Label.Text = "Введите данные пользователя";
            Text = "Добавление пользователя";
        }

        public override void SaveUser()
        {
            using (StreamWriter sw = new StreamWriter(PathFiles.path, true))
            {
                if (!checkBox1.Checked)
                {
                    sw.WriteLine(new User(Log, Pass, Fio, Group));
                }
                else
                {
                    sw.WriteLine(new Admin(Log, Pass, Fio, Group));
                }
            }
        }
    }
}
