using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asset_tracker_with_database
{
    internal class ViewAssets
    {
        private static string PadCenter(string text, int width) // Centers the strings
        {
            int totalSpaces = width - text.Length;
            int leftSpaces = totalSpaces / 2;
            int rightSpaces = totalSpaces - leftSpaces;
            return new string(' ', leftSpaces) + text + new string(' ', rightSpaces);
        }
        private Dictionary<string, decimal> CurrencyPrice(Asset asset) // Corresponds the country's currency price
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

        private void TableRows(Asset asset) // Holds the table rows template
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
            Console.WriteLine("| {0} | {1} | {2} | {3} | {4} | {5} | {6} | {7} |", PadCenter(asset.Type, 13), PadCenter(asset.Brand, 13), PadCenter(asset.AssetModel, 13), PadCenter(asset.Office, 13), PadCenter(asset.PurchaseDate, 13), PadCenter(asset.USDprice.ToString(), 13), PadCenter(exchangeCurrency.ElementAt(0).Key, 13), PadCenter(localPrice.ToString(), 17));
        }
        public static void Table(AssetDbContext Context)
        {
            List<Asset> assets = Context.Assets.ToList();

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine(new string('-', 133));

            Console.WriteLine("| {0} | {1} | {2} | {3} | {4} | {5} | {6} | {7} |", PadCenter("Type", 13), PadCenter("Brand", 13), PadCenter("Model", 13), PadCenter("Office", 13), PadCenter("Purchase Date", 13), PadCenter("Price in USD", 13), PadCenter("Currency", 13), "Local price today");

            Console.WriteLine(new string('-', 133));

            Console.ResetColor();
        }
    }
}
