using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class GenericCollection
    {
        /*private static void doListDemo()
        {
            Console.WriteLine("In doListDemo");
            List<string> list = new List<string>();
            list.Add("Ravi");
            list.Add("Vijay");
            list.Add("Ravi");
            list.Add("Ajay");

            foreach(var element in list)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("-----------------------------------------------------");
        }*/

        /*private static void doDictionaryDemo()
        {
            Console.WriteLine("In doDictionaryDemo");
            Dictionary<int,string> dictionary = new Dictionary<int,string>();
            dictionary.Add(100,"Ravi");
            dictionary.Add(102,"Vijay");
            dictionary.Add(103,"Dhanu");
            dictionary.Add(105, "Dhanu");
            dictionary.Add(104,"Ajay");
            Console.WriteLine("Access value using key (key=100): " + dictionary[100]);
            Console.WriteLine("Iterating the Queue Elements.");

            foreach (var element in dictionary)
            {
                Console.WriteLine("key= " +element.Key+ "Value= "+element.Value);
            }
            Console.WriteLine("-----------------------------------------------------");

        }*/

        /*private static void doSetDemo()
        {
            Console.WriteLine("In doSetDemo");
            HashSet<string> set = new HashSet<string>();
            set.Add("Ravi");
            set.Add("Vijay");
            set.Add("Ravi");
            set.Add("Ajay");

            foreach (var element in set)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("-----------------------------------------------------");

        }*/

        public static void doStackDemo()
        {
            Console.WriteLine("In doStackDemo");
            Stack<string> stack = new Stack<string>();
            stack.Push("Ayush");
            stack.Push("Garvit");
            stack.Push("Amit");
            stack.Push("Ashish");
            stack.Push("Ashish");
            stack.Push("Garima");
            string Pop = stack.Pop();

            foreach (var element in stack)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("Popped Element" + Pop);
            Console.WriteLine("-----------------------------------------------------");

        }

        /* public static void doQueueDemo()
         {
             Console.WriteLine("In doQueueDemo");
             Queue<string> queue = new Queue<string>();
             queue.Enqueue("Ayush Sharma");
             queue.Enqueue("Garvit Raj");
             queue.Enqueue("Amit Dubey");
             queue.Enqueue("Vijay shah");
             queue.Enqueue("Garvit Raj");
             Console.WriteLine("Head: " + queue.Peek());
             Console.WriteLine("Iterating the Queue Elements.");

             foreach (var element in queue)
             {
                 Console.WriteLine(element);
             }
             string dequeue = queue.Dequeue();
             Console.WriteLine("Dequeue Element: " + dequeue);
             Console.WriteLine("Iterating the Queue Elements after dequeue one element.");
             Console.WriteLine("-----------------------------------------------------");

         }*/

    }
}

