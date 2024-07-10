using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a C# Sharp program to accept a coordinate point in an XY coordinate system and determine in which quadrant the coordinate point lies. 
              Test Data : 
              Input the value for X coordinate :7 
              Input the value for Y coordinate :9 
              Expected Output : The coordinate point (7,9) lies in the First quadrant.
            */

            Console.WriteLine("\n### Coordinate Position ###\n");
            Console.Write("Input the value of X coordinate: ");
            double xCoordinate = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input the value of Y coordinate: ");
            double yCoordinate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            if ((xCoordinate > 0 && yCoordinate >= 0) || (xCoordinate >= 0 && yCoordinate > 0))
            {
                Console.WriteLine($"The coordinate point ({xCoordinate},{yCoordinate}) lies in the 1st quadrant.");
            }
            else if ((xCoordinate < 0 && yCoordinate >= 0) || (yCoordinate <= 0 && xCoordinate > 0))
            {
                Console.WriteLine($"The coordinate point ({xCoordinate},{yCoordinate}) lies in the 2nd quadrant.");
            }
            else if ((xCoordinate < 0 && yCoordinate <= 0) || (xCoordinate <= 0 && yCoordinate < 0))
            {
                Console.WriteLine($"The coordinate point ({xCoordinate},{yCoordinate}) lies in the 3rd quadrant.");
            }
            else if ((xCoordinate > 0 && yCoordinate <= 0) || (xCoordinate >= 0 && yCoordinate < 0))
            {
                Console.WriteLine($"The coordinate point ({xCoordinate},{yCoordinate}) lies in the 4th quadrant.");
            }
            else if ((xCoordinate == 0 && yCoordinate == 0))
            {
                Console.WriteLine($"The coordinate point ({xCoordinate},{yCoordinate}) lies in the center.");
            }
            Console.ReadLine();
        }
    }
}
