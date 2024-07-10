using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.params_keyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, };
            paramsMethod(5,arr);
            Console.ReadLine();
        }
        public static void paramsMethod(int x, params int[] arr)
        {
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
