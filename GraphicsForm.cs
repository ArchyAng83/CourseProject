using System;
using System.Windows.Forms;

namespace CourseProject
{
    public partial class GraphicsForm : Form
    {
        public double XFirst { get; set; }
        public double XLast { get; set; }
        public int Count { get; set; }
        public double ConstA { get; set; }
        public double ConstB { get; set; }
        public double[] Temperatures { get; set; }
        public double[] Zones { get; set; }

        private int step;
        private double[] xExperemental;
        private double[] xApproximal;
        private double[] yExperemental;
        private double[] yApproximal;

        public GraphicsForm()
        {
            InitializeComponent();
            Text = "График";
        }

        private void GraphicsForm_Load(object sender, EventArgs e)
        {
            step = (int)(Math.Abs(XLast - XFirst) / (Count - 1));
            CalculateApprox();
            CreateChart();
            chart1.Series[0].Points.DataBindXY(xExperemental, yExperemental);
            chart1.Series[1].Points.DataBindXY(xApproximal, yApproximal);
        }

        private void CalculateApprox()
        {
            xExperemental = new double[Count];
            xApproximal = new double[Count];
            yExperemental = new double[Count];
            yApproximal = new double[Count];
            for (int i = 0; i < Count; i++)
            {
                xApproximal[i] = XFirst + step * i;
                yApproximal[i] = ConstA / xApproximal[i] + ConstB;
                xExperemental[i] = Temperatures[i];
                yExperemental[i] = Zones[i];
            }
        }       

        private void CreateChart()
        {
            chart1.SetBounds(10, 10, this.Width - 20, this.Height - 20);
            chart1.ChartAreas[0].AxisX.Minimum = XFirst;
            chart1.ChartAreas[0].AxisX.Maximum = XLast;
            chart1.ChartAreas[0].AxisX.MajorGrid.Interval = step;
            chart1.Series[0].BorderWidth = 3;
            chart1.Series[1].BorderWidth = 3;        
        }
    }
}
