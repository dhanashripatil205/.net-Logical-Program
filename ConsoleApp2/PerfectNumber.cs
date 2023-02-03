using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
   //Perfect Number- a positive integer that is equal to the sum of its proper divisors.
    internal class PerfectNumber
    {
        public static void CheckPerfectNumber()
        {
            int sum = 0;
            Console.WriteLine("Enter the number: ");
            int num = Convert.ToInt32(Console.ReadLine());


            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    sum = sum + i;
                  
                }
            }

            if (sum == num)
            {
                Console.WriteLine($"{num} is Perfect Number");
            }
            else
            {
                Console.WriteLine($"{num} is Not a Perfect Number");
            }



        }
    }
}
