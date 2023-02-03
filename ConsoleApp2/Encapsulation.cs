using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Encapsulation
    {
        private int AccountNumber;

        public int NameOfPerson
        {
            get { return AccountNumber; }

            set { AccountNumber = value; }
        }
    }
}
