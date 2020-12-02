using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Converter
{
    class Logo
    {
        public void Logotyp()
        {
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            string[] logo =
            {
@" ___                                          __                                     __     ___ ",
@"|_ _| _   _ _  _  _  _  _  ||     _  _       / _| _   _     _  _ ||  _  _      _  _ [o )   |_ /||  _ ||  _",
@" | | /o\|/ \ \/o\/o\/_|/o\ | ]|U|/_|/o\     ( (_ /o\|/ \\V7/o\/_|| ]/o\/_| \V7/o\/_| /(    __)\|o\/o\| ]/o\ ",
@" |_| \( L_n_n||_/\( L| \_,]L| \_/L| \(  ___  \__|\_/L_n| V \( L| L| \( L|   V \( L| /__|() \__/|_/\( L| \_,]",
@"              L|"
            };
            foreach (string row in logo)
            {
                Console.WriteLine(row);
            }
            Console.WriteLine();
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
        }
    }
}
