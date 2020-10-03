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
    public partial class UsersControl : Form
    {             
        public UsersControl()
        {
            InitializeComponent();
            Text = "Контроль пользователей(только для администратора)";
            LoadData();
        }

        private void LoadData()
        {
            using (StreamReader sr = new StreamReader(PathFiles.path))
            {
                string str;
                while ((str = sr.ReadLine()) != null)
                {
                    listBox1.Items.Add(str);
                }               
            }
        }

        private void deleteButton2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void saveButton1_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(PathFiles.path))
            {
                string text = "";
                foreach (var data in listBox1.Items)
                {
                    text += data.ToString() + "\r\n";
                }
                sw.WriteLine(text);
            }
        }

        private void addButton3_Click(object sender, EventArgs e)
        {
            var user = new AddUserOrAdminForm();
            user.ShowDialog();                      
            string[] text = user.AddUser.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            if (user.CheckedOrUncheked)
            {
                listBox1.Items.Add(new Admin(text[0], text[1], text[2], text[3]));
            }
            else
            {
                listBox1.Items.Add(new User(text[0], text[1], text[2], text[3]));
            }
        }
    }
}
