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
            /*Write a program in C# Sharp to read n number of values in an array and display it in reverse order.  
              Test Data: 
              Input the number of elements to store in the array :3 
              Input 3 number of elements in the array: 
              element - 0: 2 
              element - 1: 5 
              element - 2: 7 
              Expected Output: 
              The values store into the array are: 
              2 5 7 
              The values store into the array in reverse are: 
              7 5 2
              */

            try
            {
                Console.WriteLine("\n### Read n number of values in an array and display it in reverse order ###\n");
                Console.Write("Input the number of elements to store in the array: ");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine($"Input {n} number of elements in the array:");
                int[] arr = new int[n];


                for (int i = 0; i < n; i++)
                {
                    Console.Write($"element - {i}: ");
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
                Console.Write("The values store into the array are: ");
                for (int i = 0; i < n; i++)
                {
                    Console.Write("\t" + arr[i]);
                }
                Console.WriteLine();
                Console.WriteLine();
                Array.Reverse(arr);
                Console.Write("The values store into the array in reverse are: ");
                for (int i = 0; i < n; i++)
                {
                    Console.Write("\t" + arr[i]);
                }
                Console.ReadLine();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine() ;

        }
    }
}
