/*Write a program to calculate the nPr. (nPr = n! / (n - r)!)*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class L2P7
    {
        static int CalculateFactorial(int n)
        {
            int fact = 1;
            for (int i = 2; i <= n; i++)
            {
                fact = fact * i;
            }
            return fact;
        }
        static int CalculateNpr(int n, int r)
        {
            int npr = 0;
            int fact1 = 0;
            int fact2 = 0;
            fact1 = CalculateFactorial(n);
            fact2 = CalculateFactorial(n - r);
            npr = fact1 / fact2;
            return npr;
        }
        static void Main(string[] args)
        {
            int npr = 0;
            int n = 0;

            int r = 0;
            Console.Write("Enter the value of 'n': ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Enter the value of 'r': ");
            r = int.Parse(Console.ReadLine());
            npr = CalculateNpr(n, r);
            Console.WriteLine("Npr: " + npr);

        }
    }
}
