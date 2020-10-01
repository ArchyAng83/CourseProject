using CourseProject.Accounts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject
{
    public partial class AddUserOrAdminForm : Form
    {
        public string AddUser { get; set; }
        public bool CheckedOrUncheked { get; set; }
        public Admin Admin { get; set; }
        public User User { get; set; }

        public AddUserOrAdminForm()
        {
            InitializeComponent();
            Text = "Добавление пользователя";
        }

        private void okButton1_Click(object sender, EventArgs e)
        {
            try
            {
                AddUser = addUsersTextBox1.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }


            CheckedOrUncheked = adminCheckBox1.Checked;
            string[] text = addUsersTextBox1.Text.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            if (adminCheckBox1.Checked)
            {
                Admin = new Admin(text[0], text[1], text[2], text[3]);
                
            }
            else
            {
                User = new User(text[0], text[1], text[2], text[3]);
                
            }

            this.Close();
        }
    }
}
