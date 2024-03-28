using LiveCharts.Wpf;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;
using System.Windows.Shapes;
using static System.Windows.Forms.LinkLabel;
using System.IO;

namespace SimpleCode
{
    public partial class Result : Form
    {
        public Result()
        {
            InitializeComponent();
        }

        private void toolStripButtonGenerate_Click(object sender, EventArgs e)
        {
            Chart.Series[0].Points.Clear();
            Chart.Series[1].Points.Clear();
            Chart.Series[2].Points.Clear();

            string lin;
            StreamReader sr = new StreamReader("C:\\Users\\Public\\Documents\\Data.txt");
            while ((lin = sr.ReadLine()) != null)
            {
                string[] row = lin.Split(',');
                Chart.Series[0].Points.AddXY(Convert.ToDouble(row[0]), Convert.ToDouble(row[1]));
                Chart.Series[1].Points.AddXY(Convert.ToDouble(row[0]), Convert.ToDouble(row[2]));
                Chart.Series[2].Points.AddXY(Convert.ToDouble(row[0]), Convert.ToDouble(row[3]));
            }

        }


        private void BBackToGame_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Result_FormClosed(object sender, FormClosedEventArgs e)
        {
            var fr = new Form1();
            fr.Show();
        }
    }
}
