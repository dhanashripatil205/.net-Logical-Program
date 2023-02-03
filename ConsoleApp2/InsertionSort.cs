using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class InsertionSort
    {
        public static void DisplayInsertionSort()
        {
            int[] arr = new int[] { 23, 9, 85, 12, 99 };
            int n = 5, i, j, val, flag;
            Console.WriteLine("Insertion Sorting: ");
            Console.WriteLine("Initial Array: ");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);
            }

            for (i = 1; i < n; i++)
            {
                val = arr[i];
                flag = 0;
                for (j = i - 1; j >= 0 && flag != 1;)
                {
                    if (val < arr[j])
                    {
                        arr[j + 1] = arr[j];
                        j--;
                        arr[j + 1] = val;
                    }
                    else
                    {
                        flag = 1;
                    }
                }
                Console.WriteLine("Sorted Array: ");

                for (i = 0; i < n; i++)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
    }
}
