
using System.Text.RegularExpressions;

namespace Asset_tracker_with_database
{
    internal class InputCheckers
    {
        bool OfficeCheck(string input)
        {

            switch (input)
            {
                case "[Ss]pain": return true;

                case "[Ss]weden": return true;

                case @"\b(U\.?S\.?A\.?)\b": return true;

                    default : return false;
            }
        }
    }
}
