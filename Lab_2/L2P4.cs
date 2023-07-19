/* Write a program to find out whether a given year is a leap year or not.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class L2P4
    {
        public static void Main()
        {
            int year;
            Console.Write("Input an year : ");
            year = Convert.ToInt32(Console.ReadLine());
            if ((year % 400) == 0)
                Console.WriteLine("{0} is a leap year.\n", year);
            else if ((year % 100) == 0)
                Console.WriteLine("{0} is not a leap year.\n", year);
            else if ((year % 4) == 0)
                Console.WriteLine("{0} is a leap year.\n", year);
            else
                Console.WriteLine("{0} is not a leap year.\n", year);
        }

    }
}
