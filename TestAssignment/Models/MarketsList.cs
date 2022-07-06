using System.Collections.Generic;

namespace TestAssignment.Models
{
    public class MarketsList
    {
        public IList<Market> data { get; set; }
        public long timestamp { get; set; }
    }
}
