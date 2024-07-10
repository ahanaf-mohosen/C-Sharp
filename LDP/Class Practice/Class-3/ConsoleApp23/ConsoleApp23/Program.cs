using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a program in C# Sharp to read any Month Number in integer and display the number of days for this month. 
              Test Data: 7 
              Expected Output: Month have 31 days 
            */

            Console.WriteLine("\n### Read any Month Number in integer and display the number of days for this month ###\n");
            Console.Write("Input a month number: ");
            int monthNumber = int.Parse(Console.ReadLine());
            int numberOfDays;
            Console.WriteLine();

            switch (monthNumber)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    numberOfDays = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    numberOfDays = 30;
                    break;
                case 2:
                    numberOfDays = 28;
                    break;
                default:
                    numberOfDays = 0;
                    break;
            }
            if (numberOfDays == 0)
            {
                Console.WriteLine("Invalid month number");
            }
            else
            {
                Console.WriteLine($"Month has {numberOfDays} days.");
            }
            Console.ReadLine();
        }
    }
}
