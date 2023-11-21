
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

        public static void Delete(AssetDbContext Context) // Deletes assets
        {
            Console.Write("Please, enter the model name of the asset you want to delete: ");

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

        public static void Move(AssetDbContext Context) // Move assets to another office location
        {
            do
            {
                Console.Write("Please, enter the model name of the asset you want to move: ");

                string assetModel = Console.ReadLine();

                Asset movedAsset = Context.Assets.FirstOrDefault(asset => asset.AssetModel == assetModel);

                ViewAssets.TableHeaders();

                ViewAssets.TableRows(movedAsset);

                Console.ForegroundColor = ConsoleColor.DarkYellow;

                Console.Write("Please enter the office location you want to move to; Sweden, Spain or USA : ");

                Console.ResetColor();

                string answer = InputCheckers.OfficeCheck(Console.ReadLine());

                while (answer == "")
                {
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.Write($"You don't have an office on this place. Please try another office location: ");

                    Console.ResetColor();

                    answer = InputCheckers.OfficeCheck(Console.ReadLine());
                }
                movedAsset.Office = answer;

                Context.Assets.Update(movedAsset);

                Context.SaveChanges();

                Console.ForegroundColor = ConsoleColor.Blue;

                Console.WriteLine("Please enter Q if you want to go back or just enter if you want to continue.");

                Console.ResetColor();

            } while (Console.ReadLine() == "");

            Interface.Selection();
        }
    }
}
