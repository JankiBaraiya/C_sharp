/*Write a program to check prime number*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class L2P3
    {
        public static void Main()
        {
            int n, i = 0, flag = 0;
            Console.Write("Enter the Number to check Prime: ");

            n = Convert.ToInt32(Console.ReadLine());

            for (i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    Console.Write("Number is not Prime.");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
                Console.Write("Number is Prime.");
        }
    }
}
