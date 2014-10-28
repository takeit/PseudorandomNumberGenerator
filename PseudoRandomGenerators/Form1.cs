using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Windows.Forms.DataVisualization.Charting;
using PseudoRandomGenerators;

namespace PseudoRandomGenerators
{
    public partial class Form1 : Form
    {
        Random random;
        List<int> listOfXes;
        DataTable tableResults;
        public Form1()
        {
            InitializeComponent();
            panelGaussSettings.Visible = false;
            chartGauss.Visible = false;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            chartPoisson.Visible = false;
            table.Visible = true;
            if (radioButtonPoisson.Checked)
            {
                table.DataSource = null;
                random = new Random();
                tableResults = new DataTable();
                listOfXes = new List<int>();
                int x;
                for (int i = 0; i <= Convert.ToInt32(textBoxM.Text) - 1; i++)
                {
                    x = Generators.poissonDistribution(Convert.ToDouble(textBoxLambda.Text), random);
                    listOfXes.Add(x);
                }


                evaluateProbability(listOfXes);
                // draw table
                table.DataSource = tableResults;
                drawPoissonChart();
                chartPoisson.Visible = true;
            }

            if (radioButtonGauss.Checked)
            {
                gaussDistribution();
            } 
        }

        public void evaluateProbability(List<int> listOfXes)
        {
            tableResults.Columns.Add("X");
            tableResults.Columns.Add("PX");

            var res = from p in listOfXes
                      group p by p into o
                      select new { X = o.Key, Count = o.Count() };

            int m = Convert.ToInt32(textBoxM.Text);

            foreach (var k in res.Distinct().OrderBy(x => x.X))
            {
                tableResults.Rows.Add(k.X, Convert.ToDouble(k.Count) / Convert.ToDouble(m));
            }
        }

        public void drawPoissonChart()
        {
            chartPoisson.Series["Lambda"].Points.Clear();
            foreach (DataRow row in tableResults.Rows)
            {
                chartPoisson.Series["Lambda"].Points.AddXY(row["X"], Convert.ToDouble(row["PX"].ToString(), CultureInfo.CurrentCulture));
            }
        }

        private void radioButtonGauss_CheckedChanged(object sender, EventArgs e)
        {
            panelGaussSettings.Visible = true;
            panelPoissonSettings.Visible = false;
        }

        private void radioButtonPoisson_CheckedChanged(object sender, EventArgs e)
        {
            panelGaussSettings.Visible = false;
            panelPoissonSettings.Visible = true;
        }

        private void gaussDistribution()
        {
            double sigma = Convert.ToDouble(textBoxSigma.Text);
            double m = Convert.ToDouble(textBoxMaleM.Text);
            int binsNumber = 51;
            var bins = new int[binsNumber];
            Random r = new Random();
            for (var i = 0; i < binsNumber * Convert.ToInt32(textBoxMGauss.Text); i++)
            {
                double result = Generators.normalGaussian(r, m, sigma);
                double z = (result - m) / sigma;

                if (z > 3 || z < -3)
                {
                    continue;
                }

                int binKey = (int)((z + 3) * binsNumber / 6d);
                bins[binKey]++;
            }

            Series zSerie = new Series("Z");
            chartGauss.Series.Clear();
            chartGauss.Series.Add(zSerie);
            chartGauss.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chartGauss.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chartGauss.ChartAreas[0].AxisX.Minimum = m - 3 * sigma;
            chartGauss.ChartAreas[0].AxisX.LabelStyle.Interval = 1;
            chartGauss.Legends.Clear();

            for (int i = 0; i < binsNumber; i++)
            {
                zSerie.Points.AddXY(((i * 2d / binsNumber - 1) * 3 * sigma + m), bins[i]);
            }

            chartGauss.Visible = true;
        }
    }
}
