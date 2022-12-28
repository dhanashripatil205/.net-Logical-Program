using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class LargestNumber
    {
        public static void FindLargestNum()
        {
            Console.WriteLine("Enter the number A : ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the number B : ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the number C : ");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine("A is Greater number than B & C");
            }
            else if (b > a && b > c)
            {
                Console.WriteLine("B is the Greater number than A & C");
            }
            else
            {
                Console.WriteLine("C is the Greater number than A & B");
            }

        }
    }
}
