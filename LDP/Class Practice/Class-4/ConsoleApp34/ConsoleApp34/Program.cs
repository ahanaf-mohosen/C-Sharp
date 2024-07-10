using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a program in C# Sharp to find the prime numbers within a range of numbers. 
              Test Data :  
              Input starting number of range: 1  
              Input ending number of range : 50  
              Expected Output : 
              The prime number between 1 and 50 are :  
              2 3 5 7 11 13 17 19 23 29 31 37 41 43 47 
            */


            Console.WriteLine("\n### Find the prime numbers within a range of numbers ###\n");

            while (true)
            {
                Console.Write("Input starting number of range: ");
                int start = int.Parse(Console.ReadLine());
                Console.Write("Input ending number of range: ");
                int end = int.Parse(Console.ReadLine());

                for (int i = start; i <= end; i++)
                {
                    bool isPrime = true;
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if (isPrime && i > 1)
                    {
                        Console.Write(i + " ");
                    }
                }
                Console.WriteLine("\n\n");
                Console.ReadKey();
            }
        }
    }
}
