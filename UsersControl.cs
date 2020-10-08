using System;
using System.IO;
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
                    if (str == "")
                    {
                        continue;
                    }
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
                    text += data.ToString() + "\r\n";
                }
                sw.WriteLine(text);
            }
        }        

        private void addButton3_Click(object sender, EventArgs e)
        {           
            var user = new AddUsersForm();
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
