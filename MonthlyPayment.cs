using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblem
{
    public class MonthlyPayment
    {
        public static void Payment()
        {
            int n = 0;
            double R = 1;
            Console.WriteLine("\n******Monthly Payment*****\n ");
            Console.WriteLine("Enter the value of principal : ");
            double p = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the year : ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of rate of intrest : ");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Calculating the Monthly Payment");
            n = 12 * y;
            R = r / 1200;

            double monthlyPayment = (p * R) / (1 - Math.Pow((1 + R), n));
            Console.WriteLine("MONTHLY PAYMENT IS: {0}", monthlyPayment);

        }
    }
}
