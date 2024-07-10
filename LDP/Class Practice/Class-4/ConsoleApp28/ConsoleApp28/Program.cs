using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a C# Sharp program to find the perfect numbers within a given range of number.
              Test Data :  
              Input the starting range or number : 1  
              Input the ending range of number : 50  
              Expected Output : 
              The Perfect numbers within the given range : 6 28  
            */


            Console.WriteLine("\n### Find the perfect numbers within a given range of number ###\n");
            Console.Write("Input the starting range or number: ");
            int startNum = int.Parse(Console.ReadLine());
            Console.Write("Input the ending range or number: ");
            int endNum = int.Parse(Console.ReadLine());

            Console.Write("The Perfect numbers within the given range: ");

            for (int i = startNum; i <= endNum; i++)
            {
                int sum = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        sum += j;
                    }
                }
                if (sum == i)
                {
                    Console.Write(i + " ");
                }
            }
            Console.ReadLine();
        }
    }
}
