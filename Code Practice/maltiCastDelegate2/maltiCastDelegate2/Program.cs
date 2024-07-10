using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maltiCastDelegate2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            printDelegate del = new printDelegate(print1);
            del += print2;
            int delegateReturnValue = del();
            Console.WriteLine($"Return value is = {delegateReturnValue}");
            Console.ReadLine();
        }

        public delegate int printDelegate();
        public static int print1()
        {
            return 5;
        }
        public static int print2()
        {
            return 7;
        }
    }
}
