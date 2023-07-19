/*Write a program to calculate the size of the area in square-feet based on 
Specified length and width.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class L1P4
    {
        public static void Main()
        {
            Double lengthInFeets = 0, widthInFeets = 0, plotArea = 0;
            Console.Write("Enter length in feets: ");
            lengthInFeets = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter width in feet:");
            widthInFeets = Convert.ToInt32(Console.ReadLine());
            plotArea = lengthInFeets * widthInFeets;
            Console.WriteLine("Area is " + plotArea + " square feet");
        }
    }
}
