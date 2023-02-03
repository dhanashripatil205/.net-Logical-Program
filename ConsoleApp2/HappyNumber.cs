using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class HappyNumber
    {
        public static void Happy()
        {
            Console.WriteLine("Enter a Number : ");
            int Number = Convert.ToInt16(Console.ReadLine());
            double Sqr = Math.Pow(Number, 2);
            Console.WriteLine("Square of {0} is: {1}", Number, Sqr);
            Console.ReadLine();
        }
    }
}
