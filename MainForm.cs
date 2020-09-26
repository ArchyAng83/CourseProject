using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //MainForm mainForm = new MainForm();
            //mainForm.ShowDialog();
            //Thread.Sleep(3000);
            //Hide();
            //Login login = new Login();
            //login.ShowDialog();
            
        }
    }
}
