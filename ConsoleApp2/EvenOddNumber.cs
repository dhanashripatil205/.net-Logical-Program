using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class EvenOddNumber
    {
        public static void CalculateEvenOdd()
        {
            Console.WriteLine("Enter the Number: ");

            int Num = Convert.ToInt32(Console.ReadLine());

            if(Num%2==0)
            {
                Console.WriteLine($"{Num} is Even Number.");
            }
            else
            {
                Console.WriteLine($"{Num} is an Odd Number.");
            }
        }
    }
}
