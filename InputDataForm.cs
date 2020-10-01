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
    public partial class InputDataForm : Form
    {
        public double Temperature { get; private set; }
        public double Zone { get; private set; }

        public InputDataForm()
        {
            InitializeComponent();
            inputTempretureTextBox.Text = "";
            inputZoneTextBox.Text = "";
            Text = "Ввод экспериментальных данных";
        }

        private void okInputButton_Click(object sender, EventArgs e)
        {
            try
            {
                Temperature = double.Parse(inputTempretureTextBox.Text);
                Zone = double.Parse(inputZoneTextBox.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            Close();
        }
    }
}
