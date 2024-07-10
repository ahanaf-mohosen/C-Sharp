using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp53
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a program in C# Sharp to convert a binary number to octal.  
              Test Data :  
              Input a binary number :1001  
              Expected Output : 
              The Binary Number : 1001  
              The equivalent Octal Number : 11 
            */


            Console.WriteLine("\n### Binary to Octal ###\n");

            Console.Write("Input a binary number: ");
            string binary = Console.ReadLine();

            int decimalNumber = Convert.ToInt32(binary, 2);
            string octal = Convert.ToString(decimalNumber, 8);

            Console.WriteLine("The Binary Number: {0}", binary);
            Console.WriteLine("The equivalent Octal Number: {0}", octal);
            Console.ReadLine();
        }
    }
}
