using System.Collections.Generic;

namespace TestAssignment.Models
{
    public class CurrenciesList
    {
        public IList<Currency> data { get; set; }
        public long timestamp { get; set; }
    }
}
