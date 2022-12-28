using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class QuotientRemainder
    {
        public static void CalculateQuotientAndRemainder()
        {
            Console.WriteLine("Enter the Dividend: ");
            double dividend = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the Diviser: ");
            double diviser = Convert.ToDouble(Console.ReadLine());

            double quotient = dividend / diviser;

            double remainder = dividend % diviser;

            Console.WriteLine("The Quotient is = " + quotient + " remainder = " + remainder);
        }

    }
}
