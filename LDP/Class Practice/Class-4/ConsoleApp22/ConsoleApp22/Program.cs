using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a program in C# Sharp to print the Floyd's Triangle. 
             
                         1 
                         01  
                         101 
                         0101  
                         10101 
            */

            Console.Write("Number of row: ");
            int row = int.Parse(Console.ReadLine());

            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if ((i+j) % 2 == 0)
                    {
                        Console.Write("1 ");
                    }
                    else
                    {
                        Console.Write("0 ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
