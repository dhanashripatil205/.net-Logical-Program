using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
     interface IMultipleInheritanceInterface
     {
         void InterfaceMethodBody();
         void Display();

     }

    interface IFruit
    {
         void InterfaceMethodBody();
    }

    class Water: IFruit, IMultipleInheritanceInterface
    {
        void IMultipleInheritanceInterface.Display()
        {
            Console.WriteLine("Display Method");
        }
        void IMultipleInheritanceInterface.InterfaceMethodBody()
        {
            Console.WriteLine("InterfaceMethodBody Method");
        }

        void IFruit.InterfaceMethodBody()
        {
            Console.WriteLine("InterfaceMethodBody of Ifruit class");
        }
    }
}

