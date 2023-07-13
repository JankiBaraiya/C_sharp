/*Write a program to create a class named Candidate with ID, Name, Age, 
Weight and Height as data members & also create a member functions like 
GetCandidateDetails() and DisplayCandidateDetails()*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            Candidate c = new Candidate();
            c.getDetail();
            c.display();
        }
    }
      public class Candidate
     {
         int id, age;
         double weight, height;
         string name;

          public void getDetail()
         {
             Console.WriteLine(" enter id : ");
             id = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine(" enter age : ");
             age = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine(" enter weight : ");
             weight = Convert.ToDouble(Console.ReadLine());
             Console.WriteLine(" enter height : ");
             height = Convert.ToDouble(Console.ReadLine());
             Console.WriteLine(" enter name : ");
             name = Convert.ToString(Console.ReadLine());
         }

          public void display()
         {
             Console.WriteLine(id);
             Console.WriteLine(name);
             Console.WriteLine(age);
             Console.WriteLine(weight);
             Console.WriteLine(height);
         }
     }
}

