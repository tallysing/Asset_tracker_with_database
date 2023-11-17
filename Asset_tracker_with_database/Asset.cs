
namespace Asset_tracker_with_database
{
    internal class Asset // The blueprint an asset.
    {
        public int Id {  get; set; }
        public string Type { get; set; }
        public string Brand { get; set; }
        public string AssetModel { get; set; }
        public string Office { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int USDprice { get; set; }

        void Delete(AssetDbContext Context)
        {
            Console.WriteLine("Please, enter the model name of the asset you want to delete: ");

            string assetModel=Console.ReadLine();

            
        }
    }
}
