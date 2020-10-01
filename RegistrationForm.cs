using CourseProject.Accounts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject
{
    public partial class RegistrationForm : Form
    {
        private readonly string path = "./../../Users/users.txt";
        private string log;
        private string pass;
        private string fio;
        private string group;

        public RegistrationForm()
        {
            InitializeComponent();
            regLoginTextBox.Text = "";
            regPasswordTextBox.Text = "";
            regFioTextBox.Text = "";
            regGroupTextBox.Text = "";
            Text = "Регистрация";
        }

        private void saveUserButton_Click(object sender, EventArgs e)
        {           
            try
            {
                log = regLoginTextBox.Text;
                pass = regPasswordTextBox.Text;
                fio = regFioTextBox.Text;
                group = regGroupTextBox.Text;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            using (StreamReader sr = new StreamReader(path))
            {
                string str;
                while ((str = sr.ReadLine()) != null)
                {
                    string[] text = str.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                    if (log.Equals(text[0]))
                    {
                        MessageBox.Show("Такой логин уже существует.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }

            using (StreamWriter sw = new StreamWriter(path, true))
            {
                User user = new User(log, pass, fio, group);
                sw.WriteLine(user);
            }

            this.Close();
        }
    }
}
