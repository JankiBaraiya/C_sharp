/*Create an ArrayList for StudentName and perform following operations:
a. Add() - To Add new student in list
b. Remove() - To Remove Student with specified index
c. RemoveRange() - To Remove student with specified range.
d. Clear() - To clear all the student from the list*/

using System;
using System.Collections;

namespace ConsoleApp1
{
    class L6P1
    {
        public static void Main(string[] args)
        {
            Program p = new Program();
            p.ArrListMethod();
        }
    }
    class Program
    {
        ArrayList a1 = new ArrayList();
        public void DisplayElements()
        {
            if (a1.Count > 0)
            {
                foreach (object i in a1)
                {
                    Console.Write("\t" + i.ToString());
                }
            }
            else
                Console.WriteLine("No Element Found !!");
        }
        public void ArrListMethod()
        {
            int Flag = 0;
            while (Flag == 0)
            {
                Console.WriteLine("\nSelect Operation to Perform on Array List");
                Console.WriteLine("1.Add");
                Console.WriteLine("2.Remove");
                Console.WriteLine("3.Remove Range");
                Console.WriteLine("4.Clear");
                Console.WriteLine("5.Exit");
                int ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.Write("Enter Element : ");
                        int n = Convert.ToInt32(Console.ReadLine());
                        a1.Add(n); DisplayElements();
                        break;
                    case 2:
                        Console.Write("Enter Element : ");
                        int no = Convert.ToInt32(Console.ReadLine());
                        if (a1.Count > 0)
                            a1.Remove(no);
                        DisplayElements();
                        break;
                    case 3:
                        Console.Write("Enter Index : ");
                        int n1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Count of Elements: ");
                        int n2 = Convert.ToInt32(Console.ReadLine());
                        if (a1.Count > 0)
                            a1.RemoveRange(n1, n2);
                        DisplayElements();
                        break;
                    case 4:
                        a1.Clear();
                        DisplayElements();
                        break;
                    case 5:
                        Flag = 1;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
