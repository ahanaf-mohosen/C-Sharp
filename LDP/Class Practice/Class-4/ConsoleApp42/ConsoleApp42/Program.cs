using ConsoleApp42;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp42
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a program in C# Sharp to convert a binary number into a decimal number 
              without using array, function and while loop.
              Test Data :  
              Input a binary number :1010101  
              Expected Output : 
              The Binary Number : 1010101  
              The equivalent Decimal Number : 85  
            */



            Console.Write("Input a binary number: ");
            int binary = int.Parse(Console.ReadLine());
            int temp = binary;
            int decimalNumber = 0;
            int baseValue = 1;
            for (; binary > 0;)
            {
                int remainder = binary % 10;
                decimalNumber += remainder * baseValue;
                binary = binary / 10;
                baseValue *= 2;
            }

            Console.WriteLine($"The Binary Number: {temp}");
            Console.WriteLine($"The equivalent Decimal Number: {decimalNumber}");

            Console.ReadLine();
        }
    }
}
 