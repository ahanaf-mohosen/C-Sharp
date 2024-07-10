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
            /*Write a program in C# Sharp to store elements in an array and print it. 
              Test Data: 
              Input 10 elements in the array: 
              element - 0: 1 
              element - 1: 1 
              element - 2: 2 
              ....... 
              Expected Output: 
              Elements in array are: 1 1 2 3 4 5 6 7 8 9
            */

            int[] arr = new int[10];
            while (true)
            {
                try
                {
                    Console.WriteLine("Input 10 elements in the array:");
                    for (int i = 0; i < 10; i++)
                    {
                        Console.Write($"element - {i}: ");
                        arr[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine("Elements in array are:");
                    for (int i = 0; i < 10; i++)
                    {
                        Console.Write($"element - {i}: {arr[i]}\n");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input format. Please enter integers only.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Invalid input value. Please enter a smaller integer.");
                }
                Console.ReadLine();
            }
        }
    }
}
