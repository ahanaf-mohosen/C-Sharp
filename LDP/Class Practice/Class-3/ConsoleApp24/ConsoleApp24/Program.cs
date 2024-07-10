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
            /*Write a program in C# Sharp which is a Menu-Driven Program to compute the area of the various geometrical shape.  
              Test Data: 
              Input your choice: 1 
              Input radius of the circle: 5 
              Expected Output: 
              The area is: 78.500000 
            */

            Console.WriteLine("\n### Menu-Driven Program to compute the area of the various geometrical shape ###\n");

            while (true)
            {
                Console.WriteLine("Choose a shape to calculate its area: \n");
                Console.WriteLine("1. Circle");
                Console.WriteLine("2. Rectangle");
                Console.WriteLine("3. Triangle");
                Console.WriteLine("4. Exit");
                Console.WriteLine();

                Console.Write("Your Choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter radius of the circle: ");
                        double radius = double.Parse(Console.ReadLine());
                        double area = Math.PI * radius * radius;
                        Console.WriteLine($"The area is: {area:F2}");
                        break;
                    case 2:
                        Console.Write("Enter length of the rectangle: ");
                        double length = double.Parse(Console.ReadLine());
                        Console.Write("Enter width of the rectangle: ");
                        double width = double.Parse(Console.ReadLine());
                        area = length * width;
                        Console.WriteLine($"The area is: {area:F2}");
                        break;
                    case 3:
                        Console.Write("Enter base of the triangle: ");
                        double triangleBase = double.Parse(Console.ReadLine());
                        Console.Write("Enter height of the triangle: ");
                        double height = double.Parse(Console.ReadLine());
                        area = 0.5 * triangleBase * height;
                        Console.WriteLine($"The area is: {area:F2}");
                        break;
                    case 4:
                        Console.WriteLine("Exiting program...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
                Console.WriteLine();
                Console.ReadLine();
            }
        }
    }
}
