using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a program in C# Sharp to find the sum of the series [ 1-X^2/2!+X^4/4!- .........]
              Test Data :  
              Input the Value of x :2  
              Input the number of terms : 5  
              Expected Output : 
              the sum = -0.415873  
              Number of terms = 5  
              value of x = 2.000000 
            */


            Console.WriteLine("\n### The sum of the series [ 1-X^2/2!+X^4/4!- .........] ###\n");
            Console.Write("Input the Value of x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input the number of terms: ");
            int term = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            double sum = 0.0;
            int termsCount = 0;
            int power = 0;
            int sign = -1;
            for (int i = 0; i < term; i++)
            {
                sign = -sign;
                sum += sign*Math.Pow(x,power)/ Factorial(power);
                termsCount++;
                power += 2;
            }
            Console.WriteLine($"The sum: {sum:F6}");
            Console.WriteLine($"Numbers of terms: {termsCount}");
            Console.WriteLine($"Value of x: {x:F6}");
            Console.ReadLine();

            int Factorial (int number)
            {
                int fact = 1;
                for (int i = 1; i<= number; i++)
                {
                    fact *= i;
                }
                return fact;
            }
        }
    }
}
