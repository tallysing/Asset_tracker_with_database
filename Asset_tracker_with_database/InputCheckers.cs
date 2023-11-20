
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
    }
}
