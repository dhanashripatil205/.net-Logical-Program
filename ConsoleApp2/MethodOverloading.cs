using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class MethodOverloading
    {
        public void Display(int a,int b)
        {
            int c = a + b;
            Console.WriteLine("Addition is :" +c);
        }
        public void Display(string a, int b)
        {
            Console.WriteLine(a);
        }

    }
}
