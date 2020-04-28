using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Temperature_Converter
{
    class Program
    {   
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Clear();
            Alerts welcome = new Alerts();
            welcome.Welcome();
            Start:           
            Engine engine = new Engine();
            engine.Menu();
            engine.Mechanics();            
            goto Start;
        }
    }
}
//ustawić poliformiz na TempConv        