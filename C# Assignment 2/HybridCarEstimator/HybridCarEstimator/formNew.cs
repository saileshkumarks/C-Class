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
    public partial class formNew : Form
    {

        /*string[] arrayCarManufacturer = 
        { "Select", "Chevrolet", "Ford", "Honda", "Toyota", "Mazda", "Volkswagen", "Fiat", "Lexus", "Acura", "Audi", "Jeep",
            "Dodge", "Chrysler", "Mercedes-Benz", "Cadillac", "Buick", "GMC", "Lincoln", "Infiniti", "Hyundai", "Kia"};*/
        string[] arrayCarManufacturer = 
        { "Select", "Chevrolet", "Ford", "Honda", "Toyota"};

        

        public formNew()
        {
            InitializeComponent();
        }


        private void formNew_Load(object sender, EventArgs e)
        {
            int currentYear = DateTime.Now.Year;

            lblGasPriceYear1.Text = Convert.ToString(currentYear);
            lblGasPriceYear2.Text = Convert.ToString(currentYear + 1);
            lblGasPriceYear3.Text = Convert.ToString(currentYear + 2);
            lblGasPriceYear4.Text = Convert.ToString(currentYear + 3);
            lblGasPriceYear5.Text = Convert.ToString(currentYear + 4);
            lblGasPriceYear6.Text = Convert.ToString(currentYear + 5);
            lblGasPriceYear7.Text = Convert.ToString(currentYear + 6);
            lblGasPriceYear8.Text = Convert.ToString(currentYear + 7);
            lblGasPriceYear9.Text = Convert.ToString(currentYear + 8);
            lblGasPriceYear10.Text = Convert.ToString(currentYear + 9);

            /*comboCarMake1.DataSource = arrayCarManufacturer;
            comboCarMake2.DataSource = arrayCarManufacturer;
            comboCarMake3.DataSource = arrayCarManufacturer;
            comboCarMake4.DataSource = arrayCarManufacturer;*/

            comboCarMake1.Items.Add("Select");
            comboCarMake1.Items.Add("Chevrolet");
            comboCarMake1.Items.Add("Ford");
            comboCarMake1.Items.Add("Honda");
            comboCarMake1.Items.Add("Toyota");

            comboCarMake2.Items.Add("Select");
            comboCarMake2.Items.Add("Chevrolet");
            comboCarMake2.Items.Add("Ford");
            comboCarMake2.Items.Add("Honda");
            comboCarMake2.Items.Add("Toyota");

            comboCarMake3.Items.Add("Select");
            comboCarMake3.Items.Add("Chevrolet");
            comboCarMake3.Items.Add("Ford");
            comboCarMake3.Items.Add("Honda");
            comboCarMake3.Items.Add("Toyota");

            comboCarMake4.Items.Add("Select");
            comboCarMake4.Items.Add("Chevrolet");
            comboCarMake4.Items.Add("Ford");
            comboCarMake4.Items.Add("Honda");
            comboCarMake4.Items.Add("Toyota");

            comboCarMake1.SelectedIndex = 0;
            comboCarMake2.SelectedIndex = 0;
            comboCarMake3.SelectedIndex = 0;
            comboCarMake4.SelectedIndex = 0;

            chkAmortizationReport.Checked = false;
            chkCalculateAmortizationReport.Checked = false;
            grpBoxCarSelection.Enabled = false;
            grpBoxAmortizationReport.Enabled = false;

            txtNumberOfCars.Text = "1";
        }

        # region UI Controls

        private void lblMileageRating_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnResetGroupBox_Click(object sender, EventArgs e)
        {
            radioBtnCar1.Checked = false;
            radioBtnCar2.Checked = false;
            radioBtnCar3.Checked = false;
            radioBtnCar4.Checked = false;
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            radioBtnCar1.Checked = false;
            radioBtnCar2.Checked = false;
            radioBtnCar3.Checked = false;
            radioBtnCar4.Checked = false;
        }

        private void chkAmortizationReport_CheckedChanged(object sender, EventArgs e)
        {
            if(chkAmortizationReport.Checked == true)
            {
                grpBoxCarSelection.Enabled = true;
                chkCalculateAmortizationReport.Enabled = true;
            }
            else
            {
                grpBoxCarSelection.Enabled = false;
                chkCalculateAmortizationReport.Enabled = false;
            }
        }

        # endregion

        # region Amortization report UI Controls

        private void txtNumberOfCars_TextChanged(object sender, EventArgs e)
        {
            if(txtNumberOfCars.Text == "1")
            {
                radioBtnCar1.Enabled = true; radioBtnCar2.Enabled = false;
                radioBtnCar3.Enabled = false; radioBtnCar4.Enabled = false;
                comboCarMake1.Enabled = true; comboCarMake2.Enabled = false;
                comboCarMake3.Enabled = false; comboCarMake4.Enabled = false;
                txtCarModel1.Enabled = true; txtCarModel2.Enabled = false;
                txtCarModel3.Enabled = false; txtCarModel4.Enabled = false;
                txtInitialPriceCar1.Enabled = true; txtInitialPriceCar2.Enabled = false;
                txtInitialPriceCar3.Enabled = false; txtInitialPriceCar4.Enabled = false;
                txtCityMileageCar1.Enabled = true; txtCityMileageCar2.Enabled = false;
                txtCityMileageCar3.Enabled = false; txtCityMileageCar4.Enabled = false;
                txtHwyMileageCar1.Enabled = true; txtHwyMileageCar2.Enabled = false;
                txtHwyMileageCar3.Enabled = false; txtHwyMileageCar4.Enabled = false;
            }
            else if(txtNumberOfCars.Text == "2")
            {
                radioBtnCar1.Enabled = true;radioBtnCar2.Enabled = true;
                radioBtnCar3.Enabled = false;radioBtnCar4.Enabled = false;
                comboCarMake1.Enabled = true;comboCarMake2.Enabled = true;
                comboCarMake3.Enabled = false;comboCarMake4.Enabled = false;
                txtCarModel1.Enabled = true; txtCarModel2.Enabled = true;
                txtCarModel3.Enabled = false; txtCarModel4.Enabled = false;
                txtInitialPriceCar1.Enabled = true; txtInitialPriceCar2.Enabled = true;
                txtInitialPriceCar3.Enabled = false; txtInitialPriceCar4.Enabled = false;
                txtCityMileageCar1.Enabled = true; txtCityMileageCar2.Enabled = true;
                txtCityMileageCar3.Enabled = false; txtCityMileageCar4.Enabled = false;
                txtHwyMileageCar1.Enabled = true; txtHwyMileageCar2.Enabled = true;
                txtHwyMileageCar3.Enabled = false; txtHwyMileageCar4.Enabled = false;
            }
            else if (txtNumberOfCars.Text == "3")
            {
                radioBtnCar1.Enabled = true;radioBtnCar2.Enabled = true;
                radioBtnCar3.Enabled = true;radioBtnCar4.Enabled = false;
                comboCarMake1.Enabled = true;comboCarMake2.Enabled = true;
                comboCarMake3.Enabled = true;comboCarMake4.Enabled = false;
                txtCarModel1.Enabled = true; txtCarModel2.Enabled = true;
                txtCarModel3.Enabled = true; txtCarModel4.Enabled = false;
                txtInitialPriceCar1.Enabled = true; txtInitialPriceCar2.Enabled = true;
                txtInitialPriceCar3.Enabled = true; txtInitialPriceCar4.Enabled = false;
                txtCityMileageCar1.Enabled = true; txtCityMileageCar2.Enabled = true;
                txtCityMileageCar3.Enabled = true; txtCityMileageCar4.Enabled = false;
                txtHwyMileageCar1.Enabled = true; txtHwyMileageCar2.Enabled = true;
                txtHwyMileageCar3.Enabled = true; txtHwyMileageCar4.Enabled = false;
            }
            else if (txtNumberOfCars.Text == "4")
            {
                radioBtnCar1.Enabled = true;radioBtnCar2.Enabled = true;
                radioBtnCar3.Enabled = true;radioBtnCar4.Enabled = true;
                comboCarMake1.Enabled = true;comboCarMake2.Enabled = true;
                comboCarMake3.Enabled = true;comboCarMake4.Enabled = true;
                txtCarModel1.Enabled = true; txtCarModel2.Enabled = true;
                txtCarModel3.Enabled = true; txtCarModel4.Enabled = true;
                txtInitialPriceCar1.Enabled = true; txtInitialPriceCar2.Enabled = true;
                txtInitialPriceCar3.Enabled = true; txtInitialPriceCar4.Enabled = true;
                txtCityMileageCar1.Enabled = true; txtCityMileageCar2.Enabled = true;
                txtCityMileageCar3.Enabled = true; txtCityMileageCar4.Enabled = true;
                txtHwyMileageCar1.Enabled = true; txtHwyMileageCar2.Enabled = true;
                txtHwyMileageCar3.Enabled = true; txtHwyMileageCar4.Enabled = true;
            }
            else
            {
                MessageBox.Show("Enter values between 1 and 4 only");
            }
        }

        private void button1_Click(object sender, EventArgs e) //btnCalculateAmortizationReport
        {
            generateAmortizationReport amortizationReport = new generateAmortizationReport();

            double carPrice = Convert.ToDouble(txtCarPriceAmRprt.Text);
            double downPayment = Convert.ToDouble(txtDownPaymentAmt.Text);
            double interestRate = Convert.ToDouble(txtROI.Text);
            double loanPeriod = Convert.ToDouble(txtLoanPeriod.Text);

            amortizationReport.amortization(carPrice, downPayment, interestRate, loanPeriod);
            amortizationReport.Show();
        }

        private void txtCarPriceAmRprt_TextChanged(object sender, EventArgs e)
        {
        }

        private void radioBtnCar1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnCar1.Checked == true)
            {
                txtCarPriceAmRprt.Text = txtInitialPriceCar1.Text;
            }
        }

        private void txtInitialPriceCar1_TextChanged(object sender, EventArgs e)
        {
            if (radioBtnCar1.Checked == true)
            {
                txtCarPriceAmRprt.Text = txtInitialPriceCar1.Text;
            }
        }

        private void radioBtnCar2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnCar2.Checked == true)
            {
                txtCarPriceAmRprt.Text = txtInitialPriceCar2.Text;
            }
        }

        private void radioBtnCar3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnCar3.Checked == true)
            {
                txtCarPriceAmRprt.Text = txtInitialPriceCar3.Text;
            }
        }

        private void radioBtnCar4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnCar4.Checked == true)
            {
                txtCarPriceAmRprt.Text = txtInitialPriceCar4.Text;
            }
        }

       
        
        private void txtInitialPriceCar2_TextChanged(object sender, EventArgs e)
        {
            if(radioBtnCar2.Enabled == true)
            {
                txtCarPriceAmRprt.Text = txtInitialPriceCar2.Text;
            }
        }

        private void txtInitialPriceCar3_TextChanged(object sender, EventArgs e)
        {
            if(radioBtnCar3.Enabled == true)
            {
                txtCarPriceAmRprt.Text = txtInitialPriceCar3.Text;
            }
        }

        private void txtInitialPriceCar4_TextChanged(object sender, EventArgs e)
        {
            if(radioBtnCar4.Enabled == true)
            {
                txtInitialPriceCar4.Text = txtInitialPriceCar4.Text;
            }
        }

        private void chkCalculateAmortizationReport_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCalculateAmortizationReport.Checked == true)
            {
                grpBoxAmortizationReport.Enabled = true;
            }
            else if (chkCalculateAmortizationReport.Checked == false)
            {
                grpBoxAmortizationReport.Enabled = false;
            }
        }

        # endregion


        private void btnOK_Click(object sender, EventArgs e)
        {
            string[,] report = new string[4, 7];
            double[] gasPriceForTenYears = new double[10];

            string make1, make2, make3, make4, model1, model2, model3, model4;
            string cityMPG1, cityMPG2, cityMPG3, cityMPG4, highwayMPG1, highwayMPG2, highwayMPG3, highwayMPG4;
            string initialCarPrice1, initialCarPrice2, initialCarPrice3, initialCarPrice4;

            string numberOfCarsForComparing = txtNumberOfCars.Text.ToString();
            string cityMilesPerYear = txtCityMiles.Text;
            string highwayMilesPerYear = txtHighwayMiles.Text;
          
            //Gas prices
            gasPriceForTenYears[0] = Convert.ToDouble(txtGasPriceYear1.Text);
            gasPriceForTenYears[1] = Convert.ToDouble(txtGasPriceYear2.Text);
            gasPriceForTenYears[2] = Convert.ToDouble(txtGasPriceYear3.Text);
            gasPriceForTenYears[3] = Convert.ToDouble(txtGasPriceYear4.Text);
            gasPriceForTenYears[4] = Convert.ToDouble(txtGasPriceYear5.Text);
            gasPriceForTenYears[5] = Convert.ToDouble(txtGasPriceYear6.Text);
            gasPriceForTenYears[6] = Convert.ToDouble(txtGasPriceYear7.Text);
            gasPriceForTenYears[7] = Convert.ToDouble(txtGasPriceYear8.Text);
            gasPriceForTenYears[8] = Convert.ToDouble(txtGasPriceYear9.Text);
            gasPriceForTenYears[9] = Convert.ToDouble(txtGasPriceYear10.Text);

            make1 = comboCarMake1.SelectedItem.ToString();
            make2 = comboCarMake2.SelectedItem.ToString();
            make3 = comboCarMake3.SelectedItem.ToString();
            make4 = comboCarMake4.SelectedItem.ToString();

            model1 = txtCarModel1.Text.ToString();
            model2 = txtCarModel2.Text.ToString();
            model3 = txtCarModel3.Text.ToString();
            model4 = txtCarModel4.Text.ToString();
                        
            cityMPG1 = txtCityMileageCar1.Text;
            cityMPG2 = txtCityMileageCar2.Text;
            cityMPG3 = txtCityMileageCar3.Text;
            cityMPG4 = txtCityMileageCar4.Text;

            highwayMPG1 = txtHwyMileageCar1.Text;
            highwayMPG2 = txtHwyMileageCar2.Text;
            highwayMPG3 = txtHwyMileageCar3.Text;
            highwayMPG4 = txtHwyMileageCar4.Text;

            initialCarPrice1 = txtInitialPriceCar1.Text;
            initialCarPrice2 = txtInitialPriceCar2.Text;
            initialCarPrice3 = txtInitialPriceCar3.Text;
            initialCarPrice4 = txtInitialPriceCar4.Text;

            Car carObject = new Car();

            if (numberOfCarsForComparing == "1")
            {
                carObject.CalculateCostOverTenYearsCar1(numberOfCarsForComparing, cityMilesPerYear, highwayMilesPerYear,
                gasPriceForTenYears, make1, model1, initialCarPrice1, cityMPG1, highwayMPG1);
            }

            if (numberOfCarsForComparing == "2")
            {
                carObject.CalculateCostOverTenYearsCar1(numberOfCarsForComparing, cityMilesPerYear, highwayMilesPerYear,
                gasPriceForTenYears, make1, model1, initialCarPrice1, cityMPG1, highwayMPG1);
                carObject.CalculateCostOverTenYearsCar2(numberOfCarsForComparing, cityMilesPerYear, highwayMilesPerYear,
                gasPriceForTenYears, make2, model2, initialCarPrice2, cityMPG2, highwayMPG2);
            }
            else if (numberOfCarsForComparing == "3")
            {
                carObject.CalculateCostOverTenYearsCar1(numberOfCarsForComparing, cityMilesPerYear, highwayMilesPerYear,
                gasPriceForTenYears, make1, model1, initialCarPrice1, cityMPG1, highwayMPG1);
                carObject.CalculateCostOverTenYearsCar2(numberOfCarsForComparing, cityMilesPerYear, highwayMilesPerYear,
                gasPriceForTenYears, make2, model2, initialCarPrice2, cityMPG2, highwayMPG2);
                carObject.CalculateCostOverTenYearsCar3(numberOfCarsForComparing, cityMilesPerYear, highwayMilesPerYear,
                gasPriceForTenYears, make3, model3, initialCarPrice3, cityMPG3, highwayMPG3);             
            }
            else if (numberOfCarsForComparing == "4")
            {
                carObject.CalculateCostOverTenYearsCar1(numberOfCarsForComparing, cityMilesPerYear, highwayMilesPerYear,
                gasPriceForTenYears, make1, model1, initialCarPrice1, cityMPG1, highwayMPG1);
                carObject.CalculateCostOverTenYearsCar2(numberOfCarsForComparing, cityMilesPerYear, highwayMilesPerYear,
                gasPriceForTenYears, make2, model2, initialCarPrice2, cityMPG2, highwayMPG2);
                carObject.CalculateCostOverTenYearsCar3(numberOfCarsForComparing, cityMilesPerYear, highwayMilesPerYear,
                gasPriceForTenYears, make3, model3, initialCarPrice3, cityMPG3, highwayMPG3);
                carObject.CalculateCostOverTenYearsCar4(numberOfCarsForComparing, cityMilesPerYear, highwayMilesPerYear,
                gasPriceForTenYears, make4, model4, initialCarPrice4, cityMPG4, highwayMPG4);               
            }

            report = carObject.TheFinalReport;

            generateCostAnalysisReport formGenerateCostReport = new generateCostAnalysisReport();
            formGenerateCostReport.carArray(numberOfCarsForComparing, cityMilesPerYear, highwayMilesPerYear, gasPriceForTenYears, carObject.TheFinalReport);
            formGenerateCostReport.Show();
        }

        # region Car Class

        public class Car
        {
            formNew fnew = new formNew();

             static string[,] carOwnershipReport = new string[4, 7];
          

            private string make;

            public string Make
            {
                get { return make; }
                set { make = value; }
            }

            private string model;

            public string Model
            {
                get { return model; }
                set { model = value; }
            }

            private double cityMilesPerYear;

            public double CityMilesPerYear
            {
                get { return cityMilesPerYear; }
                set { cityMilesPerYear = value; }
            }

            private double highwayMilesPerYear;

            public double HighwayMilesPerYear
            {
                get { return highwayMilesPerYear; }
                set { highwayMilesPerYear = value; }
            }

            private int cityMileageRating;

            public int CityMileageRating
            {
                get { return cityMileageRating; }
                set { cityMileageRating = value; }
            }

            private int highwayMileageRating;

            public int HighwayMileageRating
            {
                get { return highwayMileageRating; }
                set { highwayMileageRating = value; }
            }

            private double initialPriceOfCar;

            public double InitialPriceOfCar
            {
                get { return initialPriceOfCar; }
                set { initialPriceOfCar = value; }
            }

            private double totalcostOverTenYears;

            public double TotalCostOverTenYears
            {
                get { return totalcostOverTenYears; }
                set { totalcostOverTenYears = value; }
            }

            private string[,] theFinalReport;

            public string[,] TheFinalReport
            {
                get { return theFinalReport; }
                set { theFinalReport = value; }
            }
            
            public Car()
            {

            }

            public formNew freshCompare;
            public Car(formNew fnew)
            {
                this.freshCompare = fnew;
            }

            public Car(string Make, string Model, double CityMilesPerYear, double HighwayMilesPerYear, double InitialPriceOfCar, string[,] TheFinalReport)
            {
                make = Make;
                model = Model;
                cityMilesPerYear = CityMilesPerYear;
                highwayMilesPerYear = HighwayMilesPerYear;
                initialPriceOfCar = InitialPriceOfCar;
                theFinalReport = TheFinalReport;
            }

            public void CalculateCostOverTenYearsCar1(string numberOfCars, string cityMPY, string highwayMPY, double[] gasPrices, string makeOfCar, string modelOfCar, string carPrice, string cityMPG, string highwayMPG)
            {
                double total1 = 0.0;

                for (int i = 0; i <= 9; i++)
                {
                    double x = (gasPrices[i] * (Convert.ToInt32(cityMPY) / Convert.ToInt32(cityMPG))) + (gasPrices[i] * (Convert.ToInt32(highwayMPY) / Convert.ToInt32(highwayMPG)));
                    total1 += x;
                }

                double totalCostForCar1 = total1;
                double totalOwnershipCost1 = total1 + Convert.ToDouble(carPrice);

                //report
                carOwnershipReport[0, 0] = makeOfCar;
                carOwnershipReport[0, 1] = modelOfCar;
                carOwnershipReport[0, 2] = cityMPG.ToString();
                carOwnershipReport[0, 3] = highwayMPG.ToString();
                carOwnershipReport[0, 4] = carPrice.ToString();
                carOwnershipReport[0, 5] = total1.ToString();
                carOwnershipReport[0, 6] = totalOwnershipCost1.ToString();


                if (numberOfCars == "1")
                {
                    theFinalReport = carOwnershipReport;
                }
            }

            public void CalculateCostOverTenYearsCar2(string numberOfCars, string cityMPY, string highwayMPY, double[] gasPrices, string makeOfCar, string modelOfCar, string carPrice, string cityMPG, string highwayMPG)
            {
                double total2 = 0.0;

               
                for (int i = 0; i <= 9; i++)
                {
                    double x = (gasPrices[i] * (Convert.ToInt32(cityMPY) / Convert.ToInt32(cityMPG))) + (gasPrices[i] * (Convert.ToInt32(highwayMPY) / Convert.ToInt32(highwayMPG)));
                    total2 += x;
                }

                double totalCostForCar2 = total2;
                double totalOwnershipCost2 = total2 + Convert.ToDouble(carPrice);

                //report
                carOwnershipReport[1, 0] = makeOfCar;
                carOwnershipReport[1, 1] = modelOfCar;
                carOwnershipReport[1, 2] = cityMPG.ToString();
                carOwnershipReport[1, 3] = highwayMPG.ToString();
                carOwnershipReport[1, 4] = carPrice.ToString();
                carOwnershipReport[1, 5] = total2.ToString();
                carOwnershipReport[1, 6] = totalOwnershipCost2.ToString();

                if (numberOfCars == "2")
                {
                    theFinalReport = carOwnershipReport;
                }

            }

            public void CalculateCostOverTenYearsCar3(string numberOfCars, string cityMPY, string highwayMPY, double[] gasPrices, string makeOfCar, string modelOfCar, string carPrice, string cityMPG, string highwayMPG)
            {
                double total3 = 0.0;

            
                for (int i = 0; i <= 9; i++)
                {
                    double x = (gasPrices[i] * (Convert.ToInt32(cityMPY) / Convert.ToInt32(cityMPG))) + (gasPrices[i] * (Convert.ToInt32(highwayMPY) / Convert.ToInt32(highwayMPG)));
                    total3 += x;
                }

                double totalCostForCar3 = total3;
                double totalOwnershipCost3 = total3 + Convert.ToDouble(carPrice);

                //report
                carOwnershipReport[2, 0] = makeOfCar;
                carOwnershipReport[2, 1] = modelOfCar;
                carOwnershipReport[2, 2] = cityMPG.ToString();
                carOwnershipReport[2, 3] = highwayMPG.ToString();
                carOwnershipReport[2, 4] = carPrice.ToString();
                carOwnershipReport[2, 5] = total3.ToString();
                carOwnershipReport[2, 6] = totalOwnershipCost3.ToString();

                if (numberOfCars == "3")
                {
                    theFinalReport = carOwnershipReport;
                }
            }

            public void CalculateCostOverTenYearsCar4(string numberOfCars, string cityMPY, string highwayMPY, double[] gasPrices, string makeOfCar, string modelOfCar, string carPrice, string cityMPG, string highwayMPG)
            {
                double total4 = 0.0;

                for (int i = 0; i <= 9; i++)
                {
                    double x = (gasPrices[i] * (Convert.ToInt32(cityMPY) / Convert.ToInt32(cityMPG))) + (gasPrices[i] * (Convert.ToInt32(highwayMPY) / Convert.ToInt32(highwayMPG)));
                    total4 += x;
                }

                double totalCostForCar4 = total4;
                double totalOwnershipCost4 = total4 + Convert.ToDouble(carPrice);

                //report
                carOwnershipReport[3, 0] = makeOfCar;
                carOwnershipReport[3, 1] = modelOfCar;
                carOwnershipReport[3, 2] = cityMPG.ToString();
                carOwnershipReport[3, 3] = highwayMPG.ToString();
                carOwnershipReport[3, 4] = carPrice.ToString();
                carOwnershipReport[3, 5] = total4.ToString();
                carOwnershipReport[3, 6] = totalOwnershipCost4.ToString();

                if (numberOfCars == "4")
                {
                    theFinalReport = carOwnershipReport;
                }
            }
        }

        # endregion

        private void btnSave_Click(object sender, EventArgs e)
        {
            string[,] fileArray = new string[17, 7];
            int counter = 0;

            // Read the file and display it line by line.
            StreamReader file = new StreamReader("E:\\hello.txt.txt");
            StringBuilder sb = new StringBuilder();

            string line = "";

            while ((line = file.ReadLine()) != null)
            {
                if (line.Length > 0)
                {
                    sb.Append(line);
                    counter++;
                }
            }


            file.Close();

            // Suspend the screen.
            Console.ReadLine();

            formNew previousData = new formNew();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            using (StreamReader streamReader = new StreamReader("E:\\hello.txt"))
            {
                string line = string.Empty;
                string[] tempArray = new string[3];
                int lineCount = 0;

                //clearing out all textboxes
                comboCarMake1.Text = String.Empty;
                txtCarModel1.Text = String.Empty;
                txtInitialPriceCar1.Text = String.Empty;
                txtCityMileageCar1.Text = String.Empty;
                txtHwyMileageCar1.Text = String.Empty;

                comboCarMake2.Text = String.Empty;
                txtCarModel2.Text = String.Empty;
                txtInitialPriceCar2.Text = String.Empty;
                txtCityMileageCar2.Text = String.Empty;
                txtHwyMileageCar2.Text = String.Empty;

                comboCarMake3.Text = String.Empty;
                txtCarModel3.Text = String.Empty;
                txtInitialPriceCar3.Text = String.Empty;
                txtCityMileageCar3.Text = String.Empty;
                txtHwyMileageCar3.Text = String.Empty;

                comboCarMake4.Text = String.Empty;
                txtCarModel4.Text = String.Empty;
                txtInitialPriceCar4.Text = String.Empty;
                txtCityMileageCar4.Text = String.Empty;
                txtHwyMileageCar4.Text = String.Empty;

                while ((line = streamReader.ReadLine()) != null)
                {
                    lineCount++;
                    string[] stringSeparators = new string[] { " | " };
                    tempArray = line.Split(stringSeparators, StringSplitOptions.None);

                    if (lineCount == 1)
                    {
                        comboCarMake1.Text = tempArray[0];
                        txtCarModel1.Text = tempArray[1];
                        txtCityMileageCar1.Text = tempArray[2];
                        txtHwyMileageCar1.Text = tempArray[3];
                        txtInitialPriceCar1.Text  = tempArray[4];
                    }

                    if (lineCount == 2)
                    {
                        comboCarMake2.Text = tempArray[0];
                        txtCarModel2.Text = tempArray[1];
                        txtCityMileageCar2.Text = tempArray[2];
                        txtHwyMileageCar2.Text = tempArray[3];
                        txtInitialPriceCar2.Text = tempArray[4];
                    }

                    if (lineCount == 3)
                    {
                        comboCarMake3.Text = tempArray[0];
                        txtCarModel3.Text = tempArray[1];
                        txtCityMileageCar3.Text = tempArray[2];
                        txtHwyMileageCar3.Text = tempArray[3];
                        txtInitialPriceCar3.Text = tempArray[4];
                    }

                    if (lineCount == 4)
                    {
                        comboCarMake4.Text = tempArray[0];
                        txtCarModel4.Text = tempArray[1];
                        txtCityMileageCar4.Text = tempArray[2];
                        txtHwyMileageCar4.Text = tempArray[3];
                        txtInitialPriceCar4.Text = tempArray[4];
                    }
                    
                }
                
                
                
            }
        }       
    }
}
