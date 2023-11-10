
using Asset_tracker_with_database;

AssetDbContext Context = new AssetDbContext();

Console.WriteLine("Testing");

//while (true)
//{
//    Asset asset = new Asset();

//    Console.Write("Please enter the asset type: ");

//    asset.Type = Console.ReadLine();

//    Console.Write("Please enter the asset brand: ");

//    asset.Brand = Console.ReadLine();

//    Console.Write("Please enter the asset model: ");

//    asset.AssetModel = Console.ReadLine();

//    Console.Write("Please provide the location of the office; Sweden, Spain or USA: ");

//    asset.Office = Console.ReadLine();

//    Console.Write("Use this format (dd/mm/yyyy) to type the purchase date of the asset: ");

//    DateTime date;

//    while (!DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out date)) // Verify valid date format
//    {
//        Console.ForegroundColor = ConsoleColor.Red;

//        Console.Write("You have entered an invalid date format. Please try again (dd/mm/yyyy): ");

//        Console.ResetColor();
//    }
//    asset.PurchaseDate= date;

//    Console.Write("Please fill in the dollar price of the asset: ");

//    int price;

//    while (!int.TryParse(Console.ReadLine(), out price)) // Valid number verification
//    {
//        Console.ForegroundColor = ConsoleColor.Red;

//        Console.WriteLine("Only whole numbers are permitted, so please try again: ");

//        Console.ResetColor();

//    }
//    asset.USDprice = price;

//    Context.Asssets.Add(asset);

//    Context.SaveChanges();
//}