using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject.SaveLoad
{
    class SaveData
    {
        public double[] Temperatures { get; set; }
        public double[] Zones { get; set; }

        public void Save(string filePath)
        {
            if (File.Exists(filePath))
            {
                MessageBox.Show("Такой файл уже существует.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);               
                return;
            }

            using (StreamWriter sw = new StreamWriter(filePath, false))
            {
               
                for (int i = 0; i < Temperatures.Length; i++)
                {
                    sw.WriteLine(Temperatures[i] + " " + Zones[i]);
                }
            }
        }
    }
}
