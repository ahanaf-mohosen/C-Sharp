using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a program in C# Sharp to find the sum of the series 1 +11 + 111 + 1111 + .. n terms.
              Test Data :  
              Input the number of terms : 5  
              Expected Output : 
              1 + 11 + 111 + 1111 + 11111 + 
              The Sum is : 12345 
            */


            Console.WriteLine("\n### The sum of the series [ 1 + 11 + 111 + 1111 + ...] ###\n");
            Console.Write("Input the number or terms: ");
            int num = int.Parse(Console.ReadLine());

            int sum = 0;
            int term = 1;
            for (int i = 1; i <= num; i++)
            {
                Console.Write(term + " + ");
                sum += term;
                term = term * 10 + 1;
            }
            Console.WriteLine();
            Console.WriteLine($"The sum of the series: {sum}");
            Console.ReadLine();
        }
    }
}
