using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a program in C# Sharp to find the sum of the series [ x - x^3 + x^5 - x^7 + x^9 -.....]. 
              Test Data :  
              Input the value of x : 2 
              Input number of terms : 5 
              The sum = 410 
              Number of terms = 5 
              The value of x = 2 
            */


            Console.WriteLine("\n### The series [ x - x^3 + x^5 - x^7 + x^9 -.....] ###\n");
            Console.Write("Input the value of x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input the number of terms: ");
            int term = Convert.ToInt32(Console.ReadLine());

            int sign = -1;
            double sum = 0;
            int count = 0;

            for (int i = 1; i <= term * 2; i += 2)
            {
                sign = -sign;
                sum += sign * Math.Pow(x, i);
                count++;
            }
            Console.WriteLine();
            Console.WriteLine("The Sum: " + sum);
            Console.WriteLine("Number of terms: " + count);
            Console.WriteLine("The value of x: " + x);
            Console.ReadLine();
        }
    }
}
