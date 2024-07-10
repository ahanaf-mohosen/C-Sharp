using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a program in C# Sharp to display n terms of natural number and their sum.
              Test Data : 7  
              Expected Output :  
              The first 7 natural number is :  
              1 2 3 4 5 6 7  
              The Sum of Natural Number upto 7 terms : 28  
            */


            Console.Write("Enter the number of term: ");
            int term =  int.Parse(Console.ReadLine());
            int sum = 0;
            Console.Write($"The first {term} natural numbers are: ");
            for (int i = 1; i <= term; i++)
            {
                Console.Write(i + " ");
                sum += i;
            }
            Console.WriteLine();
            Console.WriteLine("The Sum is : " + sum);
            Console.ReadLine();
        }
    }
}
