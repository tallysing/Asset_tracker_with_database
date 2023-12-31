﻿
using System.Text.RegularExpressions;

namespace Asset_tracker_with_database
{
    internal class InputCheckers
    {
        public static string OfficeCheck(string office) // Verifying valid offices.
        {
            
            switch (office)
            {
                case "": return "";
                case "Spain":
                case "spain":
                    return "Spain";

                case "Sweden":
                case "sweden":
                    return "Sweden";

                case "USA":
                case "usa":
                case "US":
                case "us":
                    return "USA";

                    default : return "";
            }
        }

        public static void GoBack(AssetDbContext Context)
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("Please enter Q if you want to go back or just enter if you want to continue.");

            Console.ResetColor();

            switch (Console.ReadLine().ToUpper())
            {
                case "Q": Interface.Selection(); 
                    break;

                case "": Asset.Delete(Context);
                    break;

                    default: Console.ForegroundColor= ConsoleColor.Red;
                    
                    Console.WriteLine("Wrong input, pleas try again!");

                    Console.ResetColor();

                    GoBack(Context);
                    break;
            }
        }

    }
}
