using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a program in C# Sharp to separate odd and even integers in separate arrays.
              Test Data: 
              Input the number of elements to be stored in the array: 5 
              Input 5 elements in the array: 
              element - 0: 25 
              element - 1: 47 
              element - 2: 42 
              element - 3: 56 
              element - 4: 32 
              Expected Output: 
              The Even elements are: 
              42 56 32 
              The Odd elements are: 
              25 47
            */
            try
            {
                Console.WriteLine("\n### Separate odd and even integers in separate arrays ###\n");
                Console.Write("Input the number of elements to be stored in the array: ");
                int arrNum = int.Parse(Console.ReadLine());
                int[] arr = new int[arrNum];
                Console.WriteLine("Input {0} elements in the array:",arrNum);

                for (int i = 0; i < arrNum; i++)
                {
                    Console.Write("element - {0}: ", i);
                    arr[i] = int.Parse(Console.ReadLine());
                }
                Console.Write("The Even elements are: ");
                for (int i = 0; i < arrNum; i++)
                {
                    if (arr[i] % 2 == 0)
                    {
                        Console.Write(arr[i] + " ");
                    }
                }
                Console.WriteLine();
                Console.Write("The Odd elements are: ");
                for (int i = 0; i < arrNum; i++)
                {
                    if (arr[i] % 2 != 0)
                    {
                        Console.Write(arr[i] + " ");
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
