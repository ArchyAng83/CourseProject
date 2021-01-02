using CourseProject.Caculation;
using System;
using System.IO;
using System.Windows.Forms;

namespace CourseProject
{
    public partial class MenuForm : Form
    {
        private double[] temperatures;
        private double[] zones;
        private double[] x;
        private double[] y;

        public int Count { get; private set; }
        public double ConstA { get; private set; }
        public double ConstB { get; private set; }


        public MenuForm(bool admin, bool adminControl)
        {
            InitializeComponent();
            deleteToolStripMenuItem.Enabled = admin;
            usersControlToolStripMenuItem.Enabled = adminControl;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            Application.Exit();
        }

        private void inputDataButton_Click(object sender, EventArgs e)
        {
            ClearDataFields();

            while (true) 
            {
                InputDataForm inputDataForm = new InputDataForm();
                inputDataForm.ShowDialog();
                if (inputDataForm.IsButtonPush)
                {
                    outputDataButton.Enabled = true;
                    inputDataButton.Enabled = false;
                    MessageBox.Show("Данные успешно введены", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                temperatureTextBox.Text += inputDataForm.Temperature.ToString() + "\r\n";
                zoneTextBox.Text += inputDataForm.Zone.ToString() + "\r\n";
            }            
        }

        private void outputDataButton_Click(object sender, EventArgs e)
        {
            try
            {
                x = Array.ConvertAll(temperatureTextBox.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries), Convert.ToDouble);
                y = Array.ConvertAll(zoneTextBox.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries), Convert.ToDouble);
                Count = x.Length;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            if (Count < 2)
            {
                MessageBox.Show("Недостаточно данных", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                inputDataButton.Enabled = true;
                return;
            }           

            temperatures = new double[Count];
            zones = new double[Count];
            temperatures = x;
            zones = y;

            foreach (var item in temperatures)
            {
                if (item != 0)
                {
                    var calculation = new Calculation(temperatures, zones, Count);
                    ConstA = calculation.ConstA;
                    ConstB = calculation.ConstB;
                    label3.Text = $"Количество экспериментов: {Count}";
                    label4.Text = $"a = {calculation.ConstA:f4}";
                    label5.Text = $"b = {calculation.ConstB:f4}";
                    label6.Text = $"Аппроксимация функцией: y = {calculation.ConstA:f4} / x + {calculation.ConstB:f4}";
                    label7.Text = $"Средняя ошибка: {calculation.ErrorApprox:f4}%";
                }
                else
                {
                    ClearDataFields();
                    MessageBox.Show("Нет решений", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

           

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
            ClearDataFields();

            using (OpenFileDialog openFile = new OpenFileDialog() { Filter = "|*.txt", Multiselect = false })
            {
                openFile.InitialDirectory = PathFiles.pathToSaveLoad;
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader sr = new StreamReader(openFile.FileName))
                    {
                        string str;
                        while ((str = sr.ReadLine()) != null)
                        {
                            string[] text = str.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                            try
                            {
                                temperatureTextBox.Text += text[0] + "\r\n";
                                zoneTextBox.Text += text[1] + "\r\n";
                            }
                            catch (Exception ex)
                            {
                                ClearDataFields();
                                MessageBox.Show(ex.Message);
                                return;
                            }
                        }
                    }
                }
            }
                        
            outputDataButton.Enabled = true;
        }        

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveDataFile();
        }

        private void SaveDataFile()
        {
            using (SaveFileDialog saveFile = new SaveFileDialog() { Filter = "|*.txt" })
            {
                saveFile.InitialDirectory = PathFiles.pathToSaveLoad;
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
            using (OpenFileDialog deleteFile = new OpenFileDialog() { Filter = "|*.txt", Multiselect = false,  })
            {
                deleteFile.InitialDirectory = PathFiles.pathToSaveLoad;
                deleteFile.Title = "Удаление";
                if (deleteFile.ShowDialog() == DialogResult.OK)
                {
                    DialogResult result = MessageBox.Show("Желаете удалить ?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        File.Delete(deleteFile.FileName);
                        MessageBox.Show("Файл удален.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else return;
                }
            }
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var help = new HelpForm();
            help.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var about = new AboutForm();
            about.ShowDialog();
        }

        private void usersControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var usersControl = new UsersControl();
            usersControl.ShowDialog();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearDataFields();
        }

        private void ClearDataFields()
        {
            inputDataButton.Enabled = true;
            outputDataButton.Enabled = false;
            buildGraphicButton.Enabled = false;
            temperatureTextBox.Text = "";
            zoneTextBox.Text = "";
            label3.Text = "Количество экспериментов:";
            label4.Text = "a = ";
            label5.Text = "b = ";
            label6.Text = "Аппроксимация функцией:";
            label7.Text = "Средняя ошибка:";
        }

        private void MenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (temperatureTextBox.Text != "" && zoneTextBox.Text != "")
            {
                DialogResult result = MessageBox.Show("Желаете сохранить данные?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    SaveDataFile();
                }
            }

            this.Hide();
            var login = new Login();
            login.ShowDialog();
        }
    }
}
