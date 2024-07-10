using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a C# Sharp program to check whether a triangle is Equilateral, Isosceles or Scalene. 
              Test Data : 
              50 50 60 
              Expected Output : 
              This is an isosceles triangle.
            */

            Console.WriteLine("\n### Triangle is Equilateral, Isosceles or Scalene ###\n");
            Console.Write("Enter the 1st side of triangle: ");
            double side1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the 2nd side of triangle: ");
            double side2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the 3rd side of triangle: ");
            double side3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            if (side1 == side2 && side2 == side3)
            {
                Console.WriteLine("Triangle is Equilateral.");
            }
            else if (side1 == side2 || side2 == side3 || side1 == side3)
            {
                Console.WriteLine("Triangle is Isosceles.");
            }
            else
            {
                Console.WriteLine("Triangle is Scalene.");
            }
            Console.ReadKey();
        }
    }
}
