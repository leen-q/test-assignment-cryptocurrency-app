using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net;
using TestAssignment.Models;

namespace TestAssignment.ViewModels
{
    public class DetailPageViewModel : BaseViewModel
    {
        public IList<Currency> CurrencyList { get; set; }
        public IList<Market> MarketList { get; set; }
        public DetailPageViewModel()
        {
            string json = new WebClient().DownloadString("https://api.coincap.io/v2/assets?limit=50");
            CurrenciesList list = JsonConvert.DeserializeObject<CurrenciesList>(json);
            CurrencyList = list.data;
        }

        public void GetMarket(Currency currency)
        {
            string json = new WebClient().DownloadString("https://api.coincap.io/v2/assets/" + currency.id + "/markets?limit=10");
            MarketsList list = JsonConvert.DeserializeObject<MarketsList>(json);
            MarketList = list.data;
        }
    }
}
