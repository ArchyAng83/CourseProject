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
            
            this.Close();
        }
    }
}
