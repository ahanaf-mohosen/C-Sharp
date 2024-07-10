using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a C# Sharp program to accept two integers and check whether they are equal  or not. 
              Test Data:
              Input 1st number: 5
              Input 2nd number: 5
              Expected Output : 
              5 and 5 are equal
            */

            Console.WriteLine("\n### Compare Your Two Numbers (Equal/Not_Equal) ###\n");
            Console.Write("Input 1st number: ");
            int num1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Input 2nd number: ");
            int num2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine();

            if (num1 == num2)
            {
                Console.WriteLine($"{num1} and {num2} are equal.");
            }
            else
            {
                Console.WriteLine($"{num1} and {num2} are not equal.");
            }
            Console.ReadLine();


        }
    }
}
