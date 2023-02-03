using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class GenericClass<T>
    {
        // define a variable of type T 
        public T Data;
        
        // define a constructor of the Student class 
        public GenericClass(T Data)
        {
            this.Data = Data;
            Console.WriteLine(this.Data);
        }
    }
}
