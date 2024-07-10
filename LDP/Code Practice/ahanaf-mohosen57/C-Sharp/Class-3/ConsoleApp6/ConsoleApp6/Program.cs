using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a C# Sharp program to read the value of an integer m and display the value of n is 1 when m is larger than 0, 0 when m is 0 and -1 when m is less than 0. 
              Test Data : -5 
              Expected Output: The value of n = -1
             */

            Console.WriteLine("\n### Check Your Number ###\n");
            Console.Write("Enter Your Number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            
            if(num > 0)
            {
                Console.WriteLine("The value of n is 1.");
            }
            else if(num < 0)
            {
                Console.WriteLine("The value of n is -1.");
            }
            else
            {
                Console.WriteLine("The value of n is 0.");
            }
            Console.ReadLine();
        }
    }
}
