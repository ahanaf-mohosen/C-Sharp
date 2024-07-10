using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a C# Sharp program to check whether a given number is perfect number or not. 
              Test Data :  
              Input the number : 56  
              Expected Output : 
              The positive divisor : 1 2 4 7 8 14 28  
              The sum of the divisor is : 64  
              So, the number is not perfect. 
            */


            Console.WriteLine("\n### Check whether a given number is perfect number or not ###\n");
            Console.Write("Input the number: ");
            int num = int.Parse(Console.ReadLine());

            int sum = 0;
            Console.Write("The positive divisor: ");
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    Console.Write(i + " ");
                    sum += i;
                }
            }
            Console.WriteLine($"\nThe sum of the divisor is: {sum}");
            if (sum == num)
            {
                Console.WriteLine("So, the number is perfect.");
            }
            else
            {
                Console.WriteLine("So, the number is not perfect.");
            }
            Console.ReadLine();
        }
    }
}
