using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp40
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a C# Sharp Program to display the following pattern using the alphabet.
             
                          A 
                        A B A  
                      A B C B A 
                    A B C D C B A  
            */


            Console.Write("Input the number of row: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= (n - i); j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= i; j++)
                {
                    char letter = (char)(j + 64);
                    Console.Write(letter);
                }

                for (int j = (i - 1); j >= 1; j--)
                {
                    char letter = (char)(j + 64);
                    Console.Write(letter);
                }

                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
