using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class ReverseNumber
    {
        public static void CheckReverseNumber()
        {
            int Reverse = 0;

            Console.WriteLine("Enter the number : ");

            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                int Remainder = num % 10;
                Reverse = Reverse * 10 + Remainder;
                num = num / 10;

            }
            Console.WriteLine(Reverse);

        }
    }
}
