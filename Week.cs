using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblem
{
    public class Week
    {

        public static void DayOfWeek()
        {
            int m = 0, j = 12;
            string[] days = new string[7] { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            string[] month = new string[12] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            System.Console.WriteLine("Enter the date (1-31) : ");
            int d = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter the Month which 1st letter should be Capital.(e.g January, February, March): ");
            string n = Console.ReadLine();
            for (int i = 0; i < j; i++)
            {
                if (n == month[i])
                    m = i + 1;
            }


            Console.WriteLine("Enter the year : ");
            int y = Convert.ToInt32(Console.ReadLine());
            if (d >= 1 && m >= 1 && y >= 1000 && d <= 31 && m <= 12 && y <= 10000)
            {
                int y0 = y - (14 - m) / 12;
                int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
                int m0 = m + 12 * ((14 - m) / 12) - 2;
                int d0 = (d + x + 31 * m0 / 12) % 7;
                Console.WriteLine("The Day on this Date is: " + days[d0]);
            }
            else
                Console.WriteLine("Enter the valid Date");
        }
    }
}
