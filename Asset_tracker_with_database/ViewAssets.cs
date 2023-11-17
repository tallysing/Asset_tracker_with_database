
namespace Asset_tracker_with_database
{
    internal class ViewAssets // Processes the assets from the database before displaying it in a table.
    {
        private static string PadCenter(string text, int width) // Centers the strings in each column.
        {
            int totalSpaces = width - text.Length;
            int leftSpaces = totalSpaces / 2;
            int rightSpaces = totalSpaces - leftSpaces;
            return new string(' ', leftSpaces) + text + new string(' ', rightSpaces);
        }
        private static Dictionary<string, decimal> CurrencyPrice(Asset asset) //  Converts the assets' values to local currencies.
        {
            switch (asset.Office)
            {
                case "Spain":
                    return new Dictionary<string, decimal>()
            {
                    { "EUR", 0.91m }
                };

                case "Sweden":
                    return new Dictionary<string, decimal>()
            {
                { "SEK", 10.7m }
            };
                default:
                    return new Dictionary<string, decimal>()
            {
                {"USD", 0m }
            };
            }
        }

        private static void TableRows(Asset asset) // Template for table rows.
        {
            var exchangeCurrency = CurrencyPrice(asset);

            decimal localPrice;

            if (exchangeCurrency.ElementAt(0).Key == "USD")
            {
                localPrice = asset.USDprice;
            }
            else
            {
                localPrice = asset.USDprice * exchangeCurrency.ElementAt(0).Value;
            }
            Console.WriteLine("| {0} | {1} | {2} | {3} | {4} | {5} | {6} | {7} |", PadCenter(asset.Type, 13), PadCenter(asset.Brand, 18), PadCenter(asset.AssetModel, 18), PadCenter(asset.Office, 13), PadCenter(asset.PurchaseDate.Date.ToShortDateString(), 13), PadCenter(asset.USDprice.ToString(), 13), PadCenter(exchangeCurrency.ElementAt(0).Key, 13), PadCenter(localPrice.ToString(), 17));
        }
        public static void Table(AssetDbContext Context) // Builds the table.
        {
            List<Asset> assets = Context.Assets.ToList(); // Assets from the database.

            Console.ForegroundColor = ConsoleColor.Green; // Constructs the header columns.

            Console.WriteLine(new string('-', 143));

            Console.WriteLine("| {0} | {1} | {2} | {3} | {4} | {5} | {6} | {7} |", PadCenter("Type", 13), PadCenter("Brand", 18), PadCenter("Model", 18), PadCenter("Office", 13), PadCenter("Purchase Date", 13), PadCenter("Price in USD", 13), PadCenter("Currency", 13), "Local price today");

            Console.WriteLine(new string('-', 143));

            Console.ResetColor();

            var sortedAssets = assets.OrderBy(asset => asset.Type).ThenBy(asset => asset.PurchaseDate);

            foreach (Asset asset in sortedAssets)
            {
                TimeSpan timeSpan = DateTime.Now - asset.PurchaseDate; // Checking assets lifecycle.

                if (timeSpan >= TimeSpan.FromDays(365 * 3 - 90))
                {
                    Console.ForegroundColor = ConsoleColor.Red;

                    TableRows(asset);

                    Console.ResetColor();
                }
                else if (timeSpan >= TimeSpan.FromDays(365 * 3 - 180))
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;

                    TableRows(asset);

                    Console.ResetColor();
                }
                else
                {
                    TableRows(asset);
                }

            }
        }
    }
}
