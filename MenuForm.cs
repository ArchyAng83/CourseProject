using CourseProject.Caculation;
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
                    temperatureTextBox.Text += inputDataForm.Temperature.ToString() + "\r\n";
                    zoneTextBox.Text += inputDataForm.Zone.ToString() + "\r\n";
                }
            }
            inputDataButton.Enabled = false;
            outputDataButton.Enabled = true;            
        }

        private void outputDataButton_Click(object sender, EventArgs e)
        {

            double[] x = Array.ConvertAll(temperatureTextBox.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries), Convert.ToDouble);
            double[] y = Array.ConvertAll(zoneTextBox.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries), Convert.ToDouble);
            Count = x.Length;
            temperatures = x;
            zones = y;
           
            var calculation = new Calculation(temperatures, zones, Count);
            ConstA = calculation.ConstA;
            ConstB = calculation.ConstB;
            label4.Text = $"a = {calculation.ConstA:f3}";
            label5.Text = $"b = {calculation.ConstB:f3}";
            label6.Text = $"аппроксимация функцией: y = {calculation.ConstA:f3} + {calculation.ConstB:f3} / x";
            label7.Text = $"средняя ошибка: {calculation.ErrorApprox:f4}%";

            outputDataButton.Enabled = false;
            buildGraphicButton.Enabled = true;
        }        

        private void buildGraphicButton_Click(object sender, EventArgs e)
        {
            GraphicsForm graphicsForm = new GraphicsForm
            {
                XFirst = temperatures[0],
                XLast = temperatures[Count - 1],
                Count = Count,
                ConstA = ConstA,
                ConstB = ConstB,
                Temperatures = temperatures,
                Zones = zones
            };
            graphicsForm.ShowDialog();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFile = new OpenFileDialog() { Filter = "|*.txt", Multiselect = false })
            {
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader sr1 = new StreamReader(openFile.FileName))
                    {
                        string str;
                        while ((str = sr1.ReadLine()) != null)
                        {
                            string[] text = str.Split(' ');
                            temperatureTextBox.Text += text[0] + "\r\n";
                            zoneTextBox.Text += text[1] + "\r\n";
                        }
                    }
                }
            }

            buildGraphicButton.Enabled = true;
            outputDataButton.Enabled = true;
        }        

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFile = new SaveFileDialog() { Filter = "|*.txt"})
            {
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(saveFile.FileName))
                    {
                        for (int i = 0; i < Count; i++)
                        {
                            sw.WriteLine(temperatures[i] + " " + zones[i]);
                        }

                        MessageBox.Show("Файл сохранен.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFile = new OpenFileDialog() { Filter = "|*.txt", Multiselect = false })
            {
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                   
                    File.Delete(openFile.FileName);
                }
            }
        }
    }
}
