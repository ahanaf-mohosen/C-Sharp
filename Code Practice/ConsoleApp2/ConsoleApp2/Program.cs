using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            newMethod(ref i);
            Console.WriteLine(i);
            Console.ReadLine();
        }

        public static void newMethod(ref int j)
        {
            j = 10;
        }
    }
}
