using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using System.Security.Cryptography.X509Certificates;
using System.Xml;

namespace Temperature_Converter
{
    class Engine : TempConv
    {
        private int oneChoise = 0;
        private string reply { get; set; }
        public void Start()
        {
            while (true)
            {
                Console.Clear();
                Logotyp();
                Menu();
                Mechanics();
            }
        }
        private string Mechanics()
        {
            while (true)
            {
                try
                {
                    if (oneChoise != 0) { goto ContinueCatch; }
                    Console.Write("Your menu choise: ");
                    Console.WriteLine();
                    string reply = Console.ReadLine();
                    this.reply = reply;
                    ContinueCatch:
                    Console.WriteLine();
                    switch (this.reply.ToUpper())
                    {
                        case "1": CelToFar(); goto case "Continue";
                        case "2": CelToKel(); goto case "Continue";
                        case "3": CelToRan(); goto case "Continue";
                        case "4": CelToRea(); goto case "Continue";
                        case "5": CelToRom(); goto case "Continue";
                        case "6": CelToDel(); goto case "Continue";
                        case "7": CelToNewt(); goto case "Continue";
                        case "8": FarToCel(); goto case "Continue";
                        case "9": KelToCel(); goto case "Continue";
                        case "10": RanToCel(); goto case "Continue";
                        case "11": ReaToFar(); goto case "Continue";
                        case "12": RomToCel(); goto case "Continue";
                        case "13": DelToFar(); goto case "Continue";
                        case "14": NewtToCel(); goto case "Continue";
                        case "15": KelToFar(); goto case "Continue";
                        case "16": RanToFar(); goto case "Continue";
                        case "17": ReaToFar(); goto case "Continue";
                        case "18": RomToFar(); goto case "Continue";
                        case "19": DelToFar(); goto case "Continue";
                        case "20": NewtToFar(); goto case "Continue";
                        case "21": FarToKel(); goto case "Continue";
                        case "22": FarToRan(); goto case "Continue";
                        case "23": FarToRea(); goto case "Continue";
                        case "24": FarToRom(); goto case "Continue";
                        case "25": FarToDel(); goto case "Continue";
                        case "26": FarToNewt(); goto case "Continue";
                        case "666": Console.WriteLine("Congratulations you found the Easter Egg"); goto case "Continue";
                        case "EXIT": Environment.Exit(1); break;
                        case "Continue":
                            Console.ResetColor();
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.ForegroundColor = ConsoleColor.Black;
                            oneChoise = 0;
                            WantContinue();
                            break;
                        default: Alert1(); break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine();
                    Alert();
                    oneChoise++;
                }
            }
        }
        private void Menu()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            List<string> menulist = new List<string>();
            menulist.Add("What action do you want to perform? ");
            menulist.Add(" [1] Celsius to Fahrenheit");
            menulist.Add(" [2] Celsius to Kelvin");
            menulist.Add(" [3] Celsius to Rankine");
            menulist.Add(" [4] Celsius to Réaumur");
            menulist.Add(" [5] Celsius to Rømer");
            menulist.Add(" [6] Celsius to Delisle");
            menulist.Add(" [7] Celsius to Newton");
            menulist.Add(" [8] Fahrenheit to Celsius");
            menulist.Add(" [9] Kelvin na Celsius");
            menulist.Add(" [10] Rankine to Celsius");
            menulist.Add(" [11] Réaumur to Celsius");
            menulist.Add(" [12] Rømer to Celsius");
            menulist.Add(" [13] Delisle to Celsius");
            menulist.Add(" [14] Newton to Celsius");
            menulist.Add(" [15] Kelvin to Fahrenheit");
            menulist.Add(" [16] Rankine to Fahrenheit");
            menulist.Add(" [17] Réaumur to Fahrenheit");
            menulist.Add(" [18] Rømer to Fahrenheit");
            menulist.Add(" [19] Delisle to Fahrenheit");
            menulist.Add(" [20] Newton to Fahrenheit");
            menulist.Add(" [21] Fahrenheit to Kelvin");
            menulist.Add(" [22] Fahrenheit to Rankine");
            menulist.Add(" [23] Fahrenheit to Réaumur");
            menulist.Add(" [24] Fahrenheit to Rømer");
            menulist.Add(" [25] Fahrenheit to Delisle");
            menulist.Add(" [26] Fahrenheit to Newton");
            menulist.Add(" [EXIT]Finish Program");
            foreach (string option in menulist) Console.WriteLine(option);
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine();
        }
        private void WantContinue()
        {
            while (true)
            {                
                Console.WriteLine();
                Console.Write("Do you want to continue? [YES] or [EXIT]: ");
                Console.WriteLine();
                string reply = Console.ReadLine();
                if (reply.ToUpper() == "YES") Start();
                else if (reply.ToUpper() == "EXIT") Environment.Exit(1);
            }
        }
    }
}
