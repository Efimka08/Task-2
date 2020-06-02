using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_1._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.ChartAreas[0].AxisX.ScaleView.Zoom(0, 360); //задание масштаба по оси Х
            chart1.ChartAreas[0].CursorX.IsUserEnabled = true; //возможность масштабирования
            chart1.ChartAreas[0].CursorX.IsUserSelectionEnabled = true; //возможность выбора интеравала для масштабирования
            chart1.ChartAreas[0].AxisX.ScaleView.Zoomable = true; //включение масштабирования по оси Х
            chart1.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true; //включение полосы прокрутки

            chart1.ChartAreas[0].AxisY.ScaleView.Zoom(-11000, 135000); //задание масштаба по оси Y
            chart1.ChartAreas[0].CursorY.IsUserEnabled = true; //возможность масштабирования
            chart1.ChartAreas[0].CursorY.IsUserSelectionEnabled = true; //возможность выбора интеравала для масштабирования
            chart1.ChartAreas[0].AxisY.ScaleView.Zoomable = true; //включение масштабирования по оси Y
            chart1.ChartAreas[0].AxisY.ScrollBar.IsPositionedInside = true; //включение полосы прокрутки

            for (int a = 0; a <= 360; a++)
            {
                chart1.Series[0].Points.AddXY(a, ((Math.Sin(2 * a) + Math.Sin(5 * a) + Math.Sin(3 * a)) / (Math.Cos(a) + 1 - 2 * (Math.Sin(a) * Math.Sin(a)))));
            }
            for (int a = 0; a <= 360; a++)
            {
                chart1.Series[1].Points.AddXY(a, (2 * Math.Sin(a)));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}