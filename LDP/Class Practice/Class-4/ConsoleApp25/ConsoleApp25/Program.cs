using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a program in C# Sharp to display the n terms of square natural number and their sum.
              1 4 9 16 ... n Terms  

              Test Data :  
              Input the number of terms : 5  
              Expected Output : 
              The square natural upto 5 terms are :1 4 9 16 25  
              The Sum of Square Natural Number upto 5 terms = 55 
            */



            Console.WriteLine("\n### The series 1 4 9 16 ... n Terms ###\n");
            Console.Write("Input the number of terms: ");
            int term = Convert.ToInt32(Console.ReadLine());

            int sum = 0;

            Console.Write($"The square natural upto {term} terms are: ");
            for (int i = 1; i <= term; i++)
            {
                int square = (int)Math.Pow(i, 2);
                Console.Write(square + " ");
                sum += square;
            }
            Console.WriteLine();
            Console.WriteLine($"The Sum of Square Natural Number upto {term} terms: " + sum);
            Console.ReadLine();
        }
    }
}
