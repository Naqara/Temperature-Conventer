using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Temperature_Converter
{
    class Alerts : Engine
    {
        internal virtual void Alert()
        {
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("This is no number!");
            Console.WriteLine();
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;

        }
        internal virtual void Alert1()
        {
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Try to answer correctly: [1]-[26] action. Finish program: [EXIT]");
            Console.WriteLine();
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
        }
        public virtual void Welcome()
        {
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("[][][][][][][][][][][][][][][][]");
            Console.WriteLine("[]Temperature_Converter ver2.1[]");
            Console.WriteLine("[][][][][][][][][][][][][][][][]");
            Console.WriteLine();
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
        }
    }
}