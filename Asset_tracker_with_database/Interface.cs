﻿
namespace Asset_tracker_with_database
{
    internal class Interface // Display instructions and read user inputs.
    {
       static AssetDbContext Context = new AssetDbContext(); 
        public static void Selection() // Handles selection options.
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("To register an asset enter \"R\" | To view your assets enter \"V\" | To move assets to another location enter \"M\" | To delete assets' enter \"D\"");

            Console.ResetColor();

            switch (Console.ReadLine().ToUpper())
            {
                case "R": RegisterAssets.RegisterData(Context);
                break;

                case "V": ViewAssets.Table(Context);
                break;

                case "D": Asset.Delete(Context); 
                    break;

                case "M": Asset.Move(Context);
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
