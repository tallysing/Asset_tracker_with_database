using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asset_tracker_with_database
{
    internal class Interface
    {
       static AssetDbContext Context = new AssetDbContext();
        public static void Selection()
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("To register an asset enter \"R\" | To view your assets enter \"V\" ");

            Console.ResetColor();

            switch (Console.ReadLine().ToUpper())
            {
                case "R": RegisterAssets.RegisterData(Context);
                break;

                case "V": List<Asset> assets = Context.Assets.ToList();
                break;

                default: Console.ForegroundColor= ConsoleColor.Red;

                    Console.WriteLine("Wrong input!");

                    Console.ResetColor();

                    Selection();

                    break;
            }
        }
    }
}
