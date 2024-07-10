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
            /*Write a C# Sharp program to check whether a given number is even or odd. 
              Test Data : 15 
              Expected Output : 
              15 is an odd integer 
            */

            Console.WriteLine("\n### Check Your Number (Even/Odd) ###\n");
            Console.Write("Input number: ");
            int num = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine();

            if (num % 2 == 0)
            {
                Console.WriteLine($"{num} is an even number.\n");
            }
            else
            {
                Console.WriteLine($"{num} is an odd number.\n");
            }
            Console.ReadLine();

        }
    }
}
