using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp54
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a program in C# Sharp to convert an octal number into binary. 
              Test Data :  
              Input an octal number :11  
              Expected Output : 
              The Octal Number : 11  
              The equivalent Binary Number : 1001 
            */


            Console.WriteLine("\n### Octal to Binary ###\n");

            Console.Write("Input a Octal Number: ");
            string octal = Console.ReadLine();

            int decimalNumber = Convert.ToInt32(octal, 8);
            string binary = Convert.ToString(decimalNumber, 2);

            Console.WriteLine("The Octal Number: {0}", octal);
            Console.WriteLine("The equivalent Binary Number: {0}", binary);
            Console.ReadLine();
        }
    }
}
