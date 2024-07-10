using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a C# Sharp program to check whether a given number is an Armstrong number or not. 
              Test Data :  
              Input a number: 153  
              Expected Output : 
              153 is an Armstrong number. 
            */


            Console.WriteLine("\n### Check whether a given number is an Armstrong number or not ###\n");
            Console.Write("Input a number: ");
            int num = int.Parse(Console.ReadLine());

            int sum = 0;
            int temp = num;
            while (temp != 0)
            {
                int r = temp % 10;
                sum += (int)Math.Pow(r, 3);
                temp /= 10;
            }
            if (sum == num)
            {
                Console.WriteLine($"{num} is an Armstrong number.");
            }
            else
            {
                Console.WriteLine($"{num} is not an Armstrong number.");
            }
            Console.ReadLine();
        }
    }
}
