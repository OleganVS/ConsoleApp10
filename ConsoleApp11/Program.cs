using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string str1 = "";
            foreach(char c in str) 
            {
                str1 = c + str1;
            }
            Console.WriteLine(str1);
            Console.ReadKey();
        }
    }
}
