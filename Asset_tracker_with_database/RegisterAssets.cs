
namespace Asset_tracker_with_database
{
    internal class RegisterAssets // Handles how the data is registered and stored to database.
    {
        public static void RegisterData(AssetDbContext Context)
        {
            do
            {
                Asset asset = new Asset();

                Console.Write("Please enter the asset type: ");

                asset.Type = Console.ReadLine();

                Console.Write("Please enter the asset brand: ");

                asset.Brand = Console.ReadLine();

                Console.Write("Please enter the asset model: ");

                asset.AssetModel = Console.ReadLine();

                Console.Write("Please provide the location of the office; Sweden, Spain or USA: ");

                string office = InputCheckers.OfficeCheck(Console.ReadLine());

                while (office==""){ // Checking office

                    Console.ForegroundColor= ConsoleColor.Red;

                    Console.WriteLine($"You don't have an office in here. Please try another office: ");
                    
                    Console.ResetColor();

                    office = InputCheckers.OfficeCheck(Console.ReadLine());
                }
                asset.Office = office;

                Console.Write("Use this format (dd/mm/yyyy) to type the purchase date of the asset: ");

                DateTime date;

                while (!DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out date)) // Verify valid date format
                {
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.Write("You have entered an invalid date format. Please try again (dd/mm/yyyy): ");

                    Console.ResetColor();
                }

                asset.PurchaseDate = date;

                Console.Write("Please fill in the dollar price of the asset: ");

                int price;

                while (!int.TryParse(Console.ReadLine(), out price)) // Valid number verification
                {
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Only whole numbers are permitted, so please try again: ");

                    Console.ResetColor();

                }
                asset.USDprice = price;

                Context.Assets.Add(asset);

                Context.SaveChanges();

                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("A new asset have been registered!");

                Console.ForegroundColor = ConsoleColor.Blue;

                Console.Write("Press the 'Q' key when you are finished, or press enter if you want to continue registering assets.");

                Console.ResetColor();
            }
            while (Console.ReadLine().ToUpper() != "Q");

            Interface.Selection();
        }
    }
}