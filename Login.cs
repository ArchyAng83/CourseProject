using System;
using System.IO;
using System.Windows.Forms;

namespace CourseProject
{
    public partial class Login : Form
    {
        private string loginAccess;
        private string passAccess;
        private bool flag;
        private bool flagAdmin;

        public Login()
        {
            InitializeComponent();
            Text = "Вход";
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            try
            {
                loginAccess = loginTextBox.Text;
                passAccess = passwordTextBox.Text;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            using (StreamReader sr = new StreamReader(PathFiles.path))
            {

                string str;
                while ((str = sr.ReadLine()) != null)
                {
                    if (str == "")
                    {
                        continue;
                    }
                    string[] text = str.Split("|".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                    if (loginAccess.Equals(text[0]) && passAccess.Equals(text[1]))
                    {
                        if (text[text.Length - 1] == "admin")
                        {
                            flagAdmin = true;
                        }
                        flag = true;
                        break;
                    }

                }
            }
            if (flag)
            {
                if (flagAdmin)
                {
                    this.Hide();
                    var resultAdmin = new MenuForm(true, true);
                    resultAdmin.ShowDialog();
                }
                else
                {
                    this.Hide();
                    var result = new MenuForm(false, false);
                    result.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            RegistrationForm registration = new RegistrationForm();
            registration.ShowDialog();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
