using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string str = Console.ReadLine();
            string[] strarray= str.Split();
            string max = strarray[2];
            foreach(string s in strarray) 
            {
                if (s.Length > max.Length) 
                {
                    max = s; 
                }
                Console.WriteLine(max);
                Console.ReadKey();
            }
        }
    }
}
