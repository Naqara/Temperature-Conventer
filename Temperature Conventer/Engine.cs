using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace Temperature_Converter
{
    class Engine
    {
        public static int a = 0, b = 0;
        public string reply { get; set; }
        public void Start()
        {
            while (true)
            {
                Logo logo = new Logo();
                Console.Clear();
                logo.Logotyp();
                Menu();
                Mechanics();
            }
        }
        private void Mechanics()
        {
            TempConv tempConv = new TempConv();
            Alerts alerts = new Alerts();

            while (true)
            {
                try
                {
                    Console.Write("Your menu choise: ");
                    Console.WriteLine();
                    string reply = Console.ReadLine();

                    this.reply = reply;
                    Console.WriteLine();
                    switch (reply.ToUpper())
                    {
                        case "1": tempConv.CelToFar(); goto case "Continue";
                        case "2": tempConv.CelToKel(); goto case "Continue";
                        case "3": tempConv.CelToRan(); goto case "Continue";
                        case "4": tempConv.CelToRea(); goto case "Continue";
                        case "5": tempConv.CelToRom(); goto case "Continue";
                        case "6": tempConv.CelToDel(); goto case "Continue";
                        case "7": tempConv.CelToNewt(); goto case "Continue";
                        case "8": tempConv.FarToCel(); goto case "Continue";
                        case "9": tempConv.KelToCel(); goto case "Continue";
                        case "10": tempConv.RanToCel(); goto case "Continue";
                        case "11": tempConv.ReaToFar(); goto case "Continue";
                        case "12": tempConv.RomToCel(); goto case "Continue";
                        case "13": tempConv.DelToFar(); goto case "Continue";
                        case "14": tempConv.NewtToCel(); goto case "Continue";
                        case "15": tempConv.KelToFar(); goto case "Continue";
                        case "16": tempConv.RanToFar(); goto case "Continue";
                        case "17": tempConv.ReaToFar(); goto case "Continue";
                        case "18": tempConv.RomToFar(); goto case "Continue";
                        case "19": tempConv.DelToFar(); goto case "Continue";
                        case "20": tempConv.NewtToFar(); goto case "Continue";
                        case "21": tempConv.FarToKel(); goto case "Continue";
                        case "22": tempConv.FarToRan(); goto case "Continue";
                        case "23": tempConv.FarToRea(); goto case "Continue";
                        case "24": tempConv.FarToRom(); goto case "Continue";
                        case "25": tempConv.FarToDel(); goto case "Continue";
                        case "26": tempConv.FarToNewt(); goto case "Continue";
                        case "666": Console.WriteLine("Gratulation! U find Easter Egg"); a = 0; goto case "Continue";
                        case "EXIT": Environment.Exit(1); break;
                        case "Continue":
                            Console.ResetColor();
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.ForegroundColor = ConsoleColor.Black;
                            WantContinue();                            
                            break;
                        default: alerts.Alert1(); break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine(reply);
                    alerts.Alert();

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
        protected void WantContinue()
        {
            while (true)
            {

                Console.Write("Do you want to continue? [YES] or [EXIT]: ");
                Console.WriteLine();
                string reply = Console.ReadLine();
                if (reply.ToUpper() == "YES") Start();
                else if (reply.ToUpper() == "EXIT") Environment.Exit(1);
            }
        }

    }
}
