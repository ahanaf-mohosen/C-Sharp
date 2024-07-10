using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a program in C# Sharp to display the first n terms of Fibonacci series.
              Fibonacci series 0 1 1 2 3 5 8 13 ..... 
              Test Data :  
              Input number of terms to display : 10  
              Expected Output : 
              Here is the Fibonacci series upto to 10 terms :  
              0 1 1 2 3 5 8 13 21 34  
            */


            Console.WriteLine("\n### Display the first n terms of Fibonacci series ###\n");
            Console.Write("Input number of terms to display: ");
            int term = int.Parse(Console.ReadLine());

            int num1 = 0;
            int num2 = 1;
            Console.WriteLine($"Here is the Fibonacci series upto to {term} terms: ");
            Console.Write($"{num1} {num2} ");

            
            for (int i = 2; i < term; i++)
            {
                int fib = num1 + num2;
                Console.Write(fib + " ");
                num1 = num2;
                num2 = fib;
            }
            Console.ReadLine();
        }
    }
}
