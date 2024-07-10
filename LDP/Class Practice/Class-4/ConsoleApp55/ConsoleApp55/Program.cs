using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp55
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a program in C# Sharp to convert a decimal number to hexadecimal. 
              Test Data :  
              Input any Decimal number: 79  
              Expected Output : 
              The equivalent Hexadecimal Number : 4F  
            */


            Console.WriteLine("\n### Decimal to Hexadecimal ###\n");

            Console.Write("Input any decimal Number: ");
            int decNum = int.Parse(Console.ReadLine());

            string hexNum = decNum.ToString("X");
            Console.WriteLine("The equivalent Hexadecimal Number: {0}", hexNum);
            Console.ReadLine();
        }
    }
}
