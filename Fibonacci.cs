using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class Fibonacci
    {
        public static void FindFibonacci()
        {
            Console.WriteLine("Enter the Number of Elements: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int num1 = 0;
            int num2 = 1;

            Console.Write(num1 + " " + num2 + " ");

            for (int i = 0; i <= num; i++)
            {
                int num3 = num1 + num2;
                Console.Write(num3+ " ");
                num1 = num2;
                num2 = num3;
            }
        }
    }
}
