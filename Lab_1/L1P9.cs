/*Write a program to find maximum numbers from given 3 numbers.*/

using System;


namespace ConsoleApp1
{
    internal class L1P9
    {
        static void Main()
        {
            Int32 max = 0;
            Console.Write("Enter No 1: ");
            Int32 no1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter No 2: ");
            Int32 no2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter No 3: ");
            Int32 no3 = Convert.ToInt32(Console.ReadLine());
            max = no1 > no2 ? (no1 > no3 ? no1 : no3) : (no2 > no3 ? no2 : no3);
            Console.WriteLine("Max is: {0}", max);
        }

    }
}
