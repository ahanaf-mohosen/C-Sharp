using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a C# Sharp program to determine whether a given number is prime or not. 
              Test Data :  
              Input a number: 13  
              Expected Output : 
              13 is a prime number. 
            */

            Console.WriteLine("\n### A given number is prime or not ###\n");


            while (true)
            {
                Console.Write("Input a number: ");
                int num = int.Parse(Console.ReadLine());

                bool isPrime = true;
                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime && num > 1)
                {
                    Console.WriteLine(num + " is a prime number.");
                }
                else
                {
                    Console.WriteLine(num + " is not a prime number.");
                }
                Console.WriteLine();
                Console.ReadKey();
            }
        }
    }
}
