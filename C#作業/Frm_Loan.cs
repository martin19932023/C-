using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_作業
{
    public partial class Frm_Loan : Form
    {
        public Frm_Loan()
        {
            InitializeComponent();
        }

        public static int PMT(double yearlyInterestRate, int totalNumberOfMonths, double loanAmount, double downPayment)
        {
            var rate = (double)yearlyInterestRate / 100 / 12;
            var denominator = Math.Pow((1 + rate), totalNumberOfMonths * 12) - 1;
            double result = (rate + (rate / denominator)) * (loanAmount - downPayment);
            return (int)result;
        }
        private void BTN_PMT_Click(object sender, EventArgs e)
        {
            double loanAmountText = double.Parse(Txt_Amount.Text);
            double rateText = double.Parse(Txt_Percent.Text);
            int periodText = int.Parse(Txt_Due.Text);
            double downpaymentText = double.Parse(Txt_FirstPay.Text);
            MessageBox.Show("PMT=" + PMT(rateText, periodText, loanAmountText, downpaymentText));
        }

        private void BTN_Total_Click(object sender, EventArgs e)
        {
            double loanAmountText = double.Parse(Txt_Amount.Text);
            double rateText = double.Parse(Txt_Percent.Text);
            int periodText = int.Parse(Txt_Due.Text);
            double downpaymentText = double.Parse(Txt_FirstPay.Text);
            double totalAmount = PMT(rateText, periodText, loanAmountText, downpaymentText) * periodText * 12;
            MessageBox.Show("總金額=" + totalAmount);
        }

        private void BTN_Report_Click(object sender, EventArgs e)
        {
            double loanAmountText = double.Parse(Txt_Amount.Text);
            double rateText = double.Parse(Txt_Percent.Text);
            int periodText = int.Parse(Txt_Due.Text);
            double downpaymentText = double.Parse(Txt_FirstPay.Text);
            int pmtResult = PMT(rateText, periodText, loanAmountText, downpaymentText);
            int totalAmout = PMT(rateText, periodText, loanAmountText, downpaymentText) * periodText * 12;


            Frm_Loan2 LL= new Frm_Loan2();
            LL.Txt_Amount2.Text = Txt_Amount.Text;
            LL.Txt_Due2.Text = Txt_Due.Text;
            LL.Txt_Percent2.Text = Txt_Percent.Text;
            LL.Txt_M.Text = pmtResult.ToString();
            //LL.Txt_T = totalAmout.ToString();
            LL.Show();
        }
    }
}
