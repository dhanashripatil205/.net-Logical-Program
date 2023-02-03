using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class StringUsingBubbleSort
    {
        public void DisplyStringBubbleSort()
        {
            string[] arr = { "Ha", "Hc", "Hb" };
            string temp;
            for (int i = 0; i <= arr.Length - 2; i++)
            {
                for (int j = 0; j <= arr.Length - 2; j++)
                {
                    if (arr[j].CompareTo(arr[j + 1]) > 0)
                    {
                        temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            Console.WriteLine("Sorted:");

            foreach (string p in arr)
            {
                Console.WriteLine(p);
            }
        }
    }
}
