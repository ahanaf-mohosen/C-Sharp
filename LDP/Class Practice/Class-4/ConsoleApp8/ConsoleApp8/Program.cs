using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a program in C# Sharp to display the n terms of odd natural number and their sum. 
              Test Data:  
              Input number of terms : 10 
              Expected Output : 
              The odd numbers are :1 3 5 7 9 11 13 15 17 19  
              The Sum of odd Natural Number upto 10 terms : 100  
            */

            Console.Write("Enter the number of terms: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int sum = 0, count = 0;
            Console.Write("The odd numbers are : ");
            for (int i = 1; i < n * 2; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i + ", ");
                    sum += i;
                    count++;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"The total odd number is {count} \nThe Sum of odd Natural Number upto {n} terms : {sum}");
            Console.ReadLine();
        }
    }
}
