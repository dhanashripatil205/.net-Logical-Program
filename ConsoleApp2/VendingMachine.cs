using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class VendingMachine
    {
        public static void Display()
        {
            Console.WriteLine("\n******Vending Machine*****\n ");
            //There are 1, 2, 5, 10, 50, 100, 500 and 1000 Rs Notes
            int one = 1, two = 2, five = 5, ten = 10, fifty = 50, hund = 100, fivehun = 500, thous = 1000;

            int count = 0;
            int count2 = 0;
            int count3 = 0;
            int count4 = 0;
            int count5 = 0;
            int count6 = 0;
            int count7 = 0;
            int count8 = 0;
            int totalCount = 0;

            System.Console.WriteLine("Enter the amount to give You change with minimum notes");
            int n = Convert.ToInt32(Console.ReadLine());
            int temp = n;
            for (int i = 0; i <= n; i++)
            {

                if (n > 999 && n < 10000)
                {
                    n = n - thous;
                    count++;
                }
                else
                    i = n;

            }
            Console.WriteLine("the number of 1000 notes are : {0}", count);
            for (int j = 0; j <= n; j++)
            {

                if (n >= 500 && n <= 999)
                {
                    n = n - fivehun;
                    count2++;
                }
                else
                    j = n;

            }
            Console.WriteLine("the number of 500 notes are : {0}", count2);
            for (int k = 0; k <= n; k++)
            {

                if (n >= 100 && n <= 499)
                {
                    n = n - hund;
                    count3++;
                }
                else
                    k = n;

            }
            Console.WriteLine("the number of 100 notes are : {0}", count3);
            for (int l = 0; l <= n; l++)
            {

                if (n >= 50 && n <= 99)
                {
                    n = n - fifty;
                    count4++;
                }
                else
                    l = n;

            }
            Console.WriteLine("the number of 50 notes are : {0}", count4);
            for (int m = 0; m <= n; m++)
            {

                if (n >= 10 && n <= 49)
                {
                    n = n - ten;
                    count5++;
                }
                else
                    m = n;

            }
            Console.WriteLine("the number of 10 notes are : {0}", count5);
            for (int o = 0; o <= n; o++)
            {

                if (n >= 5 && n <= 9)
                {
                    n = n - five;
                    count6++;
                }
                else
                    o = n;

            }
            Console.WriteLine("the number of 5 notes are : {0}", count6);
            for (int p = 0; p <= n; p++)
            {

                if (n >= 2 && n <= 4)
                {
                    n = n - two;
                    count7++;
                }
                else
                    p = n;

            }
            Console.WriteLine("the number of 2 notes are : {0}", count7);
            for (int q = 0; q <= n; q++)
            {

                if (n == 1)
                {
                    n = n - one;
                    count8++;
                }
                else
                    q = n;

            }
            Console.WriteLine("the number of 1 notes are : {0}", count8);

            totalCount = count + count2 + count3 + count4 + count5 + count6 + count7 + count8;
            Console.WriteLine("The number of minimum notes to give change is : {0} ", totalCount);


        }
    }
}
