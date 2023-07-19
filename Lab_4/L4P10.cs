/* Write a program to change the case of entered character.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class L4P10
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a character : ");
            char c = Console.ReadLine().ToCharArray()[0];
            char ans;
            if (Char.IsUpper(c))
                ans = Char.ToLower(c);
            else
                ans = Char.ToUpper(c);
            Console.WriteLine("Changed case of character : " + ans);
        }
    }
}
