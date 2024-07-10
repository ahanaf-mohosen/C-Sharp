using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = new int[4];
            Numbers[0] = 101;
            Numbers[1] = 102;
            Numbers[2] = 103;
            Numbers[3] = 104;

            paramsMethod();

            Console.ReadLine();
        }

        public static void paramsMethod(params int[] Numbers)
        {
            Console.WriteLine("There are {0} elements", Numbers.Length);
            foreach (int i in Numbers)
            {
                Console.WriteLine(i);
            }
        }
    }
}
