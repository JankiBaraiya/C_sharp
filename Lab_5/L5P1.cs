/*Write a program using method overloading by changing datatype of 
arguments to perform addition of two integer numbers and two float 
numbers.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class L5p1
    {
        public static void Main(String[] args)
        {
            Console.Write("Enter 1st Integer number : ");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 2nd Integer number : ");
            int a2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 1st Double number : ");
            double b1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter 2nd Double number : ");
            double b2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Addition of Integers = " + Addition(a1, a2));
            Console.WriteLine("Addition of Doubles = " + Addition(b1, b2));
        }
        public static int Addition(int a, int b)
        {
            return a + b;
        }
        public static double Addition(double a, double b)
        {
            return a + b;
        }
    }
}
