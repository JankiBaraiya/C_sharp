/*Write program to prompt a user to input his/her name and country name 
and then output will be shown as given: Hello <yourname> from country 
<countryname>*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class L1P3
    {
        public static void Main()
        {
            Console.Write("Enter your name: ");
            String Name = Console.ReadLine();
            Console.Write("Enter country name: ");
            String Country = Console.ReadLine();
            Console.WriteLine("Hello " + Name + " from country " + Country);
        }
    }
}
