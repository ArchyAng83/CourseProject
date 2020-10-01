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
        private readonly string path = "./../../Users/users.txt";

        public UsersControl()
        {
            InitializeComponent();
            Text = "Контроль пользователей(только для администратора)";
            LoadData();
        }

        private void LoadData()
        {
            using (StreamReader sr = new StreamReader(path))
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
            using (StreamWriter sw = new StreamWriter(path))
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
            if (user.CheckedOrUncheked)
            {
                listBox1.Items.Add(user.Admin);
            }
            else
            {
                listBox1.Items.Add(user.User);
            }
        }
    }
}
