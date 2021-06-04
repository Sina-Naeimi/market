using System;
using System.Collections.Generic;
using System.Text;

namespace market.Context.Models
{
    public class Products
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public int Stock { get; set; }
        public string PurchaseCount { get; set; }
        public string Group { get; set; }
        public string SubGroup { get; set; }
        public string Date { get; set; }
        public  string QualityStatus { get; set; }
        public string PriceStatus { get; set; }
        public string PurchaseStatus { get; set; }
    }
}
