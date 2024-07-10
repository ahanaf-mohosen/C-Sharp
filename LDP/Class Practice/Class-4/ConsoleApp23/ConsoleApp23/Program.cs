using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a program in C# Sharp to display the sum of the series [ 1+x+x^2/2!+x^3/3!+....].
              Test Data :  
              Input the value of x :3  
              Input number of terms : 5  
              Expected Output : 
              The sum is : 16.375000  
              Number of terms = 5  
              The value of x = 3.000000 
            */


            Console.WriteLine("\n### The sum of the series [ 1+x+x^2/2!+x^3/3!+....] ###\n");
            Console.Write("Input the value of x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input number of terms: ");
            int term = Convert.ToInt32(Console.ReadLine());

            double sum = 0;
            int count = 0;
            for (int i = 0; i < term; i++)
            {
                sum += Math.Pow(x, i) / Factorial(i);
                count++;
            }

            Console.WriteLine($"The Sum is: {sum:F6}");
            Console.WriteLine($"Number of terms: {count}");
            Console.WriteLine($"The value of x: {x:F6}");
            int Factorial(int number)
            {
                int fact = 1;
                for (int i = 1; i <= number; i++)
                {
                    fact *= i;
                }
                return fact;
            }
            Console.ReadLine();
        }
    }
}

