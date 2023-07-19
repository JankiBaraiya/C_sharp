/* Write a program to find the longest word in a string.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class L4P9
    {
        public static void Main()
        {
            string line = "Write a program to find the longest word in a string.";
            Console.WriteLine(line);
            string[] words = line.Split(new[] { " " }, StringSplitOptions.None);
            string word = "";
            int ctr = 0;
            foreach (String s in words)
            {
                if (s.Length > ctr)
                {
                    word = s;
                    ctr = s.Length;
                }
            }
            Console.WriteLine("Longest word: {0}", word);
        }

    }
}
