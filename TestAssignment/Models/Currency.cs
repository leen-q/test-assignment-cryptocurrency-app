namespace TestAssignment.Models
{
    public class Currency
    {
        public string id { get; set; }
        public int? rank { get; set; }
        public string symbol { get; set; }
        public string name { get; set; }
        public decimal? volumeUsd24Hr { get; set; }
        public decimal? priceUsd { get; set; }
        public decimal? changePercent24Hr { get; set; }

    }
}
