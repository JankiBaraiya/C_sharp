

/*Body Mass Index (BMI) is a measure of health on weight. It can be 
calculated by taking your weight in kilograms and dividing by the square of 
your height in meters. Write a program that prompts the user to enter a 
weight in pounds and height in inches and displays the BMI. 
(Note: -1 pound = 0.45359237 Kg and 1 inch = 0.0254 meters)*/




using System;
namespace BMICalculator
{
    public class L2P1
    {
        public static void Main(string[] args)
        {
            double _inchToMeter = 0.0254, _poundToKg = 0.45359237;
            Console.Write("Enter Height (in inch) : ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Weight (in pound) : ");
            double weight = Convert.ToDouble(Console.ReadLine());
            double weightInKg = Math.Round(_poundToKg * weight, 2);
            double heightInMeter = Math.Round(_inchToMeter * height, 2);
            double BMI = Math.Round(weightInKg /
            (heightInMeter * heightInMeter), 2);
            Console.WriteLine("Weight: {0} (Kg), Height: {1} (m) ,BMI : {2}",
            weightInKg, heightInMeter, BMI);
        }
    }
}
