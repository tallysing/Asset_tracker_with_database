
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

        public static void GoBack()
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("Please enter Q if you want to go back or just enter if you want delete another asset.");

            Console.ResetColor();

            switch (Console.ReadLine())
            {
                case "Q": Interface.Selection(); 
                    break;

                case "": Asset.Delete(Context);
                    break;

                    default: Console.WriteLine("Wrong input, pleas try again!");
                    break;
            }
        }
    }
}
