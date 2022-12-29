using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class Powerof2
    {
        public static void power()
        {
            Console.WriteLine("Enter the number N : ");

            int N = Convert.ToInt32(Console.ReadLine());

            int PowerofTwo = 1;

            if (0 <= N && N < 31)
            {
                for (int i = 0; i < N; i++)
                {
                    PowerofTwo = 2 * PowerofTwo;
                }

                Console.WriteLine("Power of Two is :" + PowerofTwo);

            }
            else
            {
                Console.WriteLine("Number is greater than 31");
            }



        }
    }
}
