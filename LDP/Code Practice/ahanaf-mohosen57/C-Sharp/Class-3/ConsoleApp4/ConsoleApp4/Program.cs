using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a C# Sharp program to find whether a given year is a leap year or not. 
              Test Data : 2016 
              Expected Output : 2016 is a leap year
            */

            Console.WriteLine("\n### Check Your Years Leap Year or Not ###\n");
            Console.Write("Enter your year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (year % 4 == 0 || year % 100 != 0 || year % 400 == 0)
            {
                Console.WriteLine($"{year} is a leap year.");
            }
            else
            {
                Console.WriteLine($"{year} is not a leap year.");
            }
            Console.ReadLine();
        }
    }
}
