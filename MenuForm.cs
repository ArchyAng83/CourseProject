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
        public double ConstA { get; set; }
        public double ConstB { get; set; }


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
            ConstA = calculation.ConstA;
            ConstB = calculation.ConstB;
            label4.Text = $"a = {calculation.ConstA:f3}";
            label5.Text = $"b = {calculation.ConstB:f3}";
            label6.Text = $"аппроксимация функцией: y = {calculation.ConstA:f3} + {calculation.ConstB:f3} / x";
            label7.Text = $"средняя ошибка: {calculation.ErrorApprox:f4}%";

            outputDataButton.Enabled = false;
        }

        private double[] PrintData(double[] data, TextBox textBox)
        {
            for (int i = 0; i < Count; i++)
            {
                textBox.Text += $"{data[i]}\r\n";

            }
            return data;
        }

        private void buildGraphicButton_Click(object sender, EventArgs e)
        {            
            GraphicsForm graphicsForm = new GraphicsForm
            {
                XFirst = temperatures[0],
                XLast = temperatures[Count - 1],
                Count = Count,
                ConstA = ConstA,
                ConstB = ConstB
            };
            graphicsForm.ShowDialog();
        }
    }
}
