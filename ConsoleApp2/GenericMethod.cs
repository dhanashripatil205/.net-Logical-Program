using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class GenericMethod<T>
    {
        // define a generics method that displays the passed data  
        public void displayData(T data)
        {
            Console.WriteLine("The data passed is: " + data);
        }
    }
}
