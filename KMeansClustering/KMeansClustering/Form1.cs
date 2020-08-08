using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

using System.Reflection;
using System.IO;


namespace KMeansClustering
{
    public partial class Form1 : Form
    {
        List<DataPoint> _rawDataToCluster = new List<DataPoint>();
        List<DataPoint> _normalizedDataToCluster = new List<DataPoint>();
        List<DataPoint> _clusters = new List<DataPoint>();
        private int _numberOfClusters = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void NormalizeData()
        {
            double heightSum = 0.0;
            double weightSum = 0.0;
            foreach (DataPoint dataPoint in _rawDataToCluster)
            {
                heightSum += dataPoint.Height;
                weightSum += dataPoint.Weight;
            }
            double heightMean = heightSum / _rawDataToCluster.Count;
            double weightMean = weightSum / _rawDataToCluster.Count;
            double sumHeight = 0.0;
            double sumWeight = 0.0;
            foreach (DataPoint dataPoint in _rawDataToCluster)
            {
                sumHeight += Math.Pow(dataPoint.Height - heightMean, 2);
                sumWeight += Math.Pow(dataPoint.Weight - weightMean, 2);
                //sumWeight += (dataPoint.Weight - weightMean) * (dataPoint.Weight - weightMean);

            }
            double heightSD = sumHeight / _rawDataToCluster.Count;
            double weightSD = sumWeight / _rawDataToCluster.Count;
            foreach (DataPoint dataPoint in _rawDataToCluster)
            {
                _normalizedDataToCluster.Add(new DataPoint()
                {
                    Height = (dataPoint.Height - heightMean) / heightSD,
                    Weight = (dataPoint.Weight - weightMean) / weightSD
                }
                    );
            }
        }

        private void InitilizeRawData()
        {
            if (_rawDataToCluster.Count == 0)
            {
                string lstRawDataItem = string.Empty;
                for (int i = 0; i < lstRawData.Items.Count; i++)
                {
                    DataPoint dp = new DataPoint();
                    lstRawDataItem = lstRawData.Items[i].ToString();
                    lstRawDataItem = lstRawDataItem.Replace("{", "");
                    lstRawDataItem = lstRawDataItem.Replace("}", "");
                    string[] data = lstRawDataItem.Split(',');
                    dp.Height = double.Parse(data[0]);
                    dp.Weight = double.Parse(data[1]);
                    _rawDataToCluster.Add(dp);
                }
            }
        }

        private void ShowData(List<DataPoint> data, int decimals, TextBox outPut)
        {
            foreach (DataPoint dp in data)
            {
                outPut.Text += dp.ToString() + Environment.NewLine;
            }
        }

        private void InitializeCentroids()
        {
            Random random = new Random(_numberOfClusters);
            for (int i = 0; i < _numberOfClusters; ++i)
            {
                _normalizedDataToCluster[i].Cluster = _rawDataToCluster[i].Cluster = i;
            }
            for (int i = _numberOfClusters; i < _normalizedDataToCluster.Count; i++)
            {
                _normalizedDataToCluster[i].Cluster = _rawDataToCluster[i].Cluster = random.Next(0, _numberOfClusters);
            }
        }
        private bool UpdateDataPointMeans()
        {
            if (EmptyCluster(_normalizedDataToCluster)) return false;

            var groupToComputeMeans = _normalizedDataToCluster.GroupBy(s => s.Cluster).OrderBy(s => s.Key);
            int clusterIndex = 0;
            double height = 0.0;
            double weight = 0.0;
            foreach (var item in groupToComputeMeans)
            {
                foreach (var value in item)
                {
                    height += value.Height;
                    weight += value.Weight;
                }
                _clusters[clusterIndex].Height = height / item.Count();
                _clusters[clusterIndex].Weight = weight / item.Count();
                clusterIndex++;
                height = 0.0;
                weight = 0.0;
            }
            return true;
        }

        private bool EmptyCluster(List<DataPoint> data)
        {
            var emptyCluster =
                data.GroupBy(s => s.Cluster).OrderBy(s => s.Key).Select(g => new { Cluster = g.Key, Count = g.Count() });

            foreach (var item in emptyCluster)
            {
                if (item.Count == 0)
                {
                    return true;
                }
            }
            return false;
        }

        private bool UpdateClusterMembership()
        {
            bool changed = false;

            double[] distances = new double[_numberOfClusters];

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < _normalizedDataToCluster.Count; ++i)
            {

                for (int k = 0; k < _numberOfClusters; ++k)
                    distances[k] = ElucidanDistance(_normalizedDataToCluster[i], _clusters[k]);

                int newClusterId = MinIndex(distances);
                if (newClusterId != _normalizedDataToCluster[i].Cluster)
                {
                    changed = true;
                    _normalizedDataToCluster[i].Cluster = _rawDataToCluster[i].Cluster = newClusterId;
                    sb.AppendLine("Data Point >> Sr.No: " + _rawDataToCluster[i].Height + ", EventID: " +
                                  _rawDataToCluster[i].Weight + " moved to Cluster # " + newClusterId);
                }
                else
                {
                    sb.AppendLine("No change.");
                }
                sb.AppendLine("------------------------------");
                txtIterations.Text += sb.ToString();

            }
            if (changed == false)
                return false;
            if (EmptyCluster(_normalizedDataToCluster)) return false;
            return true;
        }

        private double ElucidanDistance(DataPoint dataPoint, DataPoint mean)
        {
            double _diffs = 0.0;
            _diffs = Math.Pow(dataPoint.Height - mean.Height, 2);
            _diffs += Math.Pow(dataPoint.Weight - mean.Weight, 2);
            return Math.Sqrt(_diffs);
        }

        private int MinIndex(double[] distances)
        {
            int _indexOfMin = 0;
            double _smallDist = distances[0];
            for (int k = 0; k < distances.Length; ++k)
            {
                if (distances[k] < _smallDist)
                {
                    _smallDist = distances[k];
                    _indexOfMin = k;
                }
            }
            return _indexOfMin;
        }

        public void Cluster()
        {
            bool _changed = true;
            bool _success = true;
            InitializeCentroids();

            int maxIteration = _normalizedDataToCluster.Count * 10;
            int _threshold = 0;
            while (_success == true && _changed == true && _threshold < maxIteration)
            {
                ++_threshold;
                _success = UpdateDataPointMeans();
                _changed = UpdateClusterMembership();
            }
        }

        private void txtWeight_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(txtHeight.Text) || string.IsNullOrEmpty(txtWeight.Text))
                {
                    MessageBox.Show("Please enter the values for both Height and Weight.");
                    return;
                }
                DataPoint dp = new DataPoint();
                dp.Height = double.Parse(txtHeight.Text);
                dp.Weight = double.Parse(txtWeight.Text);
                lstRawData.Items.Add(dp.ToString());
            }
        }

        private void btnNormalize_Click(object sender, EventArgs e)
        {
            InitilizeRawData();
            NormalizeData();
            ShowData(_normalizedDataToCluster, 1, txtNormalized);
            btnCluster.Visible = true;

        }

        private void btnCluster_Click(object sender, EventArgs e)
        {
            InitilizeRawData();
            _numberOfClusters = int.Parse(txtNumberOfClusters.Text);

            //initialize the clusters (Setting indeces)
            for (int i = 0; i < _numberOfClusters; i++)
            {
                _clusters.Add(new DataPoint() { Cluster = i });
            }

            Cluster();
            StringBuilder sb = new StringBuilder();
            var group = _rawDataToCluster.GroupBy(s => s.Cluster).OrderBy(s => s.Key);
            foreach (var g in group)
            {
                sb.AppendLine("Cluster # " + g.Key + ":");
                foreach (var value in g)
                {
                    sb.Append(value.ToString());
                    sb.AppendLine();
                }
                sb.AppendLine("------------------------------");
            }
            txtOutput.Text = sb.ToString();
        }

        
        Missing mv = Missing.Value;
        private void button1_Click(object sender, EventArgs e)
        {
            string path="";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog1.FileName.ToString();
                        
            }
            Path.Text = path;
            // Get the Excel application object.
            Excel.Application excel_app = new Excel.Application();

            // Make Excel visible (optional).
            excel_app.Visible = true;

            // Open the workbook read-only.
            Excel.Workbook workbook = excel_app.Workbooks.Open(path,
                Type.Missing, true, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing);

            // Get the first worksheet.
            Excel.Worksheet sheet = (Excel.Worksheet)workbook.Sheets[1];



            SetTitleAndListValues(sheet,2,4,label1,lstRawData);

            // Close the workbook without saving changes.
            workbook.Close(false, Type.Missing, Type.Missing);

            // Close the Excel server.
            excel_app.Quit();
        }

        // Set a title Label and the values in a ListBox.
        // Get the title from cell (row, col). Get the values from
        // cell (row + 1, col) to the end of the column.
        private void SetTitleAndListValues(Excel.Worksheet sheet,
            int row, int col, Label lbl, ListBox lst)
        {
            Excel.Range range;

            // Set the title.
            range = (Excel.Range)sheet.Cells[row, col];
           // lbl.Text = (string)range.Value2;
            //lbl.ForeColor = System.Drawing.ColorTranslator.FromOle(
            //    (int)(double)range.Font.Color);
            //lbl.BackColor = System.Drawing.ColorTranslator.FromOle(
            //    (int)(double)range.Interior.Color);

            // Get the values.
            // Find the last cell in the column.
            range = (Excel.Range)sheet.Columns[col, Type.Missing];
            Excel.Range last_cell = range.get_End(Excel.XlDirection.xlDown);

            // Get a Range holding the values.
            Excel.Range first_cell = (Excel.Range)sheet.Cells[row + 1, col];
            Excel.Range value_range = (Excel.Range)sheet.get_Range(first_cell, last_cell);

            // Get the values.
            object[,] range_values = (object[,])value_range.Value2;

            // Convert this into a 1-dimensional array.
            // Note that the Range's array has lower bounds 1.
            int num_items = range_values.GetUpperBound(0);
            string[] values1 = new string[num_items];
            int num;
            Random rnd = new Random();
            for (int i = 0; i < num_items; i++)
            {
                
                num = rnd.Next(1,1000);

                values1[i] = "{"+(string)range_values[i + 1, 1].ToString()+","+num+"}";
            }


            // Display the values in the ListBox.
            lstRawData.DataSource = values1;
            btnNormalize.Visible = true;
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            // set a default file name
            savefile.FileName = "Clustering_Report.txt";
            // set filters - this can be done in properties as well
            savefile.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(savefile.FileName))
                    sw.WriteLine(txtOutput.Text);
            }
            MessageBox.Show("Report Saved Successfully...!!!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }
    }

}
