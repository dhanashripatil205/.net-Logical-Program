using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class LeapYear
    {
        public static void CalculateLeap()

        {
            Console.WriteLine("Enter the year:");

            int year = Convert.ToInt32(Console.ReadLine());

            //########################### 1ST SOLUTION ###########################


            if (year > 999 && year < 9999)
            {
                {
                    if (year % 4 == 0)

                    {
                        Console.WriteLine("{0} is Leap year", year);
                    }
                }
            }

            else
            {
                Console.WriteLine("Enter the 4 digit number of year");
            }




            //################################ 2nd Solution #################################


            /*if((year%400)==0)
            {
                Console.WriteLine("This is leap year");
            }

            else if((year%4)==0)
            {
                Console.WriteLine("This is leap year");
            }

            else if((year%100)==0)
            {
                Console.WriteLine("This is leap year");
            }

            else
            {
                Console.WriteLine("Entered year is not a Leap Year");
            }
            */

            //################################ 3rd Solution #################################




        }
    }
}
