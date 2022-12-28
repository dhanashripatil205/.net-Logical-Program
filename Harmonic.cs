using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class Harmonic
    {
        public static void Harmonicnumber()
        {
            double harmonic = 1;
            Console.WriteLine("Enter the value of N: ");

            double n = Convert.ToDouble(Console.ReadLine());

            if (n != 0)
            {

                for (double i = 1; i < n; i++)
                {
                    harmonic = harmonic + (1 / i);

                }
            }
            else
            {
                Console.WriteLine("Number should be greater than 0");
            }

            Console.WriteLine(harmonic);


        }

    }

}

