using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a program in C# Sharp to copy the elements one array into another array.  
              Test Data: 
              Input the number of elements to be stored in the array :3 
              Input 3 elements in the array: 
              element - 0: 15 
              element - 1: 10 
              element - 2: 12

              Expected Output: 
              The elements stored in the first array are: 
              15 10 12 
              The elements copied into the second array are: 
              15 10 12
            */

            try
            {
                Console.WriteLine("\n### Copy the elements one array into another array ###\n");
                Console.Write("Input the number of elements to be stored in the array: ");
                int arrNum = Convert.ToInt32(Console.ReadLine());
                int[] arr1 = new int[arrNum];
                int[] arr2 = new int[arrNum];
                Console.WriteLine("Input {0} elements in the array:", arrNum);
                for (int i = 0; i < arrNum; i++)
                {
                    Console.Write("element - {0}: ", i);
                    arr1[i] = Convert.ToInt32(Console.ReadLine());
                }
                Array.Copy(arr1, arr2, arrNum);
                Console.Write("The elements stored in the first array are: ");
                for (int i = 0; i < arrNum; i++)
                {
                    Console.Write(" " + arr1[i]);
                }
                Console.WriteLine();
                Console.Write("The elements stored in the second array are: ");
                for (int i = 0; i < arrNum; i++)
                {
                    Console.Write(" " + arr2[i]);
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
