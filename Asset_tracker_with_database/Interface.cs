using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asset_tracker_with_database
{
    internal class Interface
    {
        public static void Selection()
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("To register a computer enter \"C\" | To register a phone enter \"P\" | To view your assets enter \"A\" | To quit enter \"Q\" ");

            Console.ResetColor();

            switch (Console.ReadLine().ToUpper())
            {
                case "C": Console.WriteLine("PC");
                break;

                case "P": Console.WriteLine("Phone");
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
