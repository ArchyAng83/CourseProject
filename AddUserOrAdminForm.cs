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
    public partial class AddUserOrAdminForm : Form
    {
        private string addUser;        

        public AddUserOrAdminForm()
        {
            InitializeComponent();
            Text = "Добавление пользователя";
        }

        private void okButton1_Click(object sender, EventArgs e)
        {
            try
            {
                addUser = addUsersTextBox1.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            
            using (StreamWriter sw = new StreamWriter(PathFiles.path, true))
            {
                string[] text = addUser.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                if (adminCheckBox1.Checked)
                {
                    sw.WriteLine(new Admin(text[0], text[1], text[2], text[3]));
                }
                else
                {
                    sw.WriteLine(new User(text[0], text[1], text[2], text[3]));
                }
            }
            
            this.Close();
        }
    }
}
