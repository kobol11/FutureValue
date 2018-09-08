using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FutureValue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private decimal CalculateFutureValue(decimal monthlyInvestment, decimal monthlyInterestRate, int months)
        {
            decimal futureValue = 0m;

            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + monthlyInvestment) * (1 + monthlyInterestRate);
            }

            return futureValue;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            decimal monthlyInvestment = Convert.ToDecimal(txb_MonthlyInvestment.Text);
            decimal yearlyInterestRate = Convert.ToDecimal(txb_YearlyInterestRate.Text);
            int years = Convert.ToInt32(txb_NoOfYears.Text);

            int months = 12 * years;
            decimal monthlyInterestRate = (yearlyInterestRate / 12) / 100;

            decimal futureValue = CalculateFutureValue(monthlyInvestment, monthlyInterestRate, months);

            txb_FutureValue.Text = futureValue.ToString("c");

            txb_MonthlyInvestment.Focus();
        }
    }
}
