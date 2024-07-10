using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a program in C# Sharp to find maximum and minimum element in an array. 
              Test Data: 
              Input the number of elements to be stored in the array :3 
              Input 3 elements in the array: 
              element - 0: 45 
              element - 1: 25 
              element - 2: 21 
              
              Expected Output: 
              Maximum element is: 45 
              Minimum element is: 21
            */

            try
            {
                Console.WriteLine("\n### maximum and minimum element in an array ###\n");
                Console.Write("Input the number of elements to be stored in the array: ");
                int arrNum = int.Parse(Console.ReadLine());
                int[] arr = new int[arrNum];

                Console.WriteLine("Input {0} elements in the array:");

                for (int i = 0; i < arrNum; i++)
                {
                    Console.Write("element - {0}: ", i);
                    arr[i] = int.Parse(Console.ReadLine());
                }
                int max = arr[0];
                int min = arr[0];
                for (int i = 1; i < arrNum; i++)
                {
                    if (arr[i] < min)
                    {
                        min = arr[i];
                    }
                    if (arr[i] > max)
                    {
                        max = arr[i];
                    }
                }
                Console.WriteLine("Maximum element is: " + max);
                Console.WriteLine("Minimum element is: " + min);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
