using System;

namespace Temperature_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Clear();
            Engine start = new Engine();
            start.Start();            
        }
    }
}