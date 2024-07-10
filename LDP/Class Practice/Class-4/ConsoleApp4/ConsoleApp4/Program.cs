using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a program in C# Sharp to read 10 numbers from keyboard and find their sum and average.
              Test Data : 
              Input the 10 numbers :  
              Number-1 :2  
              ...  
              Number-10 :2  
              Expected Output :  
              The sum of 10 no is : 51  
              The Average is : 5.100000 
            */


            double sum = 0;
            Console.WriteLine("Input 10 numbers are: ");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"Number - {i}:  ");
                double num = int.Parse(Console.ReadLine());
                sum += num;
            }
            Console.WriteLine();
            Console.WriteLine("The Sum of 10 number is : " + sum);
            Console.WriteLine($"The Average is: {(double)sum/10}");
            Console.ReadLine();
        }
    }
}
