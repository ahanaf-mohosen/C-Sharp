using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp41
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a program in C# Sharp to convert a decimal number into binary without using an array. 
              Test Data :  
              Enter a number to convert : 25  
              Expected Output : 
              The Binary of 25 is 11001
            */


            Console.WriteLine("\n### Convert a decimal number into binary ###\n");
            Console.Write("Enter a number to convert: ");
            int decNum = int.Parse(Console.ReadLine());
            int num = decNum;
            string binNum = string.Empty;
            while (decNum > 0)
            {
                int remainder = decNum % 2;
                binNum = remainder + binNum;
                decNum /= 2;
            }
            Console.WriteLine($"The Binary of {num} is {binNum}");

            //Console.WriteLine(Convert.ToString(decNum, 2));   //By using this line only can convert decimal to bainary.

            Console.ReadLine();
        }
    }
}