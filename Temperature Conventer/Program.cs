using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Temperature_Conventer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Clear();
            Start:
            Engine engine = new Engine();
            engine.Menu();
            engine.Mechanics();            
            goto Start;
        }
    }
}