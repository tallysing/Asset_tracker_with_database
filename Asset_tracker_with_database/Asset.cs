using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asset_tracker_with_database
{
    internal class Asset
    {
        public Asset(string type, string brand, string assetModel, string office, DateTime purchaseDate, int usdPrice)
        {
            Type = type;
            Brand = brand;
            AssetModel = assetModel;
            Office = office;
            PurchaseDate = purchaseDate;
            USDprice = usdPrice;
        }
        public string Type { get; }
        public string Brand { get; }
        public string AssetModel { get; }
        public string Office { get; }
        public DateTime PurchaseDate { get; }
        public int USDprice { get; }
    }
}
