using CourseProject.Accounts;
using System;
using System.IO;
using System.Windows.Forms;

namespace CourseProject
{
    public partial class RegistrationForm : Form
    {       
        public string Log { get; private set; }
        public string Pass { get; private set; }
        public string Fio { get; private set; }
        public string Group { get; private set; }
        public Label Label { get; private set; }

        public RegistrationForm()
        {
            InitializeComponent();
            regLoginTextBox.Text = "";
            regPasswordTextBox.Text = "";
            regFioTextBox.Text = "";
            regGroupTextBox.Text = "";
            Text = "Регистрация";
            Label = label1;
        }

        private void saveUserButton_Click(object sender, EventArgs e)
        {
            try
            {
                Log = regLoginTextBox.Text;
                Pass = regPasswordTextBox.Text;
                Fio = regFioTextBox.Text;
                Group = regGroupTextBox.Text;
            }
            catch (Exception ex)
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
                    if (Log.Equals(text[0]))
                    {
                        MessageBox.Show("Такой логин уже существует.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }

            SaveUser();

            this.Close();
        }

        public virtual void SaveUser()
        {
            using (StreamWriter sw = new StreamWriter(PathFiles.path, true))
            {
                sw.WriteLine(new User(Log, Pass, Fio, Group));
            }
        }
    }
}
