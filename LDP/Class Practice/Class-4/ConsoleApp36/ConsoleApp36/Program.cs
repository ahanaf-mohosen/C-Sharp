using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp36
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a program in C# Sharp to display the such a pattern for n number of rows using a number 
              which will start with the number 1 and the first and a last number of each row will be 1. 

                             1 
                            121 
                           12321 
           */


            Console.WriteLine("\n### Pascal's triangle ###\n");
            Console.Write("Input number of rows: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= num - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(k);
                }
                for (int k = i - 1; k >= 1; k--)
                {
                    Console.Write(k);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
