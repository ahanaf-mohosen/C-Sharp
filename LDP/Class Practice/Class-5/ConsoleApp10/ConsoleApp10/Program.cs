using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a program in C# Sharp to delete an element at desired position from a list.  
              Test Data: 
              Input the size of list: 5 
              Input 5 elements in the array in ascending order: 
              element - 0: 1 
              element - 1: 2 
              element - 2: 3 
              element - 3: 4 
              element - 4: 5 
              
              Input the position where to delete: 3 
              
              Expected Output: 
              The new list is: 1 2 4 5
            */

            try
            {
                Console.WriteLine("\n### delete an element at desired position from a list ###\n");
                Console.Write("Input the size of list: ");
                int arrSize = int.Parse(Console.ReadLine());
                int[] arr = new int[arrSize];

                for (int i = 0; i < arrSize; i++)
                {
                    Console.Write("element - {0}: ", i);
                    arr[i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
                Console.Write("The array list is: ");
                for (int i = 0; i < arrSize; i++)
                {
                    Console.Write(arr[i] + " ");
                }
                Console.WriteLine();
                Console.WriteLine();

                Console.Write("Input the position where to delete: ");
                int posDelete = int.Parse(Console.ReadLine());
                if (posDelete < 1 || posDelete > arrSize)
                {
                    throw new IndexOutOfRangeException("Position is out of the range!");
                }

                int[] newArr = new int[arrSize - 1];
                for (int i = 0, j = 0; i < arrSize; i++)
                {
                    if (i != posDelete - 1)
                    {
                        newArr[j] = arr[i];
                        j++;
                    }
                }
                Console.WriteLine();
                Console.Write("The new array list is: ");
                for (int i = 0; i < arrSize - 1; i++)
                {
                    Console.Write(newArr[i] + " ");
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
