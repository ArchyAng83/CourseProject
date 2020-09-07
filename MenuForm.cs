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
        }

        
    }
}
