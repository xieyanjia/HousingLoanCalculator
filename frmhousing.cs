using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace housing_web
{
    public partial class frmhousing : Form
    {
        public frmhousing()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!double.TryParse(txtHousePrice.Text, out double housePrice) || housePrice <= 0)
                {
                    ShowError("房屋總價必須是大於 0 的數字。");
                    return;
                }

                if (!double.TryParse(txtDownPaymentPercent.Text, out double downPaymentPercent) || downPaymentPercent < 0 || downPaymentPercent >= 100)
                {
                    ShowError("自備款比例必須是 0 到 100 之間的數字。");
                    return;
                }

                if (!double.TryParse(txtAnnualRate.Text, out double annualRate) || annualRate < 0)
                {
                    ShowError("年利率必須是大於或等於 0 的數字。");
                    return;
                }

                if (!int.TryParse(txtLoanYears.Text, out int loanYears) || loanYears <= 0)
                {
                    ShowError("貸款年限必須是大於 0 的整數。");
                    return;
                }

                if (!int.TryParse(txtGraceYears.Text, out int graceYears) || graceYears < 0)
                {
                    ShowError("寬限期必須是大於或等於 0 的整數。");
                    return;
                }

                if (graceYears > loanYears)
                {
                    ShowError("寬限期不可大於貸款年限。");
                    return;
                }

                double downPaymentAmount = housePrice * downPaymentPercent / 100.0;
                double loanAmount = housePrice - downPaymentAmount;

                if (loanAmount <= 0)
                {
                    ShowError("貸款總金額必須大於 0。");
                    return;
                }

                double monthlyRate = annualRate / 100.0 / 12.0;
                int totalMonths = loanYears * 12;
                int graceMonths = graceYears * 12;
                int repaymentMonths = totalMonths - graceMonths;

                if (repaymentMonths <= 0)
                {
                    ShowError("扣除寬限期後，實際還款月數必須大於 0。");
                    return;
                }

                double monthlyPaymentAfterGrace;

                if (monthlyRate == 0)
                {
                    monthlyPaymentAfterGrace = loanAmount / repaymentMonths;
                }
                else
                {
                    monthlyPaymentAfterGrace =
                        loanAmount * monthlyRate * Math.Pow(1 + monthlyRate, repaymentMonths) /
                        (Math.Pow(1 + monthlyRate, repaymentMonths) - 1);
                }

                double firstInterest = loanAmount * monthlyRate;
                double firstPrincipal;
                double monthlyPaymentDisplay;

                if (graceMonths > 0)
                {
                    firstPrincipal = 0;
                    monthlyPaymentDisplay = firstInterest;
                }
                else
                {
                    firstPrincipal = monthlyPaymentAfterGrace - firstInterest;
                    monthlyPaymentDisplay = monthlyPaymentAfterGrace;
                }

                double totalInterest = 0;
                double remainingPrincipal = loanAmount;

                for (int i = 0; i < graceMonths; i++)
                {
                    double interest = remainingPrincipal * monthlyRate;
                    totalInterest += interest;
                }

                for (int i = 0; i < repaymentMonths; i++)
                {
                    double interest = remainingPrincipal * monthlyRate;
                    double principal;

                    if (monthlyRate == 0)
                    {
                        principal = loanAmount / repaymentMonths;
                    }
                    else
                    {
                        principal = monthlyPaymentAfterGrace - interest;
                    }

                    remainingPrincipal -= principal;
                    totalInterest += interest;
                }

                double totalRepayment = loanAmount + totalInterest;

                lblLoanAmountResult.Text = "貸款總金額：" + FormatMoney(loanAmount) + " 元";
                lblMonthlyPaymentResult.Text = "每月應繳金額：" + FormatMoney(monthlyPaymentDisplay) + " 元";
                lblFirstInterestResult.Text = "首期利息：" + FormatMoney(firstInterest) + " 元";
                lblFirstPrincipalResult.Text = "首期本金：" + FormatMoney(firstPrincipal) + " 元";
                lblTotalInterestResult.Text = "總利息支出：" + FormatMoney(totalInterest) + " 元";
                lblTotalRepaymentResult.Text = "總還款金額：" + FormatMoney(totalRepayment) + " 元";
            }
            catch (Exception ex)
            {
                MessageBox.Show("發生錯誤：" + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHousePrice.Text = "15000000";
            txtDownPaymentPercent.Text = "20";
            txtAnnualRate.Text = "2.15";
            txtLoanYears.Text = "30";
            txtGraceYears.Text = "0";

            lblLoanAmountResult.Text = "貸款總金額：";
            lblMonthlyPaymentResult.Text = "每月應繳金額：";
            lblFirstInterestResult.Text = "首期利息：";
            lblFirstPrincipalResult.Text = "首期本金：";
            lblTotalInterestResult.Text = "總利息支出：";
            lblTotalRepaymentResult.Text = "總還款金額：";
        }
        private void ShowError(string message)
        {
            MessageBox.Show(message, "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private string FormatMoney(double value)
        {
            return value.ToString("N2", CultureInfo.InvariantCulture);
        }
    }
}
