using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointsOfCircleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            btnCalculate.Enabled = false;
            try
            {
                // clear any text in output box
                txtOutput.Clear();

                // get values from UI
                double OriginX = Decimal.ToDouble(numericOriginX.Value);
                double OriginY = Decimal.ToDouble(numericOriginY.Value);
                double Radius = Decimal.ToDouble(numericRadius.Value);
                double NumberOfPoints = Decimal.ToDouble(numericNumberOfPoints.Value);

                // calculate Theata (degrees are needed in Cos, Sin functions)
                double Theta = (Math.PI * 2) / NumberOfPoints;

                double PointX = 0;
                double PointY = 0;

                for (int i = 1; i <= NumberOfPoints; i++)
                {
                    PointX = Radius * Math.Cos(Theta * i) + OriginX;
                    PointY = Radius * Math.Sin(Theta * i) + OriginY;

                    txtOutput.Text += System.Environment.NewLine + $"Point {i} should be located at position [x,y] [{ Math.Round(PointX, 2) },{ Math.Round(PointY, 2) }]";
                }

                btnCalculate.Enabled = true;
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
                btnCalculate.Enabled = true;
            }
           
        }
    }
}
