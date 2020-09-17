using System;
using System.Windows.Forms;


namespace _3_lab_func
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            graphField.ChartAreas[0].CursorX.IsUserEnabled = true;
            graphField.ChartAreas[0].CursorY.IsUserEnabled = true;

            graphField.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            graphField.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;

            graphField.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            graphField.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
        }

        private void buttonBuildGraph_Click(object sender, EventArgs e)
        {
            double tempX;
            double tempY;
            int currentRow = 0;
            graphField.Series[0].Points.Clear();
            valueTable.ColumnCount = 2;

            if (IsValidUserData((double)numericUpDownMinX.Value, (double)numericUpDownMaxX.Value, (double)numericUpDownStep.Value, (double)numericUpDownValueA.Value) == true)
                for (tempX = (double)numericUpDownMinX.Value; tempX <= (double)numericUpDownMaxX.Value; tempX += (double)numericUpDownStep.Value)
                {
                    tempY = (double)numericUpDownValueA.Value * Math.Cosh(tempX / (double)numericUpDownValueA.Value);
                    graphField.Series[0].Points.AddXY(tempX, tempY);
                    valueTable.Rows[currentRow].Cells[0].Value = tempX;
                    valueTable.Rows[currentRow].Cells[1].Value = tempY;
                    currentRow++;
                }
        }

        private bool IsValidUserData(double minX, double maxX, double step, double a)
        {
            if (maxX >= minX)
            {
                valueTable.RowCount = (int)((numericUpDownMaxX.Value - numericUpDownMinX.Value) / Math.Abs(numericUpDownStep.Value)) + 1;
            }
            else
            {
                MessageBox.Show("Can't build a graph. Minimum is greater than maximum of X.", "Error");
                return false;
            }

            if (a == 0)
            {
                MessageBox.Show("Invalid input data. Check coefficient field.","Error");
                return false;
            }

            if (minX == maxX)
            {
                MessageBox.Show("Your graphic is a point. Minimum and maximum of X are equal.", "Warning!");
                graphField.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
                return true;
            }
            return true;
        }
    }
}
