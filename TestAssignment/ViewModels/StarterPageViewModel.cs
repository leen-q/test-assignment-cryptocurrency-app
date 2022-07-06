using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net;
using TestAssignment.Models;

namespace TestAssignment.ViewModels
{
    public class StarterPageViewModel : BaseViewModel
    {
        public IList<Currency> CurrencyList { get; set; }
        public StarterPageViewModel()
        {
            string json = new WebClient().DownloadString("https://api.coincap.io/v2/assets?limit=10");
            CurrenciesList list = JsonConvert.DeserializeObject<CurrenciesList>(json);
            CurrencyList = list.data;
        }
    }
}
