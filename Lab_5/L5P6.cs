/*Write a program to return the factorial from the method using delegate*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public delegate int MyDel(int num);
    internal class L5P6
    {
        public static void Main()
        {
            int result = 0;
            int number = 0;
            MyDel del = new MyDel(CalculateFactorial);
            Console.Write("Enter the number: ");
            number = Convert.ToInt32(Console.ReadLine());
            result = del(number);
            Console.WriteLine("Factorial of number {0} is: {1}", number, result);
        }
        public static int CalculateFactorial(int num)
        {
            int fact = 1;
            for (int i = num; i >=1 ; i--)
            {
                fact = fact * i;
            }
            return fact;
        }
    }
}
