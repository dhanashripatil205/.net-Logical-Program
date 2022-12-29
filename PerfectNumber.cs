using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class PerfectNumber
    {
        public static void CheckPerfectNumber()
        {
            int sum = 0;
            Console.WriteLine("Enter the number: ");
            int num = Convert.ToInt32(Console.ReadLine());


            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    sum = sum + i;
                    Console.WriteLine($"Factors of {num} is : " + sum);


                }
            }

            if (sum == num)
            {
                Console.WriteLine($"{num} is Perfect Number");
            }
            else
            {
                Console.WriteLine($"{num} is Not a Perfect Number");
            }



        }
    }
}

//Using Nested for Loop solution

/*int i, sum, mn, mx;
            Console.WriteLine("Find the Perfect Number within the given range or number: ");
            Console.WriteLine("Input the String range or number: ");
             mn = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the ending range or number: ");
             mx = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The perfect number witin the given range");

            for(int n = mn; n <= mx; n++)
            {
                
                sum = 0;
                for (i=1; i<n; i++)               
                {
                    if (n % i == 0)

                        sum = sum + i;
                    
                }   
                    if(sum == n)
                    
                        Console.WriteLine(" " + n);
           }*/

//using while loop solution
/*
int i, sum, mn, mx;
            Console.WriteLine("Find the Perfect Number within the given range or number: ");
            Console.WriteLine("Input the String range or number: ");
             mn = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the ending range or number: ");
             mx = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The perfect number witin the given range");

            for(int n = mn; n <= mx; n++)
            {
                
                sum = 0;
                i=1; 
                while(i<n)               
                {
                    if (n % i == 0)

                        sum = sum + i;
                    i++;
                }   
                    if(sum == n)
                    
                        Console.WriteLine(" " + n);

                    
                
            } */
