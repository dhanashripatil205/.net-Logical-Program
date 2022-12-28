using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class Fibonacci
    {
        public static void FindFibonacci()
        {
            Console.WriteLine("Enter the Number of Elements: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int num1 = 0;
            int num2 = 1;

            Console.Write(num1 + "\n" + num2 + "\n");

            for (int i = 0; i <= num; i++)
            {
                int num3 = num1 + num2;
                Console.WriteLine("Fibonacci series:" + num3);
                num1 = num2;
                num2 = num3;
            }
        }
    }
}
