using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class PrimeFactor
    {
        public static void PrimeFactorization()
        {

            Console.WriteLine("Enter the Number to find the Prime Factor : ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Prime Factors of " + n + "are:");

            for (int i = 2; i < n; i++)
            {
                while (n % i == 0)
                {
                    Console.WriteLine(i + "");
                    n = n / i;
                }

            }
            if (n > 2)
            {
                Console.WriteLine(n);
            }
        }
    }
}
