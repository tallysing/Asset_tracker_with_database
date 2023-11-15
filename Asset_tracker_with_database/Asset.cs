using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asset_tracker_with_database
{
    internal class Asset
    {
        public int Id {  get; set; }
        public string Type { get; set; }
        public string Brand { get; set; }
        public string AssetModel { get; set; }
        public string Office { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int USDprice { get; set; }
    }
}
