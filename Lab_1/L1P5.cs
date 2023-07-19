/*Write a program to calculate area of Square, Rectangle and Circle.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class L1P5
    {
        public static void Main()
        {
            Console.Write("Enter side of Square:");
            Double sideOfSquare = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter width of Rectangle :");
            Double widthOfRectangle = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter length of Rectangle :");
            Double lengthOfRectangle = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter radius of Circle :");
            Double radiusOfCircle = Convert.ToDouble(Console.ReadLine());
            Double squareArea = sideOfSquare * sideOfSquare;
            Double rectangleArea = widthOfRectangle * lengthOfRectangle;
            Double circleArea = Math.Round(Math.PI * radiusOfCircle *
             radiusOfCircle, 2);
            Console.WriteLine("Area of Square: {0}", squareArea);
            Console.WriteLine("Area of Rectangle: {0}", rectangleArea);
            Console.WriteLine("Area of Circle: {0}", circleArea);
        }

    }
}
