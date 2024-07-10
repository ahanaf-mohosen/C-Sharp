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
            /*Write a C# Sharp program to calculate the factorial of a given number.
              Test Data : 
              Input the number : 5  
              Expected Output :  
              The Factorial of 5 is: 120  
            */

            Console.WriteLine("\n### Factorial of a given number ###\n");
            Console.Write("Input the number: ");
            int num = int.Parse(Console.ReadLine());

            int fact = 1;
            for(int i = 1; i <= num; i++)
            {
                fact *= i;
            }
            Console.WriteLine($"The Factorial of {num} is: {fact}");
            Console.ReadLine();
        }
    }
}
