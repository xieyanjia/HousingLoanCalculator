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

   
    }
}
