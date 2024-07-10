using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a program in C# Sharp to make such a pattern like a pyramid with a number 
              which will repeat the number in the same row. 
                    
                       1 
                      2 2 
                     3 3 3 
                    4 4 4 4 
            */


            Console.Write("Enter the number of rows: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int num = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write($"{num} ");
                }
                num++;
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
