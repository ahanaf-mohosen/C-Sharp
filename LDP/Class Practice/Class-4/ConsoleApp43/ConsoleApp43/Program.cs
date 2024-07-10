using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp43
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Write a C# Sharp program to find HCF (Highest Common Factor) of two numbers. 
              Test Data :  
              Input 1st number for HCF: 24  
              Input 2nd number for HCF: 28  
              Expected Output : 
              HCF of 24 and 28 is : 4  
            */


            Console.WriteLine("\n### Find HCF (Highest Common Factor) of two numbers ###\n");
            Console.Write("Input 1st number for HCF: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Input 2nd number for HCF: ");
            int num2 = int.Parse(Console.ReadLine());

            int hcf = 0;
            for (int i = 1; i <= num1 && i <= num2; i++)
            {
                if (num1 % i == 0 && num2 % i == 0)
                {
                    hcf = i;
                }
            }
            Console.WriteLine($"HCF of {num1} and {num2} is : {hcf}");
            Console.ReadLine();
        }
    }
}
