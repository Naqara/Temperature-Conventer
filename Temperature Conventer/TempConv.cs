using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace Temperature_Converter
{
    class TempConv : Alerts
    {
        double F, C, K, R, Re, Ro, De, N;       
        protected void FarToCel()
        {
            Console.Write("Give the temperature in degrees Fahrenheit: ");
            F = double.Parse(Console.ReadLine());
            C = 5.0 / 9d * (F - 32);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Your score: " + C + " \u00b0Celsius"); //unicode-16 degrees            
        }
        protected void FarToKel()
        {
            Console.Write("Give the temperature in degrees Fahrenheit: ");
            F = double.Parse(Console.ReadLine());
            K = (F + 459.67) * 5.0 / 9d;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Your score: " + K + " Kelvin");            
        }
        protected void CelToFar()
        {
            Console.Write("Give the temperature in degrees Celsius: ");
            C = double.Parse(Console.ReadLine());
            F = (C * 9d / 5.0) + 32;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Your score: " + F + " \u00b0Fahrenheit");
        }
        protected void CelToKel()
        {
            Console.Write("Give the temperature in degrees Celsius: ");
            C = double.Parse(Console.ReadLine());
            K = C + 273.15;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Your score: " + K + " Kelvin");
        }
        protected void KelToFar()
        {
                Console.Write("Give the temperature in Kelvin: ");
                K = double.Parse(Console.ReadLine());
                F = (K * 1.8) - 459.67;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Your score: " + F + " \u00b0Fahrenheit");  
        }
        protected void KelToCel()
        {
                Console.Write("Give the temperature in Kelvin: ");
                K = double.Parse(Console.ReadLine());
                C = K - 273.15;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Your score: " + C + " \u00b0Celsius");
        }
        protected void CelToRan()
        {
                Console.Write("Give the temperature in degrees Celsius: ");
                C = double.Parse(Console.ReadLine());
                R = (C + 273.15) * 1.8;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Your score: " + R + " \u00b0Rankine");
        }
        protected void CelToRea()
        {
                Console.Write("Give the temperature in degrees Celsius: ");
                C = double.Parse(Console.ReadLine());
                Re = (C * 4) / 5;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Your score: " + Re + " \u00b0Réaumur");
        }
        protected void CelToRom()
        {
                Console.Write("Give the temperature in degrees Celsius: ");
                C = double.Parse(Console.ReadLine());
                Ro = C * 21 / 40 + 7.5;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Your score: " + Ro + " \u00b0Rømer");
        }
        protected void CelToDel()
        {
                Console.Write("Give the temperature in degrees Celsius: ");
                C = double.Parse(Console.ReadLine());
                De = (100 - C) * 3 / 2;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Your score: " + De + " \u00b0Delisle");
        }
        protected void CelToNewt()
        {
                Console.Write("Give the temperature in degrees Celsius: ");
                C = double.Parse(Console.ReadLine());
                N = C * 33 / 100;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Your score: " + N + " \u00b0Newton");
        }
        protected void RanToCel()
        {
                Console.Write("Give the temperature in degrees Rankine: ");
                R = double.Parse(Console.ReadLine());
                C = (R / 1.8) - 273.15;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Your score: " + C + " \u00b0Celsius");
        }
        protected void ReaToCel()
        {
                Console.Write("Give the temperature in degrees Réaumur: ");
                Re = double.Parse(Console.ReadLine());
                C = 1.25 * Re;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Your score: " + C + " \u00b0Celsius");
        }
        protected void RomToCel()
        {
                Console.Write("Give the temperature in degrees Rømer: ");
                Ro = double.Parse(Console.ReadLine());
                C = C = (Ro - 7.5) * 40 / 21;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Your score: " + C + " \u00b0Celsius");
        }
        protected void DelToCel()
        {
                Console.Write("Give the temperature in degrees Delisle: ");
                De = double.Parse(Console.ReadLine());
                C = 100 - De * 2 / 3;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Your score: " + C + " \u00b0Celsius");
        }
        protected void NewtToCel()
        {
                Console.Write("Give the temperature in degrees Newton: ");
                N = double.Parse(Console.ReadLine());
                C = N * 100 / 33;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Your score: " + C + " \u00b0Celsius");
        }
        protected void RanToFar()
        {            
                Console.Write("Give the temperature in degrees Rankie: ");
                R = double.Parse(Console.ReadLine());
                F = R - 459.67;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Your score: " + F + " \u00b0Fahrenheit");
        }
        protected void ReaToFar()
        {
                Console.Write("Give the temperature in degrees Réaumur: ");
                Re = double.Parse(Console.ReadLine());
                F = (Re * 2.25) + 32;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Your score: " + F + " \u00b0Fahrenheit");
        }
        protected void RomToFar()
        {
                Console.Write("Give the temperature in degrees Rømer: ");
                Ro = double.Parse(Console.ReadLine());
                F = (Ro - 7.5) * 24 / 7 + 32;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Your score: " + F + " \u00b0Fahrenheit");
        }
        protected void DelToFar()
        {
                Console.Write("Give the temperature in degrees Delisle: ");
                De = double.Parse(Console.ReadLine());
                F = 121 - De * 6 / 5; 
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Your score: " + F + " \u00b0Fahrenheit");
        }
        protected void NewtToFar()
        {
                Console.Write("Give the temperature in degrees Newton: ");
                N = double.Parse(Console.ReadLine());
                F = N * 60 / 11 + 32;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Your score: " + F + " \u00b0Fahrenheit");
        }
        protected void FarToRan()
        {
                Console.Write("Give the temperature in degrees Fahrenheit: ");
                F = double.Parse(Console.ReadLine());
                R = F + 459.67;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Your score: " + R + " \u00b0Rankine");
        }
        protected void FarToRea()
        {
                Console.Write("Give the temperature in degrees Fahrenheit: ");
                F = double.Parse(Console.ReadLine());
                Re = (F - 32) * 4 / 9;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Your score: " + Re + " \u00b0Réaumur");
        }
        protected void FarToRom()
        {
                Console.Write("Give the temperature in degrees Fahrenheit: ");
                F = double.Parse(Console.ReadLine());
                Ro = (F - 32) * 7 / 24 + 7.5;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Your score: " + Ro + " \u00b0Rømer");                
        }
        protected void FarToDel()
        {
                Console.Write("Give the temperature in degrees Fahrenheit: ");
                F = double.Parse(Console.ReadLine());
                De = (121 - F) * 5 / 6;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Your score: " + De + " \u00b0Delisle");
        }
        protected void FarToNewt()
        {
                Console.Write("Give the temperature in degrees Fahrenheit: ");
                F = double.Parse(Console.ReadLine());
                N = (F - 32) * 11 / 60;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Your score: " + N + " \u00b0Newton");
        }
    }
}
