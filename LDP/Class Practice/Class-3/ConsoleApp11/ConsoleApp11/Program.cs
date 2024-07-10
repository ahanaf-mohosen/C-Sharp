using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a C# Sharp program to calculate root of Quadratic Equation. 
              Test Data :
              Input the value of a : 1 
              Input the value of b : 5 
              Input the value of c : 7 
              Expected Output : 
              Root are imaginary; 
              No Solution.
            */

            Console.WriteLine("\n### root of Quadratic Equation ###\n");
            Console.Write("Input the value of a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the value of b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the value of c: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            int d = (b * b) - (4 * a * c);

            if (d > 0)
            {
                double root_1 = (-b + Math.Sqrt(d)) / (2 * a);
                double root_2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine($"The two roots are {root_1} & {root_2}. \nHere roots are real and unequal.");
            }
            else if(d == 0)
            {
                double root_1 = (-b + Math.Sqrt(d)) / (2 * a);
                double root_2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine($"The two roots are {root_1} & {root_2}. \nHere roots are real and equal.");
            }
            else
            {
                Console.WriteLine("The roots are imaginary. \nNo Solution.");
            }
            Console.ReadKey();

        }
    }
}
