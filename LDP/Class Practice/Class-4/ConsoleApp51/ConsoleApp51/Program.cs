using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp51
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a program in C# Sharp to convert an octal number to decimal without using array.
              Test Data :  
              Input an octal number (using digit 0 - 7) :745  
              Expected Output : 
              The Octal Number : 745  
              The equivalent Decimal Number : 485 
            */

            Console.WriteLine("\n### Octal to Decimal ###\n");

            Console.Write("Input an octal number (using digit 0 - 7): ");
            int octNum = int.Parse(Console.ReadLine());

            int temp = octNum;
            int decNum = 0;
            int baseValue = 1;
            int remainder = 0;

            while (octNum > 0)
            {
                remainder = octNum % 10;
                decNum += remainder * baseValue;
                octNum /= 10;
                baseValue *= 8;
            }
            Console.WriteLine("The Octal Number: {0}", temp);
            Console.WriteLine("The equivalent Decimal Number: {0}", decNum);
            Console.ReadLine();
        }
    }
}
