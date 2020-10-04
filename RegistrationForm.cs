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
                    if (log.Equals(text[0]))
                    {
                        MessageBox.Show("Такой логин уже существует.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }

            using (StreamWriter sw = new StreamWriter(PathFiles.path, true))
            {             
                sw.WriteLine(new User(log, pass, fio, group));
            }

            this.Close();
        }
    }
}
