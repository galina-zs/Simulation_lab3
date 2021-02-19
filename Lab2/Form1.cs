using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        //decimal t = 0, x, y, v0, cosa, sina, S, m, k, vx, vy;
        //double maxX, maxY;
        int time_after_start = 0;
        Formula formula;

        public Form1()
        {
            InitializeComponent();
            pauseButton.Enabled = false;
            continueButton.Enabled = false;
        }

        private void launchButton_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                chart1.Series[0].Points.Clear();

                formula = new Formula(heightNumericUpDown1.Value,
                                      speedNumericUpDown2.Value,
                                      (double)angleNumericUpDown1.Value * Math.PI / 180,
                                      sizeNumericUpDown.Value,
                                      weightNumericUpDown.Value);
                
                chart1.Series[0].Points.AddXY(0, formula.coordinates.y);
                timer1.Start();

                time_after_start = 0;

                pauseButton.Enabled = true;
                continueButton.Enabled = false;

                //FindMaximum();
                //chart1.ChartAreas[0].AxisX.Maximum = maxX;
                //chart1.ChartAreas[0].AxisY.Maximum = maxY;

                timer1.Start();
            }
        }

        //private void FindMaximum()
        //{
        //    double time = ((double)(v0 * sina) + Math.Sqrt((double)(v0 * v0 * sina * sina) + (double)(2 * g * heightNumericUpDown1.Value))) / (double)g;
            
        //    maxX = (double)(v0 * cosa) * time;
        //    //maxX = Math.Ceiling(maxX) + 2;

        //    maxY = (double)heightNumericUpDown1.Value + (double)(v0 * v0 * sina * sina) / (double)(2 * g);
        //    //maxY = Math.Ceiling(maxY) + 2;
        //}

        private void pauseButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            pauseButton.Enabled = false;
            continueButton.Enabled = true;
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            timer1.Start();
            pauseButton.Enabled = true;
            continueButton.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            formula.FindNewCoordinates();
            chart1.Series[0].Points.AddXY(formula.coordinates.x, formula.coordinates.y);

            distanceLabel.Text = "Distance: " + formula.coordinates.x;

            time_after_start += timer1.Interval;
            if (time_after_start % 1000 == 0)
            {
                var timespan = TimeSpan.FromSeconds(time_after_start / 1000);
                timerLabel.Text = timespan.ToString(@"mm\:ss");
            }

            if (formula.coordinates.y <= 0)
            {
                timer1.Stop();
                pauseButton.Enabled = false;
                continueButton.Enabled = false;
            }
        }
    }
}
