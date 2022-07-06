using System.Windows.Controls;
using TestAssignment.Models;
using TestAssignment.ViewModels;

namespace TestAssignment.Views
{
    /// <summary>
    /// Логика взаимодействия для DetailPageView.xaml
    /// </summary>
    public partial class DetailPageView : UserControl
    {
        DetailPageViewModel viewModel;
        public DetailPageView()
        {
            InitializeComponent();
            viewModel = new DetailPageViewModel();
            DataContext = viewModel;
            CurrencyView.Items.Filter = CurrencyFinder;
        }

        private void CurrencyView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Currency selectedCurrency = (Currency)CurrencyView.SelectedItem;
            if(selectedCurrency != null)
            {
                viewModel.GetMarket(selectedCurrency);
                MarketView.ItemsSource = viewModel.MarketList;
            }
        }

        private bool CurrencyFinder(object obj)
        {
            var findCurrency = obj as Currency;

            return findCurrency.name.ToLower().Contains(FindCurrency.Text.ToLower());
        }

        private void FindCurrency_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (FindCurrency.Text == null)
            {
                CurrencyView.Items.Filter = null;
            }
            else
            {
                CurrencyView.Items.Filter = CurrencyFinder;
            }
        }
    }
}
