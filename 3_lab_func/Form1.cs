using System;
using System.IO;
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
                    tempY = FuncClass.GetPointY((double)numericUpDownValueA.Value, tempX);
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

        private void aboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Program developed by Krupsky Artemy, student of 484 gr.\nThe program builds a graph of the function.", "About program");
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            ofd.DefaultExt = "txt";
            ofd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string Filename = ofd.FileName;
                try
                {
                    using (StreamReader Stream = new StreamReader(Filename))
                    {
                        numericUpDownMinX.Value = Convert.ToDecimal(Stream.ReadLine());
                        numericUpDownMaxX.Value = Convert.ToDecimal(Stream.ReadLine());
                        numericUpDownStep.Value = Convert.ToDecimal(Stream.ReadLine());
                        numericUpDownValueA.Value = Convert.ToDecimal(Stream.ReadLine());
                    }
                }
                catch
                {
                        MessageBox.Show("Unable to read file", "Error");
                }

            }
            else
            {
                    MessageBox.Show("Unable to open file", "Error");
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saving output data", "Notification");
            sfd.DefaultExt = "txt";
            sfd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string filename = sfd.FileName;

                using (StreamWriter streamWriter = new StreamWriter(filename))
                {
                    streamWriter.WriteLine("x:      y:");

                    for (int row = 0; row < valueTable.Rows.Count; row++)
                    {
                        for (int column = 0; column < valueTable.Columns.Count; column++)
                        {
                            streamWriter.Write(valueTable.Rows[row].Cells[column].Value);
                            streamWriter.Write(" ");
                        }
                        streamWriter.WriteLine();
                    }
                }
            }

            MessageBox.Show("Saving input data", "Notification");
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string filename = sfd.FileName;

                using (StreamWriter streamWriter = new StreamWriter(filename))
                {
                    streamWriter.WriteLine(numericUpDownMinX.Value);
                    streamWriter.WriteLine(numericUpDownMaxX.Value);
                    streamWriter.WriteLine(numericUpDownStep.Value);
                    streamWriter.Write(numericUpDownValueA.Value);
                }       
            }
        }
    }
}
