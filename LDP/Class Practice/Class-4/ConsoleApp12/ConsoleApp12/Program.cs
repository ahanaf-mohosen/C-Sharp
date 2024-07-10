using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a program in C# Sharp to make such a pattern like right angle triangle with number increased by 1. 
              The pattern like : 
                                  1 
                                  2 3 
                                  4 5 6 
                                  7 8 9 10  
            */



            Console.Write("Enter the number of rows: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int sum = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{sum} \t");
                    sum++;
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
