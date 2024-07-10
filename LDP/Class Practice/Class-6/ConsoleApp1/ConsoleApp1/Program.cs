using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*What is 1D Array?  
              user input 11-19 and keep in 1D array and print the data using while loop.
            */

            /*A one-dimensional (1D) array is a collection of elements of the same data type 
             *that are stored in a linear sequence in memory. Each element in a 1D array is identified by its index, 
             *which is an integer value that starts from 0 and goes up to the size of the array minus one.
             */

            try
            {
                Console.WriteLine("Input numbers between 11 and 19: ");
                int[] arrNum = new int[9];

                int i = 0;
                while (i < arrNum.Length)
                {
                    Console.Write("input - {0}: ", i);
                    int input = int.Parse(Console.ReadLine());
                    if (input >= 11 && input <= 19)
                    {
                        arrNum[i] = input;
                        i++;
                    }
                    else
                    {
                        throw new IndexOutOfRangeException("Invalid input. Please enter a number between 11 and 19!");
                    }
                }
                Console.Write("The numbers you entered are: ");
                i = 0;
                while (i < arrNum.Length)
                {
                    Console.Write(arrNum[i] + " ");
                    i++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();

        }
    }
}
