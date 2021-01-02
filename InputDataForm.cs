using System;
using System.Windows.Forms;

namespace CourseProject
{
    public partial class InputDataForm : Form
    {
        public double Temperature { get; private set; }
        public double Zone { get; private set; }
        public bool IsButtonPush { get; private set; }

        public InputDataForm()
        {
            InitializeComponent();
            inputTempretureTextBox.Text = "";
            inputZoneTextBox.Text = "";
            Text = "Ввод экспериментальных данных";
        }

        private void okInputButton_Click(object sender, EventArgs e)
        {
            DataValidation();
        }

        private void inputAllDatasbutton1_Click(object sender, EventArgs e)
        {
            if (inputAllDatasbutton1.DialogResult == DialogResult.OK)
            {
                IsButtonPush = true;                
            }

            Close();
        }

        private void DataValidation()
        {
            try
            {
                Temperature = double.Parse(inputTempretureTextBox.Text);
                Zone = double.Parse(inputZoneTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            Close();
        }       
    }
}
