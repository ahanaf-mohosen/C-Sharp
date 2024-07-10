using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp50
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a program in C# Sharp to convert a decimal number into octal without using an array. 
              Test Data :  
              Enter a number to convert : 79  
              Expected Output : 
              The Octal of 79 is 117. 
            */


            Console.WriteLine("\n### Decimal to Octal ###\n");

            Console.Write("Enter a number to convert: ");
            int decNum = int.Parse(Console.ReadLine());
            int temp = decNum;
            int octNum = 0;
            int baseValue = 1;
            int remainder;

            while (temp > 0)
            {
                remainder = temp % 8;
                octNum += remainder * baseValue;
                baseValue *= 10;
                temp /= 8;
            }
            Console.WriteLine("The Octal of {0} is {1}.", decNum, octNum);
            Console.ReadLine();
        }
    }
}
