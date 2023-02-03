using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class LinkedList
    {
        NewNode head;
        public void Add(int data)
        {
            NewNode node = new NewNode(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                NewNode temp = head;

                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }

            Console.WriteLine("{0} is inserted in Linked List.", data);
        }
        public void Display()
        {
            NewNode temp = head;

            if (temp == null)
            {
                Console.WriteLine("Linked List is Empty");
            }
            Console.WriteLine("Display Method will be excuted.");

            while (temp != null)
            {
                temp = temp.next;
            }

        }
    }
}
