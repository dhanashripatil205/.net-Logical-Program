using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class VowelOrConstant
    {
        public static void CheckVowelConstant()
        {
            Console.WriteLine("Enter the Alphabet : ");

            Char ch = Convert.ToChar(Console.ReadLine().ToLower());

            switch (ch)
            {
                case 'a':
                    Console.WriteLine($"The Entered Alphabet {ch} is Vowel");
                    break;

                case 'e':
                    Console.WriteLine($"The Entered Alphabet {ch} is Vowel");
                    break;

                case 'i':
                    Console.WriteLine($"The Entered Alphabet {ch} is Vowel");
                    break;

                case 'o':
                    Console.WriteLine($"The Entered Alphabet {ch} is Vowel");
                    break;

                case 'u':
                    Console.WriteLine($"The Entered Alphabet {ch} is Vowel");
                    break;

                default:
                    Console.WriteLine($"The Entered Alphabet {ch} is Constant");
                    break;


            }
        }
    }
}
