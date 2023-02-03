using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Coupon
    {
        public static void CheckCoupon()
        {
            Console.WriteLine("how much time you want a unique random number :- ");
            int N1 = Convert.ToInt32(Console.ReadLine());
            var Num = Enumerable.Range(0, N1).ToArray();
            var R = new Random();

            for (int i = 0; i < Num.Length; i++)
            {
                int RAN = R.Next(Num.Length);
                int vr = Num[RAN];
                Num[RAN] = Num[i];
                Num[i] = vr;
            }
            Console.Write("The unique random numbers are :-  ");
            for (int i = 0; i < Num.Length; i++)
                Console.Write(Num[i] + " ");
        }
    }
}
