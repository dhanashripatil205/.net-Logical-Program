using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class MethodOverriding
    {
        public virtual void MethodOverridingCalculate()
            {
               
                Console.WriteLine("Adding Two numbers");

            }
        public class Over : MethodOverriding
        {
            public override void MethodOverridingCalculate()
            {
                Console.WriteLine("Substracting 5 numbers");
                
            }

        }
    }
}
