using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp46
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a program in C# Sharp to convert a binary number into a decimal number using math function. 
              Test Data :  
              Input the binary number :1010100 
              Expected Output : 
              The Binary Number : 1010100  
              The equivalent Decimal Number is : 84 
            */


            Console.WriteLine("\n### Binary to Decimal ###\n");
            Console.Write("Input the binary number: ");
            string binary = Console.ReadLine();

            int decimalNum = Convert.ToInt32(binary, 2);

            Console.WriteLine($"The Binary Number: {binary}");
            Console.WriteLine($"The equivalent Decimal Number is: {decimalNum}");
            Console.ReadLine();
        }
    }
}
