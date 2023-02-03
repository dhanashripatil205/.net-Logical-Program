using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class HirarchicalInheritance
    {
        public void SumOfTwoNumbers(int a,int b)
        {
            int c= a+ b;
            Console.WriteLine("c is :" +c);
        }
    }

    public class Banana: HirarchicalInheritance
    {
        public void SumOfThreeNumbers()
        {
            SumOfTwoNumbers(10,20);

        }
    }

    public class Apple : HirarchicalInheritance
    {
        public void SumOfFourNumbers()
        {
           Console.WriteLine("Hi this is the derived class.");
           SumOfTwoNumbers(1,1);
        }

    }
}
