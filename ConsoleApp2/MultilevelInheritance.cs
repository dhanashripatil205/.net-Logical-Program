using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class MultilevelInheritance
    {
        public void Display()
        {
            Console.WriteLine("Parent class of Multilevel inheritance.");
        }
    }

    public class Derived : MultilevelInheritance
    {
        public void Calculate(int a,int b)
        {
            int c = a + b;
            Console.WriteLine(c);
            Console.WriteLine("Dervied class of Multilevel inheritance.");
        }

    }
    
    public class Derived1 : Derived
    {
        public void Noisy()
        {
            Console.WriteLine("This is the multiLevel Inheritance");
        }
    }
}
