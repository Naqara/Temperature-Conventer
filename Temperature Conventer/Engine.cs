using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Temperature_Conventer
{
    class Engine
    {

        public void Mechanics()
        {
            TempConv tempConv = new TempConv();
            Alerts alerts = new Alerts();
            while (true)
            {
                Console.Write("Your menu choise: ");
                Console.WriteLine();
                string reply = Console.ReadLine();
                Console.WriteLine();
                if (reply == "1")
                {

                    tempConv.CelToFar();
                    break;
                }
                else if (reply == "2")
                {
                    tempConv.CelToKel();
                    break;
                }
                else if (reply == "3")
                {
                    tempConv.CelToRan();
                    break;
                }
                else if (reply == "4")
                {
                    tempConv.CelToRea();
                    break;
                }
                else if (reply == "5")
                {
                    tempConv.CelToRom();
                    break;
                }
                else if (reply == "6")
                {
                    tempConv.CelToDel();
                    break;
                }
                else if (reply == "7")
                {
                    tempConv.CelToNewt();
                    break;
                }
                else if (reply == "8")
                {
                    tempConv.FarToCel();
                    break;
                }
                else if (reply == "9")
                {
                    tempConv.KelToCel();
                    break;
                }
                else if (reply == "10")
                {
                    tempConv.RanToCel();
                    break;
                }
                else if (reply == "11")
                {
                    tempConv.ReaToFar();
                    break;
                }
                else if (reply == "12")
                {
                    tempConv.RomToCel();
                    break;
                }
                else if (reply == "13")
                {
                    tempConv.DelToFar();
                    break;
                }
                else if (reply == "14")
                {
                    tempConv.NewtToCel();
                    break;
                }
                else if (reply == "15")
                {
                    tempConv.KelToFar();
                    break;
                }
                else if (reply == "16")
                {
                    tempConv.RanToFar();
                    break;
                }
                else if (reply == "17")
                {
                    tempConv.ReaToFar();
                    break;
                }
                else if (reply == "18")
                {
                    tempConv.RomToFar();
                    break;
                }
                else if (reply == "19")
                {
                    tempConv.DelToFar();
                    break;
                }
                else if (reply == "20")
                {
                    tempConv.NewtToFar();
                    break;
                }
                else if (reply == "21")
                {
                    tempConv.FarToKel();
                    break;
                }
                else if (reply == "22")
                {
                    tempConv.FarToRan();
                    break;
                }
                else if (reply == "23")
                {
                    tempConv.FarToRea();
                    break;
                }
                else if (reply == "24")
                {
                    tempConv.FarToRom();
                    break;
                }
                else if (reply == "25")
                {
                    tempConv.FarToDel();
                    break;
                }
                else if (reply == "26")
                {
                    tempConv.FarToNewt();
                    break;
                }
                else if (reply.ToUpper() == "EXIT")
                {
                    Environment.Exit(1);
                }
                else alerts.Alert1();
            }
        }
        public void Menulist(List<string> menulist)
        {
            menulist[0] = "What action do you want to perform? ";
            menulist[1] = " [1] Celsius to Fahrenheit";
            menulist[2] = " [2] Celsius to Kelvin";
            menulist[3] = " [3] Celsius to Rankine";
        }
        public void Menu(/*string[] list*/)
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
            foreach (string option in menulist)
            {
                Console.WriteLine(option);
            }            
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
                if (reply.ToUpper() == "YES")
                {
                    break;
                }
                else if (reply.ToUpper() == "EXIT")
                {
                    Environment.Exit(1);
                }
                Console.WriteLine();
            }
        }
    }
}
