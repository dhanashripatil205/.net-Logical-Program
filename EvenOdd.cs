using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class EvenOdd
    {
        public static void CheckEvenOdd()
        {
            System.Console.WriteLine("Enter the Number : ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine($"Entered Number {num} is Even.");

            }
            else
            {
                Console.WriteLine($"Entered Number {num} is Odd.");
            }

        }
    }
}
