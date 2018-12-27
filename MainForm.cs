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

namespace LoanCalculator
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            // Center form on startup
            StartPosition = FormStartPosition.CenterScreen;
        }


        private void ExportToExcel()
        {
            if (lstPaymentSchedule.Items.Count==0)
            {
                MessageBox.Show("Please Calculate Payments before running Export process.");
                return;
            }
            String exportExcelFileName = "c:\\temp\\loanschedule.xls";
            try
            {
                //lstPaymentSchedule is nothing but the listview control name
                string[] st = new string[lstPaymentSchedule.Columns.Count];
                DirectoryInfo di = new DirectoryInfo(@"c:\temp\");
                if (di.Exists == false)
                    di.Create();
                StreamWriter sw = new StreamWriter(@exportExcelFileName, false);
                sw.AutoFlush = true;
                sw.Write(txtPaymentSummary.Text);
                sw.Write("\r\r");
                for (int col = 0; col < lstPaymentSchedule.Columns.Count; col++)
                {
                    sw.Write("\t" + lstPaymentSchedule.Columns[col].Text.ToString());
                }

                int rowIndex = 1;
                int row = 0;
                string st1 = "";
                for (row = 0; row < lstPaymentSchedule.Items.Count; row++)
                {
                    if (rowIndex <= lstPaymentSchedule.Items.Count)
                        rowIndex++;
                    st1 = "\n";
                    for (int col = 0; col < lstPaymentSchedule.Columns.Count; col++)
                    {
                        //st1 = st1 + "\t" + "'" + lstPaymentSchedule.Items[row].SubItems[col].Text.ToString();
                        st1 = st1 + "\t" + "" + lstPaymentSchedule.Items[row].SubItems[col].Text.ToString();
                    }
                    sw.WriteLine(st1);
                }
                sw.Close();
                FileInfo fil = new FileInfo(@exportExcelFileName);
                if (fil.Exists == true)
                    MessageBox.Show("Export Process Completed ("+ exportExcelFileName+")", "Export to Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
               MessageBox.Show("Error encountered during Export process.");
            }
        }

        // Method: CalculateLoanSchedule
        // Calculates the Loan Amortization Schedule using the formulas provided in the Equal Total Payments section and output results to screen

        private void CalculateLoanSchedule()
        {
            // Declare variables
            decimal loanAmount = 0;
            decimal annualInterestRate = 0;
            int loanPeriod = 0;
            decimal paymentAmount = 0;
            decimal principalAmountPaid = 0;
            decimal interestAmountPaid = 0;
            decimal outstandingBalance = 0;
            decimal interestRate = 0;
            decimal totalAmountRepaid = 0;
            decimal totalInterest = 0;

            int periodMultiplier = 0;
            double divPaymentAmount;

            bool blnIsValidData;


            // Perform validation on all of the various input fields required to ensure that they are entered and that they are numeric values

            // Validate Loan Amount
            if (txtLoanAmount.Text == "")
            {
                MessageBox.Show("Loan Amount is REQUIRED", "ERROR");
                return;
            }


            blnIsValidData = decimal.TryParse(txtLoanAmount.Text, out loanAmount);
            if (!blnIsValidData)
            {
                MessageBox.Show("Loan Amount is INVALID", "ERROR");
                return;
            }


            // Validate Annual Interest Rate
            if (txtAnnualInterestRate.Text == "")
            {
                MessageBox.Show("Annual Interest Rate is REQUIRED", "ERROR");
                return;
            }
            blnIsValidData = decimal.TryParse(txtAnnualInterestRate.Text, out annualInterestRate);
            if (!blnIsValidData)
            {
                MessageBox.Show("Interest Rate is INVALID", "ERROR");
                return;
            }
            if (annualInterestRate <= 0)
            {
                MessageBox.Show("Interest Rate is INVALID", "ERROR");
                return;

            }

            // Validate Loan Period
            if (txtLoanPeriod.Text == "")
            {
                MessageBox.Show("Loan Period is REQUIRED", "ERROR");
                return;
            }
            blnIsValidData = int.TryParse(txtLoanPeriod.Text, out loanPeriod);
            if (!blnIsValidData)
            {
                MessageBox.Show("Loan Period is INVALID", "ERROR");
                return;

            }

            // Calculate period multiplier, i.e. for years it will be specified period in years * 12, if in months it will be 1
            if (rdoPeriodMonth.Checked)
            {
                periodMultiplier = 1;
            }
            if (rdoPeriodYears.Checked)
            {
                periodMultiplier = 12;
            }


            // Calculate interest rate which is derived by using the pure number entered ie. 8 for 8% and dividing by 100 and then by 12 to get a monthly interest rate
            interestRate = (annualInterestRate / 100) / 12;

            paymentAmount = (interestRate * loanAmount);
            divPaymentAmount = 1 - (Math.Pow(1 + (Convert.ToDouble(interestRate)), -(Convert.ToDouble(periodMultiplier * loanPeriod))));

            paymentAmount = paymentAmount / Convert.ToDecimal(divPaymentAmount);
            paymentAmount = Math.Round(paymentAmount, 2);


            // Calculate the total amount repaid at the end of the loan including the interest, start with the initial amount
            totalAmountRepaid = loanAmount;

            lstPaymentSchedule.Items.Clear();

            // Build Loan Amortization Schedule table with the various field calculations and add a new line entry to the ListView Control for each period
            for (int i = 1; i <= (loanPeriod * periodMultiplier); i++)
            {

                principalAmountPaid = paymentAmount * (decimal)(Math.Pow(1 + (Convert.ToDouble(interestRate)), -(Convert.ToDouble(1 + (periodMultiplier * loanPeriod) - i))));

                interestAmountPaid = paymentAmount - principalAmountPaid;

                // Calculate the total amount repaid at the end of the loan including the interest, keep adding the interest
                totalAmountRepaid = totalAmountRepaid + interestAmountPaid;

                //outstandingBalance = Math.Round((interestAmountPaid / ((annualInterestRate / 100) / 12)) - principalAmountPaid, 2);
                outstandingBalance = Math.Round((interestAmountPaid / interestRate) - principalAmountPaid, 2);

                ListViewItem lvi = new ListViewItem(i.ToString());

                // Payment Amount 
                lvi.SubItems.Add(paymentAmount.ToString("N"));  // Format to 2 decimal places with thousands seperated by ,

                //Principal Amount Paid
                lvi.SubItems.Add(principalAmountPaid.ToString("N")); // Format to 2 decimal places with thousands seperated by ,

                //Interest Amount Paid
                lvi.SubItems.Add(interestAmountPaid.ToString("N")); // Format to 2 decimal places with thousands seperated by ,

                //Loan Outstanding Balance
                lvi.SubItems.Add(outstandingBalance.ToString("N")); // Format to 2 decimal places with thousands seperated by ,

                // Add new row to grid with all fields from all of the above columns
                lstPaymentSchedule.Items.Add(lvi);
            }

            // Calculate total interest
            totalInterest = totalAmountRepaid - loanAmount;

            // Update the payment summary information showing monthly payments for the loan, the total number of periods, interest rate, total payment amount including interest etc

            txtPaymentSummary.Text = "The monthly payments will be " + paymentAmount.ToString("N") + " for loan amount " + Convert.ToDecimal(txtLoanAmount.Text).ToString("N") + " at " + txtAnnualInterestRate.Text + "% for " + txtLoanPeriod.Text;
            if (rdoPeriodMonth.Checked)
            {
                txtPaymentSummary.Text += " months.";
            }
            if (rdoPeriodYears.Checked)
            {
                txtPaymentSummary.Text += " years.";
            }

            txtPaymentSummary.Text += "\r\nThe total number of periods are " + (loanPeriod * periodMultiplier).ToString() + " and the total amount repaid will be " + totalAmountRepaid.ToString("N") + ".";
            txtPaymentSummary.Text += "\r\nThe total interest paid over the loan period is " + totalInterest.ToString("N");

        }


        // Method: ResetForm
        // Clear all information entered on screen so that a new loan can be entered
        private void ResetForm()
        {
            // Reset all input fields to blank
            txtLoanAmount.Text = "";
            txtAnnualInterestRate.Text = "";
            txtLoanPeriod.Text = "";
            txtPaymentSummary.Text = "";
            rdoPeriodMonth.Checked = false;
            rdoPeriodYears.Checked = true;

            lstPaymentSchedule.Items.Clear();

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            CalculateLoanSchedule();

        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            ExportToExcel();
        }
    }
}
