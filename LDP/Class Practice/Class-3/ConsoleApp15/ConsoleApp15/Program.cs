using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a C# Sharp program to check whether a triangle can be formed by the given value for the angles. 
              Test Data : 
              40 55 65 
              Expected Output : 
              The triangle is not valid. 
            */

            Console.WriteLine("\n### A triangle can be formed by the given value for the angles ###\n");
            Console.Write("Enter the 1st angle of the triangle: ");
            int angle1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the 2nd angle of the triangle: ");
            int angle2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the 3rd angle of the triangle: ");
            int angle3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (angle1 + angle2 + angle3 == 180)
            {
                Console.WriteLine("The triangle is valid.");
            }
            else
            {
                Console.WriteLine("The triangle is not valid.");
            }
            Console.ReadLine();
        }
    }
}