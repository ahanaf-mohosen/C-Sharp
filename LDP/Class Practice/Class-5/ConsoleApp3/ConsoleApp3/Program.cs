using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a program in C# Sharp to find the sum of all elements of the array.  
              Test Data: 
              Input the number of elements to be stored in the array: 3 
              Input 3 elements in the array: 
              element - 0: 2 
              element - 1: 5 
              element - 2: 8 
              Expected Output: 
              Sum of all elements stored in the array is: 15
            */

            try
            {
                Console.WriteLine("\n### Find the sum of all elements of the array ###\n");
                Console.Write("Input the number of elements to be stored in the array: ");
                int arrNum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Input {arrNum} elements in the array:");

                int[] arr = new int[arrNum];
                int sum = 0;
                for (int i = 0; i < arrNum; i++)
                {
                    Console.Write("element - {0}: ", i);
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                    sum += arr[i];
                }
                Console.WriteLine("Sum of all elements stored in the array is: {0}",sum);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
