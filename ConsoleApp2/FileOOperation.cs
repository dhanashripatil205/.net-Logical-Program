using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class FileOOperation
    {
        public static void CheckFileExists(string path)
        {
            if (File.Exists(path))
            {
                Console.WriteLine("The File Exists.");
            }
            else
            {
                Console.WriteLine("The File does not Exists.");
            }
        }

        /*public static void ReadTheDataFromFile(string path)
        {
            string[] lines;
            lines= File.ReadAllLines(path);

            Console.WriteLine(lines[0]);
            Console.WriteLine(lines[1]);
            //Console.WriteLine(lines[2]);
            //Console.WriteLine(lines[3]);

            Console.WriteLine();

            //If the 1000 of lines are there in program then we can use forEach loop till condition is satisfied.
            //Here we are not printing the data line by line until the for loop becomes null its printed.

            foreach(string ele in lines)
            {
                Console.WriteLine(ele);
            }
        }

        public static void ReadFromFile(string path)
        {
            string line;
            line = File.ReadAllText(path);

            Console.WriteLine(line);
           
        }

        public static void CopyToAnotherFile(string path)
        {
            string CopyPath = "C:\\Users\\ganesh\\source\\repos\\File-I-O-Operation\\File-I-O-Operation\\CopyExample.txt";

            File.Copy(path, CopyPath);
        }

        public static void DeleteFile(string path)//here no need to pass the path parameter becoz its not required we are only deleting the file here.
        {
            string CopyPath = "C:\\Users\\ganesh\\source\\repos\\File-I-O-Operation\\File-I-O-Operation\\CopyExample.txt";

            File.Delete(CopyPath);
        }

        //Using StremReader

        public static void ReadFromStremReader(string path)
        {
            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }

        public static void WriteUsingStremWriter(string path)
        {
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(".net is a technology");
            }
        }*/
    }
}
