using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a program in C# Sharp to display the sum of the series [ 9 + 99 + 999 + 9999 ...]. 
              Test Data :  
              Input the number or terms :5  
              Expected Output : 
              9 99 999 9999 99999  
              The sum of the series = 111105 
            */


            Console.WriteLine("\n### The sum of the series [ 9 + 99 + 999 + 9999 ...] ###\n");
            Console.Write("Input the number or terms: ");
            int num = int.Parse(Console.ReadLine());

            int sum = 0;
            int term = 9;
            for (int i = 1; i <= num; i++)
            {
                Console.Write(term + " ");
                sum += term;
                term = term * 10 + 9;
            }
            Console.WriteLine();
            Console.WriteLine($"The sum of the series: {sum}");
            Console.ReadLine();
        }
    }
}
