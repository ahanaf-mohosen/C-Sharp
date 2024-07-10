using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a program in C# Sharp to count the frequency of each element of an array. 
              Test Data: 
              Input the number of elements to be stored in the array :3 
              Input 3 elements in the array: 
              element - 0: 25 
              element - 1: 12 
              element - 2: 43 
              
              Expected Output: 
              Frequency of all elements of array: 
              25 occurs 1 time 
              12 occurs 1 time 
              43 occurs 1 time
            */

            try
            {
                Console.WriteLine("\n### Count the frequency of each element of an array ###\n");
                Console.Write("Input the number of elements to be stored in the array: ");
                int arrNum = int.Parse(Console.ReadLine());

                int[] arr = new int[arrNum];
                int[] fr = new int[arrNum];
                int visited = -1; 
                /*In the case of this code, we use -1 as the visited marker value 
                  because the frequency counts of the elements in the input array are non-negative integers.*/

                Console.WriteLine($"Input {arrNum} elements in the array:");

                for (int i = 0; i < arrNum; i++)
                {
                    Console.Write($"element - {i}: ");
                    arr[i] = int.Parse(Console.ReadLine());
                }
                //example: 2,2,3,2,5
                for (int i = 0; i < arrNum; i++)
                {
                    int count = 1;
                    for (int j = i + 1; j < arrNum; j++)
                    {
                        if (arr[i] == arr[j])
                        {
                            count++;
                            fr[j] = visited;
                        }
                    }

                    if (fr[i] != visited)
                    {
                        fr[i] = count;
                    }
                }

                Console.WriteLine("\nFrequency of all elements of array:");

                for (int i = 0; i < arrNum; i++)
                {
                    if (fr[i] != visited)
                    {
                        Console.WriteLine($"{arr[i]} occurs {fr[i]} times");
                    }
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
