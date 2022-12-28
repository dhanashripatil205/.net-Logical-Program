using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class SwapTwoNum
    {
        public static void TwoNumSwap()
        {
            Console.WriteLine("Enter the 1st Number: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the 2nd Number: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before the Swap the two numbers x = " + x + " y = " + y);

            int z;
            z = x;
            x = y;
            y = z;

            Console.WriteLine("After the Swap the two numbers x = " + x + " y = " + y);


        }
    }
}
