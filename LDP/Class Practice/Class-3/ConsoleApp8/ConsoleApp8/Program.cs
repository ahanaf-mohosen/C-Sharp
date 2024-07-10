using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a C# Sharp program to find the largest of three numbers. 
              Test Data : 
              Input the 1st number :25
              Input the 2nd number :63 
              Input the 3rd number :10 
              Expected Output : The 2nd Number is the greatest among three
            */

            Console.WriteLine("\n### Find The Largest of Three Numbers ###\n");
            Console.Write("Input the 1st number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the 2nd number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the 3rd number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (num1 >= num2 && num1 >= num3)
            {
                Console.WriteLine($"{num1} is the greatest among {num1} {num2} {num3}");
            }
            else if (num2 >= num3 && num2 >= num3)
            {
                Console.WriteLine($"{num2} is the greatest among {num1} {num2} {num3}");
            }
            else
            {
                Console.WriteLine($"{num3} is the greatest among {num1} {num2} {num3}");
            }
            Console.ReadLine();
        }
    }
}
