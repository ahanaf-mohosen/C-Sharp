using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*What is 2D Array?  
             *Take user input 19-29 and keep in 2D array and print the data using for loop.
             */

            /*A 2D array is a data structure that stores data in a matrix-like format with rows and columns. 
              It is also known as a two-dimensional array.
            */

            try
            {
                int[,] array2D = new int[3, 3];

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write($"Enter a number between 19 and 29 for element [{i},{j}]: ");
                        int input = int.Parse(Console.ReadLine());
                        if (input < 19 || input > 29)
                        {
                            Console.WriteLine("Invalid input! Number should be between 19 and 29.");
                            j--;
                        }
                        else
                        {
                            array2D[i, j] = input;
                        }
                    }
                    Console.WriteLine();
                }

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write($"{array2D[i, j]}\t");
                    }
                    Console.WriteLine();
                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
