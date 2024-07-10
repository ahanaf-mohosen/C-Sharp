using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a program in C# Sharp to count a total number of duplicate elements in an array. 
              Test Data: 
              Input the number of elements to be stored in the array :3 
              Input 3 elements in the array: 
              element - 0: 5 
              element - 1: 1 
              element - 2: 1 

              Expected Output: 
              Total number of duplicate elements found in the array is: 1
            */

            try
            {
                Console.WriteLine("\n### Count a total number of duplicate elements in an array ###\n");
                Console.Write("Input the number of elements to be stored in the array: ");
                int arrNum = int.Parse(Console.ReadLine());
                Console.WriteLine("Input {0} elements in the array:", arrNum);
                int[] arr = new int[arrNum];
                for (int i = 0; i < arrNum; i++)
                {
                    Console.Write("element - {0}: ", i);
                    arr[i] = int.Parse(Console.ReadLine());
                }

                int count = 0;
                for (int i = 0; i < arrNum; i++)
                {
                    for (int j = i + 1; j < arrNum; j++)
                    {
                        if (arr[i] == arr[j])
                        {
                            count++;
                            break;
                        }
                    }
                }
                Console.WriteLine("Total number of duplicate elements found in the array is: {0}", count);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
