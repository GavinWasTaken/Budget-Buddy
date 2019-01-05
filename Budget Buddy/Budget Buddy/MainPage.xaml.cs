using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Budget_Buddy.Model;
namespace Budget_Buddy
{
	public partial class MainPage : ContentPage
	{
        
		public MainPage()
		{
            
            InitializeComponent();
		}


        public void PopUp(object sender, EventArgs args)
        {
            FirstPopUp.IsVisible = true;
            
        }

        public List<double> getPercents(double input)
        {
            var fiftyPercent = input / 100 * 50;
            var thirtyPercent = input / 100 * 30;
            var twentyPercent = input / 100 * 20;
            List<double> percents = new List<double>() {fiftyPercent, thirtyPercent, twentyPercent };
            return percents;
        }


        public void budgetButton(object sender, EventArgs args)
        {
            CreateBasicBudget(inputAmount);
            SecondPopUp.IsVisible = true;
        }
        public List<_503020Budget> CreateBasicBudget(Entry entry)
        {
            decimal input = Decimal.Parse(entry.Text);
            //double input= Double.Parse(inputAmount.Text);

            var fiftyPercent = Math.Round(input / 100 * 50, 2);
            var thirtyPercent = Math.Round(input / 100 * 30, 2);
            var twentyPercent = Math.Round(input / 100 * 20, 2);

            
            List<_503020Budget> basicBudget = new List<_503020Budget>();
            
            basicBudget.Add(new _503020Budget {Needs = fiftyPercent, Wants = thirtyPercent, Savings = twentyPercent });
            BudgetList.ItemsSource = basicBudget;
            return basicBudget;
            
        }

	}
}
