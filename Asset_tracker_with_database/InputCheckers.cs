
using System.Text.RegularExpressions;

namespace Asset_tracker_with_database
{
    internal class InputCheckers
    {
        public static bool OfficeCheck(string input)
        {

            switch (input)
            {
                case "[Ss]pain": return false;

                case "[Ss]weden": return false;

                case @"\b(U\.?S\.?A\.?)\b": return false;

                    default : return true;
            }
        }
    }
}
