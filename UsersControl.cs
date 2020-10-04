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
            SaveData();

        }

        private void SaveData()
        {
            using (StreamWriter sw = new StreamWriter(PathFiles.path))
            {
                string text = "";
                foreach (var data in listBox1.Items)
                {
                    text += data.ToString() + "\n";
                }
                sw.WriteLine(text);
            }
        }        

        private void addButton3_Click(object sender, EventArgs e)
        {
            var user = new AddUserOrAdminForm();
            user.ShowDialog();                                
        }

        private void UsersControl_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveData();
        }

        private void updateButton1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            LoadData();
        }
    }
}
