using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace VatCalculator
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void Calculate(object sender, EventArgs e)
        {
            string money = entryMoney.Text;
            double result = double.Parse(money) * 107 / 100;
            labelResult.Text = result.ToString();
        }
    }
}
