using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Stack
    {
        public void DisplayStack()
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);

            Console.WriteLine("Peak element of stack is :" + stack.Peek());

            foreach (int ele in stack)
            {
                Console.WriteLine(ele);
            }

            Console.WriteLine("------------------------");
            stack.Pop();
            stack.Pop();
            stack.Push(13);
            stack.Push(60);
            stack.Pop();

            Console.WriteLine("After Popping the element, peak element of stack is " + stack.Peek());

            foreach (int ele in stack)
            {
                Console.WriteLine(ele);

            }

        }
    }
}
