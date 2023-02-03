using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class PrimeNumberInGivenRange
    {
        public static void CalculatePrimeNumberInGivenRange()
        {
            Console.WriteLine("Enter Starting Range: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Ending Range: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int count = 0;

            for (int i = num1; i <= num2; i++)
            {
                if (i == 1 || i == 0)
                {
                    continue;
                }
                count = 1;

                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        count = 0;
                        break;
                    }
                }
                 
                if (count == 1)
                    Console.Write(i+ " ");

            }
        }
    }
}
