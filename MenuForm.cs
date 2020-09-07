using CourseProject.Caculation;
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
    public partial class MenuForm : Form
    {
        private double[] temperatures;
        private double[] zones;

        public int Count { get; set; }


        public MenuForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void inputDataButton_Click(object sender, EventArgs e)
        {
            try
            {
                Count = int.Parse(experementCountComboBox.Text);
                if (Count <= 0)
                {
                    MessageBox.Show("Количество экспериментов должно быть положительным!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            int i = 0;
            temperatures = new double[Count];
            zones = new double[Count];
            while (i != Count)
            {
                
                for (i = 0; i < Count; i++)
                {
                    InputDataForm inputDataForm = new InputDataForm();
                    inputDataForm.ShowDialog();
                    temperatures[i] = inputDataForm.Temperature;
                    zones[i] = inputDataForm.Zone;
                }
            }

            outputDataButton.Enabled = true;
            buildGraphicButton.Enabled = true;
        }

        private void outputDataButton_Click(object sender, EventArgs e)
        {
            PrintData(temperatures, temperatureTextBox);
            PrintData(zones, zoneTextBox);
            var calculation = new Calculation(temperatures, zones, Count);
            label4.Text = $"a = {calculation.GetConstA():f3}";
            label5.Text = $"b = {calculation.GetConstB():f3}";
            label6.Text = $"аппроксимация функцией: y = {calculation.GetConstA():f3} / x + {calculation.GetConstB():f3}";
            label7.Text = $"средняя ошибка: {calculation.GetError():f4}%";

            outputDataButton.Enabled = false;
        }

        private void PrintData(double[] data, TextBox textBox)
        {
            for (int i = 0; i < Count; i++)
            {
                textBox.Text += $"{i + 1}] : {data[i]}\r\n";

            }
        }

        private void buildGraphicButton_Click(object sender, EventArgs e)
        {
            GraphicsForm graphicsForm = new GraphicsForm();
            graphicsForm.ShowDialog();
        }
    }
}
