using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a program in C# Sharp to check whether a number is a palindrome or not. 
              Test Data :  
              Input a number: 121  
              Expected Output : 
              121 is a palindrome number. 
            */


            Console.WriteLine("\n### Check whether a number is a palindrome or not ###\n");
            Console.Write("Input a number: ");
            int num = int.Parse(Console.ReadLine());

            int temp = num;
            int rev = 0;

            while (num > 0)
            {
                int digit = num % 10;
                rev = (rev * 10) + digit;
                num /= 10;
            }

            if (temp == rev)
            {
                Console.WriteLine($"{temp} is a palindrome number.");
            }
            else
            {
                Console.WriteLine($"{temp} is not a palindrome number.");
            }
            Console.ReadLine();
        }
    }
}
