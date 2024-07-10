using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp47
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a C# Sharp program to check whether a number is a Strong Number or not. 
              Test Data :  
              Input a number to check whether it is Strong number: 15  
              Expected Output : 
              15 is not Strong number. 
            */


            Console.WriteLine("\n### Find Strong Numbers within a range of numbers ###\n");
            Console.Write("Input a number to check whether it is Strong number: ");
            int num = int.Parse(Console.ReadLine());
            int temp = num;


            int sum = 0;
            while (num > 0)
            {
                int fact = 1;
                int digit = num % 10;
                for (int j = 1; j <= digit; j++)
                {
                    fact *= j;
                }
                sum += fact;
                num /= 10;
            }
            if (sum == temp)
            {
                Console.Write(temp + " is a Strong Number.");
            }
            else
            {
                Console.Write(temp + " is not a Strong Number.");
            }
            Console.ReadLine();
        }
    }
}
