using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class reverseString
    {
        public static void ReverseString()
        {
            Console.Write("Enter a String : ");
            string name = Console.ReadLine();
            string reverse = string.Empty;
            for (int i = name.Length - 1; i >= 0; i--)
            {
                reverse += name[i];
            }
            Console.WriteLine($"The Reverse string is : {reverse}");
            Console.ReadLine();
        }
    }
}
