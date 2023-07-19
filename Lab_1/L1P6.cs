/*Write a program to calculate Celsius to Fahrenheit and vice-versa using 
function*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class L1P6
    {
        static double convertToCelsius(double ferTemp)
        {
            double cTemp = Math.Round((ferTemp - 32) * 5 / 9, 2);
            return cTemp;
        }
        static double convertToFahrenheit(double celTemp)
        {
            double fTemp = Math.Round((9 * celTemp) / 5 + 32, 2);
            return fTemp;
        }
        static void Main(string[] args)
        {
            double celTemp = 0, ferTemp = 0;
            Console.WriteLine("Enter 1 for Fahrenheit to Celcius: ");
            Console.WriteLine("Enter 2 for Celcius to Fahrenheit: ");
            Console.Write("Enter choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.Write("Enter the value of temperature in  Fahrenheite(°F): ");
                    ferTemp = Convert.ToInt32(Console.ReadLine());
                    celTemp = convertToCelsius(ferTemp);
                    Console.WriteLine("Celsius temperature is(°C) : " + celTemp);
                    break;
                case 2:
                    Console.Write("Enter the value of temperature in Celsius(°C): ");
                    celTemp = Convert.ToInt32(Console.ReadLine());
                    ferTemp = convertToFahrenheit(celTemp);
                    Console.WriteLine("Fahrenheite temperature is(°F) : "
                    + ferTemp);
                    break;
                default:
                    Console.Write("Invalid Choice ...");
                    break;
            }
        }
    }
}
