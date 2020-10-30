using System;
using System.Collections.Generic;

namespace Temperature_Converter
{
    class Engine
    {
        private bool exit = true;
        private int alert = 1;
        private string selection { get; set; }
        private double temperature = 0;
        public void Start()
        {
            Logo logo = new Logo();
            logo.Logotyp();
            Menu();
            Mechanics();
        }
        private void Mechanics()
        {
            Functions function = new Functions();
            Alerts alerts = new Alerts();
            while (exit)
            {
                try
                {
                    if (string.IsNullOrEmpty(selection))
                    {
                        Console.Write("Your menu choise: ");
                        Console.WriteLine();
                        selection = Console.ReadLine();
                    }
                    Console.Write("Give the temperature in degrees: ");
                    temperature = double.Parse(Console.ReadLine());
                    Console.WriteLine();
                    switch (selection.ToUpper())
                    {
                        case "1": 
                            function.DisplayResult(function.CelsiusToFahrenheit(temperature)); 
                            alert = 0; break;
                        case "2": 
                            function.DisplayResult(function.CelsiusToKelvin(temperature));
                            alert = 0; break;
                        case "3": 
                            function.DisplayResult(function.CelsiusToRankine(temperature));
                            alert = 0; break;
                        case "4": 
                            function.DisplayResult(function.CelsiusToReaumur(temperature));
                            alert = 0; break;
                        case "5":
                           function.DisplayResult(function.CelciusToRomer(temperature));
                            alert = 0; break;
                        case "6":
                            function.DisplayResult(function.CelciusToDelisle(temperature));
                            alert = 0; break;
                        case "7": 
                            function.DisplayResult(function.CelciusToNewton(temperature));
                            alert = 0; break;
                        case "8": 
                            function.DisplayResult(function.FahrenheitToCelsius(temperature));
                            alert = 0; break;
                        case "9":
                            function.DisplayResult(function.KelvinToCelcius(temperature));
                            alert = 0; break;
                        case "10":
                            function.DisplayResult(function.RankineToCelsius(temperature));
                            alert = 0; break;
                        case "11":
                            function.DisplayResult(function.ReaumurToCelsius(temperature));
                            alert = 0; break;
                        case "12":
                            function.DisplayResult(function.RomerToCelsius(temperature));
                            alert = 0; break;
                        case "13":
                            function.DisplayResult(function.DelisleToCelsius(temperature));
                            alert = 0; break;
                        case "14":
                            function.DisplayResult(function.NewtonToCelsius(temperature));
                            alert = 0; break;
                        case "15":
                            function.DisplayResult(function.KelvinToFahrenheit(temperature));
                            alert = 0; break;
                        case "16":
                            function.DisplayResult(function.RankineToFahrenheit(temperature));
                            alert = 0; break;
                        case "17":
                            function.DisplayResult(function.ReaumurToFahrenheit(temperature));
                            alert = 0; break;
                        case "18":
                            function.DisplayResult(function.RomerToFahrenheit(temperature));
                            alert = 0; break;
                        case "19":
                            function.DisplayResult(function.DelisleToFahrenheit(temperature));
                            alert = 0; break;
                        case "20":
                            function.DisplayResult(function.NewtonToFahrenheit(temperature));
                            alert = 0; break;
                        case "21":
                            function.DisplayResult(function.FahrenheitToKelvin(temperature));
                            alert = 0; break;
                        case "22":
                            function.DisplayResult(function.FahrenheitToRankine(temperature));
                            alert = 0; break;
                        case "23":
                            function.DisplayResult(function.FahrenheitToReaumur(temperature));
                            alert = 0; break;
                        case "24":
                            function.DisplayResult(function.FahrenheitToRomer(temperature));
                            alert = 0; break;
                        case "25":
                            function.DisplayResult(function.FahrenheitToDelisle(temperature));
                            alert = 0; break;
                        case "26":
                            function.DisplayResult(function.FahrenheitToNewton(temperature));
                            alert = 0; break;
                        case "666": Console.WriteLine("Congratulations you found the Easter Egg"); break;
                        case "EXIT": exit = false; /*Environment.Exit(0)*/; break;
                        default: alerts.Alert1(); alert++; selection = null; break;
                    }
                    Console.ResetColor();
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;
                    if (alert == 0) WantContinue();
                }
                catch (FormatException)
                {
                    Console.WriteLine();
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
        private void WantContinue()
        {
            Console.WriteLine();
            Console.Write("Do you want to continue? [YES] or [EXIT]: ");
            Console.WriteLine();
            string response = Console.ReadLine();
            if (response.ToUpper() == "YES") { selection = null; Menu(); } 
            else if (response.ToUpper() == "EXIT") exit = false; //Environment.Exit(0); quick way to close the program
        }
    }
}
