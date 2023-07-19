/*The marks obtained by a student in 5 different subjects are input through 
the keyboard. The student gets a grade as per the following rules:
a. Percentage above or equals to 60-first grade
b. Percentage between 50 to 59-second grade
c. Percentage between 40 and 49-Third grade
d. Percentage less than 40-poor Grade
Write a program to assign the grade obtained by the student.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class L2P2
    {
        public static void Main()
        {
            Double[] marks = new Double[5];
            Double sum = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter marks of subject " + (i + 1) + " : ");
                marks[i] = Convert.ToDouble(Console.ReadLine());
                sum = sum + marks[i];
            }
            double avg = sum / 5;

            Console.WriteLine("Percentage = {0}", avg);


            if (avg >= 60)
            {
                Console.WriteLine("First Grade");
            }

            else if (avg >= 59 | avg <= 50)
            {
                Console.WriteLine("Second Grade");
            }
            else if (avg >= 49 | avg <= 40)
            {
                Console.WriteLine("Third Grade");
            }
            else
            {
                Console.WriteLine("Poor Grade");
            }
        }

    }
}
