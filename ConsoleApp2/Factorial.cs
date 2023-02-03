using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Factorial
    {
        public static void CalculateFactorial()
        {
            int factorial = 1;
            Console.WriteLine("Enter the Number N :");
            int N = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                factorial = factorial * i;
             }
            Console.WriteLine("Factorial of " + N + " is : " + factorial);

        }
    }
}
