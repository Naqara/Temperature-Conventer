using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace Temperature_Converter
{

    class Functions 
    {
        static public string scale;
        public virtual void DisplayResult(object function)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Your score: " + function + scale ); 
        }
        public double FahrenheitToCelsius(double temperature)
        {
            scale = " \u00b0Celsius";//unicode-16 degrees
            return 5.0 / 9d * (temperature - 32);
        }
        public double FahrenheitToKelvin(double temperature)
        {
            scale = " \u00b0Kelvin";
            return (temperature + 459.67) * 5.0 / 9d;
        }
        public double CelsiusToRankine(double temperature)
        {
            scale = " \u00b0Rankine";
            return (temperature + 273.15) * 1.8;
        }
        public double CelsiusToFahrenheit(double temperature)
        {
            scale = " \u00b0Fahrenheit";
            return (temperature * 9d / 5.0) + 32;
        }
        public double CelsiusToKelvin(double temperature)
        {
            scale = " \u00b0Kelvin";
            return temperature + 273.15;
        }
        public double KelvinToFahrenheit(double temperature)
        {
            scale = " \u00b0Fahrenheit";
            return (temperature * 1.8) - 459.67;
        }
        public double KelvinToCelcius(double temperature)
        {
            scale = " \u00b0Celsius";
            return temperature - 273.15;
        }
        public double CelsiusToReaumur(double temperature)
        {
            scale = " \u00b0Réaumur";
            return (temperature * 4) / 5;
        }
        public double CelciusToRomer(double temperature)
        {
            scale = " \u00b0Rømer";
            return temperature * 21 / 40 + 7.5;
        }
        public double CelciusToDelisle(double temperature)
        {
            scale = " \u00b0Delisle";
            return (100 - temperature) * 3 / 2;
        }
        public double CelciusToNewton(double temperature)
        {
            scale = " \u00b0Newton";
            return temperature * 33 / 100;
        }
        public double RankineToCelsius(double temperature)
        {
            return (temperature / 1.8) - 273.15;           
        }
        public double ReaumurToCelsius(double temperature)
        {
            scale = " \u00b0Celsius";
            return 1.25 * temperature;
        }
        public double RomerToCelsius(double temperature)
        {
            scale = " \u00b0Celsius";
            return (temperature - 7.5) * 40 / 21;
        }
        public double DelisleToCelsius(double temperature)
        {
            scale = " \u00b0Celsius";
            return 100 - temperature * 2 / 3;
        }
        public double NewtonToCelsius(double temperature)
        {
            scale = " \u00b0Celsius";
            return temperature * 100 / 33;
        }
        public double RankineToFahrenheit(double temperature)
        {
            scale = " \u00b0Fahrenheit";
            return temperature - 459.67;
        }
        public double ReaumurToFahrenheit(double temperature)
        {
            scale = " \u00b0Fahrenheit";
            return (temperature * 2.25) + 32;
        }
        public double RomerToFahrenheit(double temperature)
        {
            scale = " \u00b0Fahrenheit";
            return (temperature - 7.5) * 24 / 7 + 32;
        }
        public double DelisleToFahrenheit(double temperature)
        {
            scale = " \u00b0Fahrenheit";
            return 121 - temperature * 6 / 5;
        }
        public double NewtonToFahrenheit(double temperature)
        {
            scale = " \u00b0Fahrenheit";
            return temperature * 60 / 11 + 32;
        }
        public double FahrenheitToRankine(double temperature)
        {
            scale = " \u00b0Rankine";
            return temperature + 459.67;
        }
        public double FahrenheitToReaumur(double temperature)
        {
            scale = " \u00b0Réaumur";
            return (temperature - 32) * 4 / 9;
        }
        public double FahrenheitToRomer(double temperature)
        {
            scale = " \u00b0Rømer";
            return (temperature - 32) * 7 / 24 + 7.5;
        }
        public double FahrenheitToDelisle(double temperature)
        {
            scale = " \u00b0Delisle";
            return (121 - temperature) * 5 / 6;
        }
        public double FahrenheitToNewton(double temperature)
        {
            scale = " \u00b0Newton";
            return (temperature - 32) * 11 / 60;
        }
    }
}
