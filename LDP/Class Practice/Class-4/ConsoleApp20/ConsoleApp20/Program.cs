using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a program in C# Sharp to display the pattern like pyramid using an asterisk 
              and each row contain an odd number of an asterisks.

                        * 
                       *** 
                      ***** 
            */

            Console.Write("Input the number of row: ");
            int n = int.Parse(Console.ReadLine()); 

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}
