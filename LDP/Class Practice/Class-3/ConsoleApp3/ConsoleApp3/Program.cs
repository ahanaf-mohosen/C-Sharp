using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a C# Sharp program to check whether a given number is positive or negative. 
              Test Data : 14 
              Expected Output : 
              14 is a positive number 
            */

            Console.WriteLine("\n### Chack Your Number Positive or Negative ###\n");
            Console.Write("Enter your number: ");
            double num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            if (num >= 0)
            {
                Console.WriteLine("Your number is positive.");
            }
            else
            {
                Console.WriteLine("Your number is negative.");
            }
            Console.Read();
        }
    }
}
