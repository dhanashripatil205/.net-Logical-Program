using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class BubbleSort
    {
        public void DisplayBubbleSort()
        {
            int[] arr = { 78, 55, 45, 98, 13 };
            int temp;
            for (int i = 0; i <= arr.Length - 2; i++)
            {
                for (int j = 0; j <= arr.Length - 2; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            Console.WriteLine("Sorted:");

            foreach (int p in arr)
            {
                Console.WriteLine(p);
            }
        }
    }
}
