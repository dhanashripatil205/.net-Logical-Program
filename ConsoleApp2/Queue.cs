using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Queue
    {
        public void DisplayQueue()
        {
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Enqueue(6);

            Console.WriteLine("Peak element of Queue is :" + queue.Peek());


            foreach (int ele in queue)
            {
                Console.WriteLine("" + ele);
            }
            Console.WriteLine("------------------------");

            queue.Dequeue();

            Console.WriteLine("Peak element of Queue is :" + queue.Peek());


            foreach (int ele in queue)
            {
                Console.WriteLine("" + ele);
            }

        }
    }
}
