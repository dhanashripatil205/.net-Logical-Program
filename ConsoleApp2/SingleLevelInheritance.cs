using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class SingleLevelInheritance
    {
        public string name = "Dhanashri";
        public void singleInheritance()
        {
            int a = 2;
            Console.WriteLine(a);
            //Console.WriteLine("Name is: " +name);
        }

        public void SumOfTwoNumbers(int a, int b)
        {
            int c = a + b;
            Console.WriteLine("Addition is : " +c);
        }
    }

    public class Mango: SingleLevelInheritance
    {
        public void Calculate()
        {
        //singleInheritance();
            int d = 4;
            Console.WriteLine(d);
            Console.WriteLine("Name is: " + name);


        }

    }
}
