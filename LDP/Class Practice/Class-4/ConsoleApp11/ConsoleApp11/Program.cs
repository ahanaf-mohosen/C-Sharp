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
            /*Write a program in C# Sharp to make such a pattern like right angle triangle with a number which will repeat a number in a row.
              The pattern like : 
                                  1 
                                  22 
                                  333 
                                  4444 
            */



            Console.Write("Enter the number of rows: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
