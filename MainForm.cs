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
            Text = "Приложение для аппроксимации статических данных";
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        
    }
}
