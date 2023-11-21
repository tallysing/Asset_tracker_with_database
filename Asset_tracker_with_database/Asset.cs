﻿
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

        public static void Delete(AssetDbContext Context)
        {
            Console.WriteLine("Please, enter the model name of the asset you want to delete: ");

            string assetModel=Console.ReadLine();

            Asset deletedAsset = Context.Assets.FirstOrDefault(asset => asset.AssetModel == assetModel);

            ViewAssets.TableHeaders();

            ViewAssets.TableRows(deletedAsset);

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("Is this the asset you want to delete? (Y/N) : " );

            string answer = Console.ReadLine();

            switch( answer.ToUpper() )
            {
                case "Y": Context.Assets.Remove(deletedAsset); 
                    Context.SaveChanges();

                    InputCheckers.GoBack(Context);
                    break;

                case "N": InputCheckers.GoBack(Context);
                    break;

                    default: InputCheckers.GoBack(Context);
                    
                    Delete(Context);
                    break;
            }
        }
    }
}
