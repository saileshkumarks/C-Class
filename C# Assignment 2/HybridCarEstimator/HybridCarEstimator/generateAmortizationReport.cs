using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HybridCarEstimator
{
    public partial class generateAmortizationReport : Form
    {
        public generateAmortizationReport()
        {
            InitializeComponent();
        }

        private void generateAmortizationReport_Load(object sender, EventArgs e)
        {

        }

        public void amortization(double carPrice, double downPayment, double rateOfInterest, double loanDuration)
        {
            //www.coderslexicon.com/amortization-definitive-c-c-java-etc/

            // Make sure we use types that hold decimal places
            double beginning_balance, ending_balance;
            double interest_paid, annual_rate, payment;
            double principle_paid = 0.0;
            double loanAmount = carPrice - downPayment;

            ending_balance = carPrice - downPayment;
            annual_rate = rateOfInterest;

            // Setup a counter to count payments
            int count = 1;

            // Get our standard payment which is 1/20 of loan
            payment = (ending_balance / 20.0);

            while (ending_balance > 0.0)
            //while (principle_paid > loanAmount)
            {
                beginning_balance = ending_balance;

                // Calculate interest by multiplying rate against balance
                interest_paid = beginning_balance * (annual_rate / 12.0);

                // Subtract interest from your payment
                principle_paid = payment - interest_paid;

                // Subtract final payment from running balance
                ending_balance = beginning_balance - principle_paid;

                // If the balance remaining plus its interest is less than payment amount
                // Then print out 0 balance, the interest paid and that balance minus the interest will tell us
                // how much principle you paid to get to zero.

                if ((beginning_balance + interest_paid) < payment)
                {
                    listBoxAmrtizationReport.Items.Add(count + ". Payment: " + (beginning_balance + interest_paid).ToString("C") + " Interest: " + interest_paid.ToString("C") + " Principle: " + (beginning_balance - interest_paid).ToString("C") + " Loan Balance is: $0.00");
                }
                else
                {
                    // Lets show the table, loan, interest, and payment made towards principle
                    listBoxAmrtizationReport.Items.Add(count + ". Payment: " + payment.ToString("C") + " Interest: " + interest_paid.ToString("C") + " Principle: " + principle_paid.ToString("C") + " Loan Balance is: " + ending_balance.ToString("C"));
                }
                count++;
            }

            listBoxAmrtizationReport.Show();
        }

        private void listBoxAmrtizationReport_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
