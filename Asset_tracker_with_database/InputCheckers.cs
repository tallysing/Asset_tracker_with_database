
using System.Text.RegularExpressions;

namespace Asset_tracker_with_database
{
    internal class InputCheckers
    {
        public static bool OfficeCheck(string input) // Verifying valid offices.
        {
            
            switch (input)
            {
                case "": return true;
                case "Spain":
                case "spain":
                    return false;

                case "Sweden":
                case "sweden":
                    return false;

                case "USA":
                case "usa":
                case "US":
                case "us":
                    return false;

                    default : return true;
            }
        }
    }
}
