using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Converter
{
    class Logo : Engine
    {
        internal protected virtual void Logotyp()
        {
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("[][][][][][][][][][][][][][][][][][]");
            Console.WriteLine("[]Temperature_Converter ver2.2beta[]");
            Console.WriteLine("[][][][][][][][][][][][][][][][][][]");
            Console.WriteLine();
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
        }
    }
}
