using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a C# Sharp program to read the age of a candidate and determine whether it is eligible for casting his/her own vote. 
              Test Data : 21 
              Expected Output: Congratulation! You are eligible for casting your vote.
             */

            Console.WriteLine("\n### Check Your Age for Vote to Eligible or Not ###\n");
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if(age >= 18)
            {
                Console.WriteLine("You are eligible for vote.");
            }
            else
            {
                Console.WriteLine("You are not eligible for vote.");
            }
            Console.ReadLine();
        }
    }
}
