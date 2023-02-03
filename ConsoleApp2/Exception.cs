using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Exception
    {
        public static void ExceptionClass()
        {
            try
            {
                int[] arr = new int[4];
                arr[0] = 10;
                arr[1] = 20;
                arr[2] = 30;
                arr[3] = 40;
                arr[4] = 50;

                foreach (int ele in arr)
                {
                    Console.WriteLine(ele);
                }
                int a = 20;
                int b = 0;
                int c = a / b;

                Console.WriteLine(c);
                Console.WriteLine(c);
                Console.WriteLine("The program is Executed.");//this statement is available in Finally block menas it will be executed every time.

            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("The program is Executed.");
            }
        }
    }
}

