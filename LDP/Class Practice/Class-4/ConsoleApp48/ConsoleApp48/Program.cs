using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a C# Sharp program to find Strong Numbers within a range of numbers. 
              Test Data :  
              Input starting range of number : 1  
              Input ending range of number: 200  
              Expected Output : 
              The Strong numbers are :  
              1 2 145  
            */


            Console.WriteLine("\n### Find Strong Numbers within a range of numbers ###\n");
            Console.Write("Input starting range of number: ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Input ending range of number: ");
            int end = int.Parse(Console.ReadLine());

            Console.Write("The strong numbers are: ");

            for (int i = start; i <= end; i++)
            {
                int sum = 0;
                int num = i;

                while (num > 0)
                {
                    int fact = 1;
                    int digit = num % 10;
                    for (int j = 1; j <= digit; j++)
                    {
                        fact *= j;
                    }
                    sum += fact;
                    num /= 10;
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
