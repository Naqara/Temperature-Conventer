using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Temperature_Conventer
{
    class TempConv : Engine

    {
        Alerts alerts = new Alerts();
        double F, C, K, R, Re, Ro, De, N;
        public void FarToCel()
        {
            Start:
            try
            {

                Console.Write("Give the temperature in degrees Fahrenheit: ");
                F = double.Parse(Console.ReadLine());
                C = 5.0 / 9d * (F - 32);
                Console.WriteLine("Your score: " + C + " \u00b0C"); //unicode-16 degrees }                
                WantContinue();
            }
            catch (FormatException)
            {
                alerts.Alert();
                goto Start;
            }
        }
        public void FarToKel()
        {
            Start:
            try
            {

                Console.Write("Give the temperature in degrees Fahrenheit: ");
                F = double.Parse(Console.ReadLine());
                K = (F + 459.67) * 5.0 / 9d;
                Console.WriteLine("Your score: " + K + " K");
                WantContinue();
            }
            catch (FormatException)
            {
                alerts.Alert();
                goto Start;
            }
        }
        public virtual void CelToFar()
        {
            Start:
            try
            {
                Console.Write("Give the temperature in degrees Celsius: ");
                C = double.Parse(Console.ReadLine());
                F = (C * 9d / 5.0) + 32;
                Console.WriteLine("Your score: " + F + " \u00b0F");
                WantContinue();
            }
            catch (FormatException)
            {
                alerts.Alert();
                goto Start;
            }
        }
        public void CelToKel()

        {
            Start:
            try
            {

                Console.Write("Give the temperature in degrees Celsius: ");
                C = double.Parse(Console.ReadLine());
                K = C + 273.15;
                Console.WriteLine("Your score: " + K + " K");
                WantContinue();
            }
            catch (FormatException)
            {
                alerts.Alert();
                goto Start;
            }
        }
        public void KelToFar()
        {
            Start:
            try
            {

                Console.Write("Give the temperature in Kelvin: ");
                K = double.Parse(Console.ReadLine());
                F = (K * 1.8) - 459.67;
                Console.WriteLine("Your score: " + F + " \u00b0F");
                WantContinue();
            }
            catch (FormatException)
            {
                alerts.Alert();
                goto Start;
            }
        }
        public void KelToCel()
        {
            Start:
            try
            {

                Console.Write("Give the temperature in Kelvin: ");
                K = double.Parse(Console.ReadLine());
                C = K - 273.15;
                Console.WriteLine("Your score: " + C + " \u00b0C");
                WantContinue();
            }
            catch (FormatException)
            {
                alerts.Alert();
                goto Start;
            }
        }
        public void CelToRan()
        {
            Start:
            try
            {

                Console.Write("Give the temperature in degrees Celsius: ");
                C = double.Parse(Console.ReadLine());
                R = (C + 273.15) * 1.8;
                Console.WriteLine("Your score: " + R + " \u00b0R");
                WantContinue();
            }
            catch (FormatException)
            {
                alerts.Alert();
                goto Start;
            }
        }
        public void CelToRea()
        {
            Start:
            try
            {

                Console.Write("Give the temperature in degrees Celsius: ");
                C = double.Parse(Console.ReadLine());
                Re = (C * 4) / 5;
                Console.WriteLine("Your score: " + Re + " \u00b0Ré");
                WantContinue();
            }
            catch (FormatException)
            {
                alerts.Alert();
                goto Start;
            }
        }
        public void CelToRom()
        {
            Start:
            try
            {

                Console.Write("Give the temperature in degrees Celsius: ");
                C = double.Parse(Console.ReadLine());
                Ro = C * 21 / 40 + 7.5;
                Console.WriteLine("Your score: " + Ro + " \u00b0Rø");
                WantContinue();
            }
            catch (FormatException)
            {
                alerts.Alert();
                goto Start;
            }
        }
        public void CelToDel()
        {
            Start:
            try
            {

                Console.Write("Give the temperature in degrees Celsius: ");
                C = double.Parse(Console.ReadLine());
                De = (100 - C) * 3 / 2;
                Console.WriteLine("Your score: " + De + " \u00b0De");
                WantContinue();
            }
            catch (FormatException)
            {
                alerts.Alert();
                goto Start;
            }
        }
        public void CelToNewt()
        {
            Start:
            try
            {

                Console.Write("Give the temperature in degrees Celsius: ");
                C = double.Parse(Console.ReadLine());
                N = C * 33 / 100;
                Console.WriteLine("Your score: " + N + " \u00b0N");
                WantContinue();
            }
            catch (FormatException)
            {
                alerts.Alert();
                goto Start;
            }
        }
        public void RanToCel()
        {
            Start:
            try
            {

                Console.Write("Give the temperature in degrees Rankine: ");
                R = double.Parse(Console.ReadLine());
                C = (R / 1.8) - 273.15;
                Console.WriteLine("Your score: " + C + " \u00b0C");
                WantContinue();
            }
            catch (FormatException)
            {
                alerts.Alert();
                goto Start;
            }
        }
        public void ReaToCel()
        {
            Start:
            try
            {

                Console.Write("Give the temperature in degrees Réaumur: ");
                Re = double.Parse(Console.ReadLine());
                C = 1.25 * Re;
                Console.WriteLine("Your score: " + C + " \u00b0C"); //unicode-16 degrees }
                WantContinue();
            }
            catch (FormatException)
            {
                alerts.Alert();
                goto Start;
            }
        }
        public void RomToCel()
        {
            Start:
            try
            {

                Console.Write("Give the temperature in degrees Rømer: ");
                Ro = double.Parse(Console.ReadLine());
                C = C = (Ro - 7.5) * 40 / 21;
                Console.WriteLine("Your score: " + C + " \u00b0C"); //unicode-16 degrees }
                WantContinue();
            }
            catch (FormatException)
            {
                alerts.Alert();
                goto Start;
            }
        }
        public void DelToCel()
        {
            Start:
            try
            {

                Console.Write("Give the temperature in degrees Delisle: ");
                De = double.Parse(Console.ReadLine());
                C = 100 - De * 2 / 3;
                Console.WriteLine("Your score: " + C + " \u00b0C"); //unicode-16 degrees }
                WantContinue();
            }
            catch (FormatException)
            {
                alerts.Alert();
                goto Start;
            }
        }
        public void NewtToCel()
        {
            Start:
            try
            {

                Console.Write("Give the temperature in degrees Newton: ");
                N = double.Parse(Console.ReadLine());
                C = N * 100 / 33;
                Console.WriteLine("Your score: " + C + " \u00b0C"); //unicode-16 degrees }
                WantContinue();
            }
            catch (FormatException)
            {
                alerts.Alert();
                goto Start;
            }
        }
        public void RanToFar()
        {
            Start:
            try
            {
                Console.Write("Give the temperature in degrees Rankie: ");
                R = double.Parse(Console.ReadLine());
                F = R - 459.67;
                Console.WriteLine("Your score: " + F + " \u00b0F");
                WantContinue();
            }
            catch (FormatException)
            {
                alerts.Alert();
                goto Start;
            }
        }
        public void ReaToFar()
        {
            Start:
            try
            {
                Console.Write("Give the temperature in degrees Réaumur: ");
                Re = double.Parse(Console.ReadLine());
                F = (Re * 2.25) + 32;
                Console.WriteLine("Your score: " + F + " \u00b0F");
                WantContinue();
            }
            catch (FormatException)
            {
                alerts.Alert();
                goto Start;
            }
        }
        public void RomToFar()
        {
            Start:
            try
            {
                Console.Write("Give the temperature in degrees Rømer: ");
                Ro = double.Parse(Console.ReadLine());
                F = (Ro - 7.5) * 24 / 7 + 32;
                Console.WriteLine("Your score: " + F + " \u00b0F");
                WantContinue();
            }
            catch (FormatException)
            {
                alerts.Alert();
                goto Start;
            }
        }
        public void DelToFar()
        {
            Start:
            try
            {
                Console.Write("Give the temperature in degrees Delisle: ");
                De = double.Parse(Console.ReadLine());
                F = 121 - De * 6 / 5;
                Console.WriteLine("Your score: " + F + " \u00b0F");
                WantContinue();
            }
            catch (FormatException)
            {
                alerts.Alert();
                goto Start;
            }
        }
        public void NewtToFar()
        {
            Start:
            try
            {
                Console.Write("Give the temperature in degrees Newton: ");
                N = double.Parse(Console.ReadLine());
                F = N * 60 / 11 + 32;
                Console.WriteLine("Your score: " + F + " \u00b0F");
                WantContinue();
            }
            catch (FormatException)
            {
                alerts.Alert();
                goto Start;
            }
        }
        public void FarToRan()
        {
            Start:
            try
            {

                Console.Write("Give the temperature in degrees Fahrenheit: ");
                F = double.Parse(Console.ReadLine());
                R = F + 459.67;
                Console.WriteLine("Your score: " + R + " \u00b0R"); //unicode-16 degrees }
                WantContinue();
            }
            catch (FormatException)
            {
                alerts.Alert();
                goto Start;
            }
        }
        public void FarToRea()
        {
            Start:
            try
            {

                Console.Write("Give the temperature in degrees Fahrenheit: ");
                F = double.Parse(Console.ReadLine());
                Re = (F - 32) * 4 / 9;
                Console.WriteLine("Your score: " + Re + " \u00b0Ré"); //unicode-16 degrees }
                WantContinue();
            }
            catch (FormatException)
            {
                alerts.Alert();
                goto Start;
            }
        }
        public void FarToRom()
        {
            Start:
            try
            {

                Console.Write("Give the temperature in degrees Fahrenheit: ");
                F = double.Parse(Console.ReadLine());
                Ro = (F - 32) * 7 / 24 + 7.5;
                Console.WriteLine("Your score: " + Ro + " \u00b0R"); //unicode-16 degrees }
                WantContinue();
            }
            catch (FormatException)
            {
                alerts.Alert();
                goto Start;
            }
        }
        public void FarToDel()
        {
            Start:
            try
            {

                Console.Write("Give the temperature in degrees Fahrenheit: ");
                F = double.Parse(Console.ReadLine());
                De = (121 - F) * 5 / 6;
                Console.WriteLine("Your score: " + De + " \u00b0De"); //unicode-16 degrees }
                WantContinue();
            }
            catch (FormatException)
            {
                alerts.Alert();
                goto Start;
            }
        }
        public void FarToNewt()
        {
            Start:
            try
            {

                Console.Write("Give the temperature in degrees Fahrenheit: ");
                F = double.Parse(Console.ReadLine());
                N = (F - 32) * 11 / 60;
                Console.WriteLine("Your score: " + N + " \u00b0N"); //unicode-16 degrees }
                WantContinue();
            }
            catch (FormatException)
            {
                alerts.Alert();
                goto Start;
            }
        }
    }


}
