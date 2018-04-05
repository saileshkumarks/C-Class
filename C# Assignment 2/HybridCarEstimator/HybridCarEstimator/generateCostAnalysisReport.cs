using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HybridCarEstimator
{
    public partial class generateCostAnalysisReport : Form
    {

        DataTable finalReportTab = new DataTable();
        DataTable firstReport = new DataTable();

        public generateCostAnalysisReport()
        {
            InitializeComponent();
        }

        private void generateCostAnalysisReport_Load(object sender, EventArgs e)
        {

        }

        public void carArray(string totalCarsForComparison, string CityMilesTravelled, string HighwayMilesTravelled, double[] gasPrices, string [,] reportFromFormNew)
        {
            gasPricesArray(CityMilesTravelled, HighwayMilesTravelled, gasPrices);
            GetCostReportTable(totalCarsForComparison, reportFromFormNew);
        }
       

        public void gasPricesArray (string cityMiles, string highwayMiles, double [] averageGasPrices)
        {
            int currentYear = DateTime.Now.Year;
            string[,] topReportArray = new string[12, 2];

            //header
            topReportArray[0, 0] = "City miles";
            topReportArray[1, 0] = "Highway miles";
            topReportArray[2, 0] = (currentYear + 1).ToString();
            topReportArray[3, 0] = (currentYear + 2).ToString();
            topReportArray[4, 0] = (currentYear + 3).ToString();
            topReportArray[5, 0] = (currentYear + 4).ToString();
            topReportArray[6, 0] = (currentYear + 5).ToString();
            topReportArray[7, 0] = (currentYear + 6).ToString();
            topReportArray[8, 0] = (currentYear + 7).ToString();
            topReportArray[9, 0] = (currentYear + 8).ToString();
            topReportArray[10, 0] = (currentYear + 9).ToString();
            topReportArray[11, 0] = (currentYear + 10).ToString();

            //data
            topReportArray[0, 1] = cityMiles;
            topReportArray[1, 1] = highwayMiles;
            topReportArray[2, 1] = averageGasPrices[0].ToString();
            topReportArray[3, 1] = averageGasPrices[1].ToString();
            topReportArray[4, 1] = averageGasPrices[2].ToString();
            topReportArray[5, 1] = averageGasPrices[3].ToString();
            topReportArray[6, 1] = averageGasPrices[4].ToString();
            topReportArray[7, 1] = averageGasPrices[5].ToString();
            topReportArray[8, 1] = averageGasPrices[6].ToString();
            topReportArray[9, 1] = averageGasPrices[7].ToString();
            topReportArray[10, 1] = averageGasPrices[8].ToString();
            topReportArray[11, 1] = averageGasPrices[9].ToString();

            GetTopReportTable(topReportArray);
        }

        private void GetTopReportTable(string[,] reportArray1)
        {
            DataTable table1 = new DataTable();
            table1.Columns.Add("Header", typeof(string));
            table1.Columns.Add("Data", typeof(string));
            
            for (int outerIndex = 0; outerIndex <= 11 ; outerIndex++)
            {
                DataRow newRow = table1.NewRow();
                for (int innerIndex = 0; innerIndex <= 1; innerIndex++)
                {
                    newRow[innerIndex] = reportArray1[outerIndex, innerIndex];
                }
                table1.Rows.Add(newRow);
            }

            dataGridViewReport1.DataSource = table1;
            firstReport = table1;

        }

        private void GetCostReportTable(string totalCars, string[,] reportArray2)
        {
            DataTable table2 = new DataTable();
            table2.Columns.Add("CarMake", typeof(string));
            table2.Columns.Add("CarModel", typeof(string));
            table2.Columns.Add("CityMileageRating", typeof(string));
            table2.Columns.Add("HighwayMileageRating", typeof(string));
            table2.Columns.Add("InitialCarPrice", typeof(string));
            table2.Columns.Add("TotalCostofGas", typeof(string));
            table2.Columns.Add("TotalCostOfOwnership", typeof(string));

            for (int outerIndex = 0; outerIndex <= 3; outerIndex++)
            {
                DataRow newRow = table2.NewRow();
                for (int innerIndex = 0; innerIndex <= 6; innerIndex++)
                {
                    newRow[innerIndex] = reportArray2[outerIndex, innerIndex];
                }
                table2.Rows.Add(newRow);
            }

            if (totalCars == "1")
            {
                table2.Rows[3].Delete();
                table2.Rows[2].Delete();
                table2.Rows[1].Delete();
                table2.AcceptChanges();
            }
            else if (totalCars == "2")
            {
                table2.Rows[3].Delete();
                table2.Rows[2].Delete();
                table2.AcceptChanges();
            }
            else if (totalCars == "3")
            {
                table2.Rows[3].Delete();
                table2.AcceptChanges();
            }

            table2.DefaultView.Sort = "CarMake ASC";
            txtMulitline.Lines = table2.AsEnumerable().Select(row => String.Join(",", row.ItemArray) + ";").ToArray();

            dataGridViewReport2.DataSource = table2;
            finalReportTab = table2;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
           

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    string filename = saveFileDialog1.FileName;
                    saveFileDialog1.Dispose();


                    StreamWriter strWriter = new StreamWriter(filename + ".txt");

                        int i;
                        /*foreach (DataRow row in firstReport.Rows)
                        {
                            object[] array = row.ItemArray;
                            for (i = 0; i < array.Length - 1; i++)
                            {
                                strWriter.Write(array[i].ToString() + " | ");
                            }
                            strWriter.WriteLine(array[i].ToString());
                        }*/
                        foreach (DataRow row in finalReportTab.Rows)
                        {
                            object[] array = row.ItemArray;
                            for (i = 0; i < array.Length - 1; i++)
                            {
                                strWriter.Write(array[i].ToString() + " | ");
                            }
                            strWriter.WriteLine(array[i].ToString());
                        }
                        
                        strWriter.AutoFlush = true;
                        strWriter.Flush();
                        strWriter.Dispose();
                        strWriter.Close();

                        MessageBox.Show("Data has been saved to the file successfully!");
                }
            }
        }

        private void dataGridViewReport1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
