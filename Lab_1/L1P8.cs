
/*Write a program to create a Simple Calculator for two numbers (Addition, 
Multiplication, Subtraction, Division) [Also using if…else & Switch Case*/


using System;


namespace ConsoleApp1
{
    internal class L1P8
    {
        static void Main()
        {
            int Num1, Num2, result;
            char option;
            Console.Write("Enter the First Number : ");
            Num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Second Number : ");
            Num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Main Menu");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.Write("Enter the Operation you want to perform : ");
            option = Convert.ToChar(Console.ReadLine());
            switch (option)
            {
                case '1':
                    result = Num1 + Num2;
                    Console.WriteLine("The result of Addition is: {0}", result);
                    break;
                case '2':
                    result = Num1 - Num2;
                    Console.WriteLine("The result of Subtraction is: {0}", result);
                    break;
                case '3':
                    result = Num1 * Num2;
                    Console.WriteLine("The result of Multiplication is:{0}", result);
                    break;
                case '4':
                    result = Num1 / Num2;
                    Console.WriteLine("The result of Division is : {0}", result);
                    break;
                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }
        }
    }
}
