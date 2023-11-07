
using Asset_tracker_with_database;

AssetDbContext Context = new AssetDbContext();

while (true)
{
    Asset asset = new Asset();

    Console.Write("Please enter the asset type: ");

    asset.Type = Console.ReadLine();

    Console.Write("Please enter the asset brand: ");

    asset.Brand = Console.ReadLine();

    Console.Write("Please enter the asset model: ");

    asset.AssetModel = Console.ReadLine();
    

}