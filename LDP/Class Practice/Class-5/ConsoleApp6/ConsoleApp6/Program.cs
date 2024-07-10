using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a program in C# Sharp to print all unique elements in an array. 
              Test Data: 
              Input the number of elements to be stored in the array :3 
              Input 3 elements in the array: 
              element - 0: 1 
              element - 1: 5 
              element - 2: 1 

              Expected Output: 
              The unique elements found in the array are: 5
              */

            try
            {
                Console.WriteLine("\n### Print all unique elements in an array ###\n");
                Console.Write("Input the number of elements to be stored in the array: ");
                int arrNum = int.Parse(Console.ReadLine());
                Console.WriteLine("Input {0} elements in the array:", arrNum);
                int[] arr = new int[arrNum];
                for (int i = 0; i < arrNum; i++)
                {
                    Console.Write("element - {0}: ", i);
                    arr[i] = int.Parse(Console.ReadLine());
                }
                Console.Write("The unique elements found in the array are: ");
                for (int i = 0; i < arrNum; i++)
                {
                    bool isUnique = true;
                    for (int j = 0; j < arrNum; j++)
                    {
                        if ((i != j) && (arr[i] == arr[j]))
                        {
                            isUnique = false;
                            break;
                        }
                    }
                    if (isUnique)
                    {
                        Console.Write("{0} ",arr[i]);
                    }
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
