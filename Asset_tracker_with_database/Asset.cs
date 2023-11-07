using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asset_tracker_with_database
{
    internal class Asset
    {
        //public Asset(string type, string brand, string assetModel, string office, DateTime purchaseDate, int usdPrice)
        //{
        //    Type = type;
        //    Brand = brand;
        //    AssetModel = assetModel;
        //    Office = office;
        //    PurchaseDate = purchaseDate;
        //    USDprice = usdPrice;
        //}
        public int Id {  get; set; }
        public string Type { get; set; }
        public string Brand { get; set; }
        public string AssetModel { get; set; }
        public string Office { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int USDprice { get; set; }
    }
}
