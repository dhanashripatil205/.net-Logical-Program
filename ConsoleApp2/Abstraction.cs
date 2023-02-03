using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public abstract class Abstraction
    {
        public abstract void Display();

        public void Camera()
        {
            Console.WriteLine("Hi");
        }
    }

    public class Honda : Abstraction
    {
        public override void Display()
        {
            Console.WriteLine("I Am Not Argue With You");

        }

        public void Match()
        {
            Console.WriteLine("Concrit class of derived class");
        }

    }
}
